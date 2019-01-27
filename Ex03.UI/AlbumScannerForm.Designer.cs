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
            this.listBoxAlbumList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAlbumPhotos = new System.Windows.Forms.ListView();
            this.checkedListBoxTaggedFriends = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxAlbumPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumberOfPhotosToLike = new System.Windows.Forms.Label();
            this.commandButtonLikeSelectedPhotos = new Ex03.UI.CommandButton();
            this.commandButtonResetFilter = new Ex03.UI.CommandButton();
            this.commandButtonTagFilter = new Ex03.UI.CommandButton();
            this.commandButtonScan = new Ex03.UI.CommandButton();
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
            // commandButtonLikeSelectedPhotos
            // 
            this.commandButtonLikeSelectedPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.commandButtonLikeSelectedPhotos.Command = null;
            this.commandButtonLikeSelectedPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.commandButtonLikeSelectedPhotos.Image = global::Ex03.UI.Properties.Resources.LikeAlbum;
            this.commandButtonLikeSelectedPhotos.Location = new System.Drawing.Point(81, 616);
            this.commandButtonLikeSelectedPhotos.Name = "commandButtonLikeSelectedPhotos";
            this.commandButtonLikeSelectedPhotos.Size = new System.Drawing.Size(388, 265);
            this.commandButtonLikeSelectedPhotos.TabIndex = 13;
            this.commandButtonLikeSelectedPhotos.Text = "Like!";
            this.commandButtonLikeSelectedPhotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.commandButtonLikeSelectedPhotos.UseVisualStyleBackColor = false;
            // 
            // commandButtonResetFilter
            // 
            this.commandButtonResetFilter.Command = null;
            this.commandButtonResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.commandButtonResetFilter.ForeColor = System.Drawing.Color.Blue;
            this.commandButtonResetFilter.Location = new System.Drawing.Point(692, 757);
            this.commandButtonResetFilter.Name = "commandButtonResetFilter";
            this.commandButtonResetFilter.Size = new System.Drawing.Size(241, 124);
            this.commandButtonResetFilter.TabIndex = 14;
            this.commandButtonResetFilter.Text = "Reset Filter";
            this.commandButtonResetFilter.UseVisualStyleBackColor = true;
            // 
            // commandButtonTagFilter
            // 
            this.commandButtonTagFilter.Command = null;
            this.commandButtonTagFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.commandButtonTagFilter.ForeColor = System.Drawing.Color.Blue;
            this.commandButtonTagFilter.Location = new System.Drawing.Point(958, 757);
            this.commandButtonTagFilter.Name = "commandButtonTagFilter";
            this.commandButtonTagFilter.Size = new System.Drawing.Size(241, 124);
            this.commandButtonTagFilter.TabIndex = 15;
            this.commandButtonTagFilter.Text = "Filter Tagged People";
            this.commandButtonTagFilter.UseVisualStyleBackColor = true;
            // 
            // commandButtonScan
            // 
            this.commandButtonScan.Command = null;
            this.commandButtonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.commandButtonScan.ForeColor = System.Drawing.Color.Blue;
            this.commandButtonScan.Location = new System.Drawing.Point(1283, 500);
            this.commandButtonScan.Name = "commandButtonScan";
            this.commandButtonScan.Size = new System.Drawing.Size(417, 111);
            this.commandButtonScan.TabIndex = 16;
            this.commandButtonScan.Text = "Scan";
            this.commandButtonScan.UseVisualStyleBackColor = true;
            // 
            // AlbumScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1882, 972);
            this.Controls.Add(this.commandButtonScan);
            this.Controls.Add(this.commandButtonTagFilter);
            this.Controls.Add(this.commandButtonResetFilter);
            this.Controls.Add(this.commandButtonLikeSelectedPhotos);
            this.Controls.Add(this.labelNumberOfPhotosToLike);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxTaggedFriends);
            this.Controls.Add(this.listViewAlbumPhotos);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAlbumPhotos;
        private System.Windows.Forms.CheckedListBox checkedListBoxTaggedFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNumberOfPhotosToLike;
        private CommandButton commandButtonLikeSelectedPhotos;
        private CommandButton commandButtonResetFilter;
        private CommandButton commandButtonTagFilter;
        private CommandButton commandButtonScan;
    }
}