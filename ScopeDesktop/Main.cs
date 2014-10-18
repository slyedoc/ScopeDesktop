using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;




namespace ScopeDesktop
{
    public partial class Main : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice();

            var selected = Properties.Settings.Default[Settings.VideoSource].ToString();
            //delete c:\Users\username\AppData\Local\scopedesktop if this fails
            
            foreach (FilterInfo device in videoDevices)
            {
                cb_devices.Items.Add(device.Name);
                if (selected == device.MonikerString)
                {
                    cb_devices.SelectedIndex = cb_devices.Items.Count - 1;
                    StartStop();
                }
            }
             
            if(cb_devices.SelectedIndex < 0)
                cb_devices.SelectedIndex = 0;

            //load settings
            cb_Upload.Checked = bool.Parse( Properties.Settings.Default[Settings.Upload].ToString() );
            cb_ProjectFolder.Checked = bool.Parse(Properties.Settings.Default[Settings.ProjectFolder].ToString());
            cb_thumbnails.Checked = bool.Parse(Properties.Settings.Default[Settings.Thumbnail].ToString());
            tb_project.Text = Properties.Settings.Default[Settings.Project].ToString();
        }

        private void b_StartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void StartStop()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pb_video.Image = null;
                pb_video.Invalidate();
            }
            else
            {

                var videoSourceName = videoDevices[cb_devices.SelectedIndex].MonikerString;

                videoSource = new VideoCaptureDevice(videoSourceName);
                videoSource.NewFrame += videoSource_NewFrame;
                videoSource.Start();
            }
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pb_video.Image = image;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default[Settings.Upload] = cb_Upload.Checked;
            Properties.Settings.Default[Settings.ProjectFolder] = cb_ProjectFolder.Checked;
            Properties.Settings.Default[Settings.Thumbnail] = cb_thumbnails.Checked;
            Properties.Settings.Default[Settings.VideoSource] = videoDevices[cb_devices.SelectedIndex].MonikerString;
            Properties.Settings.Default[Settings.Project] = tb_project.Text; 
            Properties.Settings.Default.Save();

            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }

        private void TakeScreenshot()
        {
            if (!videoSource.IsRunning)
                return;

            //find a valid path
            var filename = string.Format(@"{0}.jpg", DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss.fff") );
            var name = "";
            var validDirectory = !Path.GetInvalidPathChars().Any( tb_project.Text.Contains);
            var validFile = !Path.GetInvalidFileNameChars().Any( tb_project.Text.Contains);

            if (tb_project.Text != string.Empty && cb_ProjectFolder.Checked && validDirectory)
            {
                var dir = string.Format(@"{0}\{1}", Environment.CurrentDirectory, tb_project.Text);
                if (!Directory.Exists(dir))
                { 
                    Directory.CreateDirectory( dir );
                }
                name = string.Format(@"{0}\{1}", dir, filename);
            }
            else if(tb_project.Text != string.Empty && !cb_ProjectFolder.Checked && validFile)
            {
                name = string.Format(@"{0}\{1}-{2}", Environment.CurrentDirectory, tb_project.Text, filename);
            }
            else
            {
                name = string.Format(@"{0}\{1}", Environment.CurrentDirectory, filename);
            }
            

            //save the file
            Bitmap image = (Bitmap)pb_video.Image.Clone();
            image.Save(name, System.Drawing.Imaging.ImageFormat.Jpeg);
            tssl_Message.Text = string.Format("Screenshot saved to {0}", name);

            if(cb_Upload.Checked)
            {
                Upload(image, tb_project.Text, filename );
            }
        }

        public void Upload(Bitmap image, string containerName, string filename) 
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse( ConfigurationManager.ConnectionStrings[Settings.Storage].ConnectionString);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExists();

            container.SetPermissions(new BlobContainerPermissions {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });
            
            
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(filename);
            var stream = GetImageStream(image);
            blockBlob.UploadFromStream(stream);
            
            if (cb_thumbnails.Checked)
            {
                var loop = 16;
                for (int i = 2; i <= loop; i *= i)
                {
                    var thumbnail = ResizeImage(image, i);
                    blockBlob = container.GetBlockBlobReference(filename.Replace(".jpg", string.Format("x{0}.jpg", i)));
                    stream = GetImageStream(thumbnail);
                    blockBlob.UploadFromStream(stream);
                }
            
            }


        }

        public static Bitmap ResizeImage(Bitmap image, int zoom)
        {

            var x = image.Width / zoom;
            var y = image.Height / zoom;
            Bitmap b = new Bitmap(x, y);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, x, y);
            }
            return b;

        }

        private Stream GetImageStream(Bitmap image)
        {

            MemoryStream s = new MemoryStream();
            image.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);
            s.Position = 0;
            return s;
        }

        private void b_Screenshot_Click(object sender, EventArgs e)
        {
            TakeScreenshot();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space) && ActiveControl != tb_project)
            {
                TakeScreenshot();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
