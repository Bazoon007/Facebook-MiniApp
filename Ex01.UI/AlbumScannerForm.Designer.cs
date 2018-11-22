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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumScannerForm));
            this.listBoxAlbumList = new System.Windows.Forms.ListBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAlbumPhotos = new System.Windows.Forms.ListView();
            this.checkedListBoxTaggedFriends = new System.Windows.Forms.CheckedListBox();
            this.buttonTagFilter = new System.Windows.Forms.Button();
            this.buttonLikeAllPhotos = new System.Windows.Forms.Button();
            this.pictureBoxAlbumPicture = new System.Windows.Forms.PictureBox();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbumList
            // 
            this.listBoxAlbumList.FormattingEnabled = true;
            this.listBoxAlbumList.ItemHeight = 20;
            this.listBoxAlbumList.Location = new System.Drawing.Point(81, 100);
            this.listBoxAlbumList.Name = "listBoxAlbumList";
            this.listBoxAlbumList.Size = new System.Drawing.Size(289, 484);
            this.listBoxAlbumList.TabIndex = 0;
            this.listBoxAlbumList.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumList_SelectedIndexChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonScan.ForeColor = System.Drawing.Color.Blue;
            this.buttonScan.Location = new System.Drawing.Point(1284, 505);
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
            // listViewAlbumPhotos
            // 
            this.listViewAlbumPhotos.Location = new System.Drawing.Point(433, 100);
            this.listViewAlbumPhotos.Name = "listViewAlbumPhotos";
            this.listViewAlbumPhotos.Size = new System.Drawing.Size(530, 484);
            this.listViewAlbumPhotos.TabIndex = 4;
            this.listViewAlbumPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBoxTaggedFriends
            // 
            this.checkedListBoxTaggedFriends.FormattingEnabled = true;
            this.checkedListBoxTaggedFriends.Location = new System.Drawing.Point(433, 635);
            this.checkedListBoxTaggedFriends.Name = "checkedListBoxTaggedFriends";
            this.checkedListBoxTaggedFriends.Size = new System.Drawing.Size(269, 130);
            this.checkedListBoxTaggedFriends.TabIndex = 5;
            // 
            // buttonTagFilter
            // 
            this.buttonTagFilter.Enabled = false;
            this.buttonTagFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonTagFilter.ForeColor = System.Drawing.Color.Blue;
            this.buttonTagFilter.Location = new System.Drawing.Point(806, 641);
            this.buttonTagFilter.Name = "buttonTagFilter";
            this.buttonTagFilter.Size = new System.Drawing.Size(241, 124);
            this.buttonTagFilter.TabIndex = 6;
            this.buttonTagFilter.Text = "Filter Tagged People";
            this.buttonTagFilter.UseVisualStyleBackColor = true;
            this.buttonTagFilter.Click += new System.EventHandler(this.buttonTagFilter_Click);
            // 
            // buttonLikeAllPhotos
            // 
            this.buttonLikeAllPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLikeAllPhotos.Enabled = false;
            this.buttonLikeAllPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikeAllPhotos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLikeAllPhotos.Image = ((System.Drawing.Image)(resources.GetObject("buttonLikeAllPhotos.Image")));
            this.buttonLikeAllPhotos.Location = new System.Drawing.Point(27, 622);
            this.buttonLikeAllPhotos.Name = "buttonLikeAllPhotos";
            this.buttonLikeAllPhotos.Size = new System.Drawing.Size(388, 265);
            this.buttonLikeAllPhotos.TabIndex = 7;
            this.buttonLikeAllPhotos.Text = "Like all photos in album!";
            this.buttonLikeAllPhotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLikeAllPhotos.UseVisualStyleBackColor = false;
            this.buttonLikeAllPhotos.Click += new System.EventHandler(this.buttonLikeAllPhotos_Click);
            // 
            // pictureBoxAlbumPicture
            // 
            this.pictureBoxAlbumPicture.Location = new System.Drawing.Point(1189, 82);
            this.pictureBoxAlbumPicture.Name = "pictureBoxAlbumPicture";
            this.pictureBoxAlbumPicture.Size = new System.Drawing.Size(605, 392);
            this.pictureBoxAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAlbumPicture.TabIndex = 1;
            this.pictureBoxAlbumPicture.TabStop = false;
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Enabled = false;
            this.buttonResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonResetFilter.ForeColor = System.Drawing.Color.Blue;
            this.buttonResetFilter.Location = new System.Drawing.Point(806, 782);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(241, 124);
            this.buttonResetFilter.TabIndex = 8;
            this.buttonResetFilter.Text = "Reset Filter";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // AlbumScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1882, 972);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.buttonLikeAllPhotos);
            this.Controls.Add(this.buttonTagFilter);
            this.Controls.Add(this.checkedListBoxTaggedFriends);
            this.Controls.Add(this.listViewAlbumPhotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.pictureBoxAlbumPicture);
            this.Controls.Add(this.listBoxAlbumList);
            this.Name = "AlbumScannerForm";
            this.Text = "AlbumScannerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbumList;
        private System.Windows.Forms.PictureBox pictureBoxAlbumPicture;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAlbumPhotos;
        private System.Windows.Forms.CheckedListBox checkedListBoxTaggedFriends;
        private System.Windows.Forms.Button buttonTagFilter;
        private System.Windows.Forms.Button buttonLikeAllPhotos;
        private System.Windows.Forms.Button buttonResetFilter;
    }
}