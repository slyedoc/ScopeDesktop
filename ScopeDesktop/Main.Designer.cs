namespace ScopeDesktop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_video = new System.Windows.Forms.PictureBox();
            this.cb_devices = new System.Windows.Forms.ComboBox();
            this.b_StartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.b_Screenshot = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.cb_ProjectFolder = new System.Windows.Forms.CheckBox();
            this.cb_Upload = new System.Windows.Forms.CheckBox();
            this.cb_thumbnails = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_video
            // 
            this.pb_video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_video.BackColor = System.Drawing.SystemColors.InfoText;
            this.pb_video.Location = new System.Drawing.Point(12, 61);
            this.pb_video.Name = "pb_video";
            this.pb_video.Size = new System.Drawing.Size(791, 200);
            this.pb_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_video.TabIndex = 2;
            this.pb_video.TabStop = false;
            // 
            // cb_devices
            // 
            this.cb_devices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_devices.FormattingEnabled = true;
            this.cb_devices.Location = new System.Drawing.Point(61, 267);
            this.cb_devices.Name = "cb_devices";
            this.cb_devices.Size = new System.Drawing.Size(742, 21);
            this.cb_devices.TabIndex = 3;
            // 
            // b_StartStop
            // 
            this.b_StartStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_StartStop.Location = new System.Drawing.Point(12, 294);
            this.b_StartStop.Name = "b_StartStop";
            this.b_StartStop.Size = new System.Drawing.Size(791, 23);
            this.b_StartStop.TabIndex = 4;
            this.b_StartStop.Text = "Start/Stop";
            this.b_StartStop.UseVisualStyleBackColor = true;
            this.b_StartStop.Click += new System.EventHandler(this.b_StartStop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project";
            // 
            // tb_project
            // 
            this.tb_project.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_project.Location = new System.Drawing.Point(55, 6);
            this.tb_project.Name = "tb_project";
            this.tb_project.Size = new System.Drawing.Size(748, 20);
            this.tb_project.TabIndex = 8;
            // 
            // b_Screenshot
            // 
            this.b_Screenshot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Screenshot.Location = new System.Drawing.Point(12, 32);
            this.b_Screenshot.Name = "b_Screenshot";
            this.b_Screenshot.Size = new System.Drawing.Size(542, 23);
            this.b_Screenshot.TabIndex = 9;
            this.b_Screenshot.Text = "Screenshot";
            this.b_Screenshot.UseVisualStyleBackColor = true;
            this.b_Screenshot.Click += new System.EventHandler(this.b_Screenshot_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Message
            // 
            this.tssl_Message.Name = "tssl_Message";
            this.tssl_Message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tssl_Message.Size = new System.Drawing.Size(39, 17);
            this.tssl_Message.Text = "Ready";
            // 
            // cb_ProjectFolder
            // 
            this.cb_ProjectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ProjectFolder.AutoSize = true;
            this.cb_ProjectFolder.Checked = true;
            this.cb_ProjectFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ProjectFolder.Location = new System.Drawing.Point(712, 36);
            this.cb_ProjectFolder.Name = "cb_ProjectFolder";
            this.cb_ProjectFolder.Size = new System.Drawing.Size(91, 17);
            this.cb_ProjectFolder.TabIndex = 11;
            this.cb_ProjectFolder.Text = "Project Folder";
            this.cb_ProjectFolder.UseVisualStyleBackColor = true;
            // 
            // cb_Upload
            // 
            this.cb_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Upload.AutoSize = true;
            this.cb_Upload.Checked = true;
            this.cb_Upload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Upload.Location = new System.Drawing.Point(560, 36);
            this.cb_Upload.Name = "cb_Upload";
            this.cb_Upload.Size = new System.Drawing.Size(60, 17);
            this.cb_Upload.TabIndex = 12;
            this.cb_Upload.Text = "Upload";
            this.cb_Upload.UseVisualStyleBackColor = true;
            // 
            // cb_thumbnails
            // 
            this.cb_thumbnails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_thumbnails.AutoSize = true;
            this.cb_thumbnails.Checked = true;
            this.cb_thumbnails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_thumbnails.Location = new System.Drawing.Point(626, 36);
            this.cb_thumbnails.Name = "cb_thumbnails";
            this.cb_thumbnails.Size = new System.Drawing.Size(80, 17);
            this.cb_thumbnails.TabIndex = 13;
            this.cb_thumbnails.Text = "Thumbnails";
            this.cb_thumbnails.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.cb_thumbnails);
            this.Controls.Add(this.cb_Upload);
            this.Controls.Add(this.cb_ProjectFolder);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.b_Screenshot);
            this.Controls.Add(this.tb_project);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_StartStop);
            this.Controls.Add(this.cb_devices);
            this.Controls.Add(this.pb_video);
            this.Name = "Main";
            this.Text = "Scope Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_video)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_video;
        private System.Windows.Forms.ComboBox cb_devices;
        private System.Windows.Forms.Button b_StartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_project;
        private System.Windows.Forms.Button b_Screenshot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Message;
        private System.Windows.Forms.CheckBox cb_ProjectFolder;
        private System.Windows.Forms.CheckBox cb_Upload;
        private System.Windows.Forms.CheckBox cb_thumbnails;
    }
}

