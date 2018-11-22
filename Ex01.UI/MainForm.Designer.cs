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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonAlbumScanner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(209, 193);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 20);
            this.labelWelcome.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::Ex01.UI.Properties.Resources.Logout;
            this.buttonLogout.Location = new System.Drawing.Point(40, 891);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(738, 124);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(446, 17);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(1185, 132);
            this.pictureBoxCoverPhoto.TabIndex = 3;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(213, 256);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(295, 239);
            this.pictureBoxProfilePicture.TabIndex = 2;
            this.pictureBoxProfilePicture.TabStop = false;
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
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2014, 1027);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAlbumScanner);
            this.Name = "MainForm";
            this.Text = "Facebook MiniApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlbumScanner;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.Button buttonLogout;
    }
}