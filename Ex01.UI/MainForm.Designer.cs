namespace Ex01.UI
{
    partial class MainForm
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
            this.buttonAlbumScanner = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureboxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureboxCoverPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlbumScanner
            // 
            this.buttonAlbumScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbumScanner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAlbumScanner.Image = global::Ex01.UI.Properties.Resources.Album_Scanner;
            this.buttonAlbumScanner.Location = new System.Drawing.Point(852, 605);
            this.buttonAlbumScanner.Name = "buttonAlbumScanner";
            this.buttonAlbumScanner.Size = new System.Drawing.Size(401, 253);
            this.buttonAlbumScanner.TabIndex = 0;
            this.buttonAlbumScanner.Text = "AlbumScanner";
            this.buttonAlbumScanner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAlbumScanner.UseVisualStyleBackColor = true;
            this.buttonAlbumScanner.Click += new System.EventHandler(this.buttonAlbumScanner_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(209, 193);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 20);
            this.labelWelcome.TabIndex = 1;
            // 
            // pictureboxProfilePicture
            // 
            this.pictureboxProfilePicture.Location = new System.Drawing.Point(213, 256);
            this.pictureboxProfilePicture.Name = "pictureboxProfilePicture";
            this.pictureboxProfilePicture.Size = new System.Drawing.Size(295, 239);
            this.pictureboxProfilePicture.TabIndex = 2;
            this.pictureboxProfilePicture.TabStop = false;
            // 
            // pictureboxCoverPhoto
            // 
            this.pictureboxCoverPhoto.Location = new System.Drawing.Point(446, 17);
            this.pictureboxCoverPhoto.Name = "pictureboxCoverPhoto";
            this.pictureboxCoverPhoto.Size = new System.Drawing.Size(1185, 132);
            this.pictureboxCoverPhoto.TabIndex = 3;
            this.pictureboxCoverPhoto.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2014, 1027);
            this.Controls.Add(this.pictureboxCoverPhoto);
            this.Controls.Add(this.pictureboxProfilePicture);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAlbumScanner);
            this.Name = "MainForm";
            this.Text = "Facebook MiniApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlbumScanner;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureboxProfilePicture;
        private System.Windows.Forms.PictureBox pictureboxCoverPhoto;
    }
}