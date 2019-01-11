namespace Ex03.UI
{
    public partial class AlbumScannerForm
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
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.buttonLikeSelectedPhotos = new System.Windows.Forms.Button();
            this.pictureBoxAlbumPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumberOfPhotosToLike = new System.Windows.Forms.Label();
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
            this.buttonScan.Location = new System.Drawing.Point(1283, 522);
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
            this.listViewAlbumPhotos.Size = new System.Drawing.Size(509, 484);
            this.listViewAlbumPhotos.TabIndex = 4;
            this.listViewAlbumPhotos.UseCompatibleStateImageBehavior = false;
            this.listViewAlbumPhotos.Click += new System.EventHandler(this.listViewAlbumPhotos_Click);
            // 
            // checkedListBoxTaggedFriends
            // 
            this.checkedListBoxTaggedFriends.FormattingEnabled = true;
            this.checkedListBoxTaggedFriends.Location = new System.Drawing.Point(1312, 757);
            this.checkedListBoxTaggedFriends.Name = "checkedListBoxTaggedFriends";
            this.checkedListBoxTaggedFriends.Size = new System.Drawing.Size(269, 130);
            this.checkedListBoxTaggedFriends.TabIndex = 5;
            // 
            // buttonTagFilter
            // 
            this.buttonTagFilter.Enabled = false;
            this.buttonTagFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonTagFilter.ForeColor = System.Drawing.Color.Blue;
            this.buttonTagFilter.Location = new System.Drawing.Point(1013, 757);
            this.buttonTagFilter.Name = "buttonTagFilter";
            this.buttonTagFilter.Size = new System.Drawing.Size(241, 124);
            this.buttonTagFilter.TabIndex = 6;
            this.buttonTagFilter.Text = "Filter Tagged People";
            this.buttonTagFilter.UseVisualStyleBackColor = true;
            this.buttonTagFilter.Click += new System.EventHandler(this.buttonTagFilter_Click);
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Enabled = false;
            this.buttonResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonResetFilter.ForeColor = System.Drawing.Color.Blue;
            this.buttonResetFilter.Location = new System.Drawing.Point(722, 757);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(241, 124);
            this.buttonResetFilter.TabIndex = 8;
            this.buttonResetFilter.Text = "Reset Filter";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // buttonLikeSelectedPhotos
            // 
            this.buttonLikeSelectedPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonLikeSelectedPhotos.Enabled = false;
            this.buttonLikeSelectedPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLikeSelectedPhotos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLikeSelectedPhotos.Image = ((System.Drawing.Image)(resources.GetObject("buttonLikeSelectedPhotos.Image")));
            this.buttonLikeSelectedPhotos.Location = new System.Drawing.Point(120, 599);
            this.buttonLikeSelectedPhotos.Name = "buttonLikeSelectedPhotos";
            this.buttonLikeSelectedPhotos.Size = new System.Drawing.Size(388, 265);
            this.buttonLikeSelectedPhotos.TabIndex = 7;
            this.buttonLikeSelectedPhotos.Text = "Like!";
            this.buttonLikeSelectedPhotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLikeSelectedPhotos.UseVisualStyleBackColor = false;
            this.buttonLikeSelectedPhotos.Click += new System.EventHandler(this.buttonLikeSelectedPhotos_Click);
            // 
            // pictureBoxAlbumPicture
            // 
            this.pictureBoxAlbumPicture.Location = new System.Drawing.Point(1283, 139);
            this.pictureBoxAlbumPicture.Name = "pictureBoxAlbumPicture";
            this.pictureBoxAlbumPicture.Size = new System.Drawing.Size(417, 277);
            this.pictureBoxAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAlbumPicture.TabIndex = 1;
            this.pictureBoxAlbumPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(519, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Photo List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1304, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tagged People";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(114, 888);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total photos to like :";
            // 
            // labelNumberOfPhotosToLike
            // 
            this.labelNumberOfPhotosToLike.AutoSize = true;
            this.labelNumberOfPhotosToLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNumberOfPhotosToLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberOfPhotosToLike.Location = new System.Drawing.Point(427, 888);
            this.labelNumberOfPhotosToLike.Name = "labelNumberOfPhotosToLike";
            this.labelNumberOfPhotosToLike.Size = new System.Drawing.Size(32, 32);
            this.labelNumberOfPhotosToLike.TabIndex = 12;
            this.labelNumberOfPhotosToLike.Text = "0";
            // 
            // AlbumScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1882, 972);
            this.Controls.Add(this.labelNumberOfPhotosToLike);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonResetFilter);
            this.Controls.Add(this.buttonLikeSelectedPhotos);
            this.Controls.Add(this.buttonTagFilter);
            this.Controls.Add(this.checkedListBoxTaggedFriends);
            this.Controls.Add(this.listViewAlbumPhotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.pictureBoxAlbumPicture);
            this.Controls.Add(this.listBoxAlbumList);
            this.Name = "AlbumScannerForm";
            this.Text = "Album Scanner";
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
        private System.Windows.Forms.Button buttonLikeSelectedPhotos;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNumberOfPhotosToLike;
    }
}