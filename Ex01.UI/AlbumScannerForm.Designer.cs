namespace Ex01.UI
{
    partial class AlbumScannerForm
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
            this.listboxAlbumList = new System.Windows.Forms.ListBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listviewAlbumPhotos = new System.Windows.Forms.ListView();
            this.pictureboxAlbumPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxAlbumList
            // 
            this.listboxAlbumList.FormattingEnabled = true;
            this.listboxAlbumList.ItemHeight = 20;
            this.listboxAlbumList.Location = new System.Drawing.Point(81, 100);
            this.listboxAlbumList.Name = "listboxAlbumList";
            this.listboxAlbumList.Size = new System.Drawing.Size(289, 484);
            this.listboxAlbumList.TabIndex = 0;
            this.listboxAlbumList.SelectedIndexChanged += new System.EventHandler(this.listboxAlbumList_SelectedIndexChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonScan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonScan.Location = new System.Drawing.Point(1131, 525);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(417, 111);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Album List";
            // 
            // listviewAlbumPhotos
            // 
            this.listviewAlbumPhotos.Location = new System.Drawing.Point(433, 100);
            this.listviewAlbumPhotos.Name = "listviewAlbumPhotos";
            this.listviewAlbumPhotos.Size = new System.Drawing.Size(530, 484);
            this.listviewAlbumPhotos.TabIndex = 4;
            this.listviewAlbumPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // pictureboxAlbumPicture
            // 
            this.pictureboxAlbumPicture.Location = new System.Drawing.Point(1016, 100);
            this.pictureboxAlbumPicture.Name = "pictureboxAlbumPicture";
            this.pictureboxAlbumPicture.Size = new System.Drawing.Size(605, 392);
            this.pictureboxAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxAlbumPicture.TabIndex = 1;
            this.pictureboxAlbumPicture.TabStop = false;
            // 
            // AlbumScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1882, 972);
            this.Controls.Add(this.listviewAlbumPhotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.pictureboxAlbumPicture);
            this.Controls.Add(this.listboxAlbumList);
            this.Name = "AlbumScannerForm";
            this.Text = "AlbumScannerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxAlbumList;
        private System.Windows.Forms.PictureBox pictureboxAlbumPicture;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listviewAlbumPhotos;
    }
}