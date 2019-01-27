namespace Ex03.UI
{
    internal partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label friendsCountLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hometownLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonBlastFromThePast = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonAlbumScanner = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.userFacadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.userFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userFacadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.friendsCountLabel1 = new System.Windows.Forms.Label();
            this.genderLabel1 = new System.Windows.Forms.Label();
            this.hometownLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            friendsCountLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hometownLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingNavigator)).BeginInit();
            this.userFacadeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(89, 71);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(128, 32);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(89, 103);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(95, 32);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // friendsCountLabel
            // 
            friendsCountLabel.AutoSize = true;
            friendsCountLabel.Location = new System.Drawing.Point(89, 135);
            friendsCountLabel.Name = "friendsCountLabel";
            friendsCountLabel.Size = new System.Drawing.Size(201, 32);
            friendsCountLabel.TabIndex = 4;
            friendsCountLabel.Text = "Friends Count:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(89, 167);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(118, 32);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.Location = new System.Drawing.Point(89, 199);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new System.Drawing.Size(158, 32);
            hometownLabel.TabIndex = 8;
            hometownLabel.Text = "Hometown:";
            // 
            // buttonBlastFromThePast
            // 
            this.buttonBlastFromThePast.Image = ((System.Drawing.Image)(resources.GetObject("buttonBlastFromThePast.Image")));
            this.buttonBlastFromThePast.Location = new System.Drawing.Point(1433, 512);
            this.buttonBlastFromThePast.Name = "buttonBlastFromThePast";
            this.buttonBlastFromThePast.Size = new System.Drawing.Size(350, 200);
            this.buttonBlastFromThePast.TabIndex = 5;
            this.buttonBlastFromThePast.UseVisualStyleBackColor = true;
            this.buttonBlastFromThePast.Click += new System.EventHandler(this.buttonBlastFromThePast_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = global::Ex03.UI.Properties.Resources.Logout;
            this.buttonLogout.Location = new System.Drawing.Point(612, 836);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(738, 124);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(213, 167);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(250, 195);
            this.pictureBoxProfilePicture.TabIndex = 2;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonAlbumScanner
            // 
            this.buttonAlbumScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAlbumScanner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonAlbumScanner.Image = global::Ex03.UI.Properties.Resources.AlbumScanner;
            this.buttonAlbumScanner.Location = new System.Drawing.Point(1382, 167);
            this.buttonAlbumScanner.Name = "buttonAlbumScanner";
            this.buttonAlbumScanner.Size = new System.Drawing.Size(401, 253);
            this.buttonAlbumScanner.TabIndex = 0;
            this.buttonAlbumScanner.Text = "AlbumScanner";
            this.buttonAlbumScanner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAlbumScanner.UseVisualStyleBackColor = true;
            this.buttonAlbumScanner.Click += new System.EventHandler(this.buttonAlbumScanner_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(267, 874);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(269, 41);
            this.checkBoxRememberMe.TabIndex = 7;
            this.checkBoxRememberMe.Text = "Remember me?";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // userFacadeBindingNavigator
            // 
            this.userFacadeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userFacadeBindingNavigator.BindingSource = this.userFacadeBindingSource;
            this.userFacadeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userFacadeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userFacadeBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.userFacadeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userFacadeBindingNavigatorSaveItem});
            this.userFacadeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userFacadeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userFacadeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userFacadeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userFacadeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userFacadeBindingNavigator.Name = "userFacadeBindingNavigator";
            this.userFacadeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userFacadeBindingNavigator.Size = new System.Drawing.Size(2014, 31);
            this.userFacadeBindingNavigator.TabIndex = 8;
            this.userFacadeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // userFacadeBindingSource
            // 
            this.userFacadeBindingSource.DataSource = typeof(Ex03.Services.UserFacade);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // userFacadeBindingNavigatorSaveItem
            // 
            this.userFacadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userFacadeBindingNavigatorSaveItem.Enabled = false;
            this.userFacadeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userFacadeBindingNavigatorSaveItem.Image")));
            this.userFacadeBindingNavigatorSaveItem.Name = "userFacadeBindingNavigatorSaveItem";
            this.userFacadeBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.userFacadeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(birthdayLabel);
            this.groupBoxDetails.Controls.Add(this.birthdayLabel1);
            this.groupBoxDetails.Controls.Add(emailLabel);
            this.groupBoxDetails.Controls.Add(this.emailLabel1);
            this.groupBoxDetails.Controls.Add(friendsCountLabel);
            this.groupBoxDetails.Controls.Add(this.friendsCountLabel1);
            this.groupBoxDetails.Controls.Add(genderLabel);
            this.groupBoxDetails.Controls.Add(this.genderLabel1);
            this.groupBoxDetails.Controls.Add(hometownLabel);
            this.groupBoxDetails.Controls.Add(this.hometownLabel1);
            this.groupBoxDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxDetails.Location = new System.Drawing.Point(213, 389);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(659, 312);
            this.groupBoxDetails.TabIndex = 6;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(296, 71);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(158, 32);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label3";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(296, 103);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(290, 32);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "label3";
            // 
            // friendsCountLabel1
            // 
            this.friendsCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "FriendsCount", true));
            this.friendsCountLabel1.Location = new System.Drawing.Point(296, 135);
            this.friendsCountLabel1.Name = "friendsCountLabel1";
            this.friendsCountLabel1.Size = new System.Drawing.Size(158, 32);
            this.friendsCountLabel1.TabIndex = 5;
            this.friendsCountLabel1.Text = "label3";
            // 
            // genderLabel1
            // 
            this.genderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Gender", true));
            this.genderLabel1.Location = new System.Drawing.Point(296, 167);
            this.genderLabel1.Name = "genderLabel1";
            this.genderLabel1.Size = new System.Drawing.Size(158, 32);
            this.genderLabel1.TabIndex = 7;
            this.genderLabel1.Text = "label3";
            // 
            // hometownLabel1
            // 
            this.hometownLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Hometown", true));
            this.hometownLabel1.Location = new System.Drawing.Point(296, 199);
            this.hometownLabel1.Name = "hometownLabel1";
            this.hometownLabel1.Size = new System.Drawing.Size(158, 32);
            this.hometownLabel1.TabIndex = 9;
            this.hometownLabel1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(207, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome,";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameLabel1.Location = new System.Drawing.Point(359, 119);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(100, 36);
            this.firstNameLabel1.TabIndex = 12;
            this.firstNameLabel1.Text = "label3";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLabel1.Location = new System.Drawing.Point(465, 119);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(100, 36);
            this.lastNameLabel1.TabIndex = 13;
            this.lastNameLabel1.Text = "label3";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2014, 1027);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userFacadeBindingNavigator);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.buttonBlastFromThePast);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonAlbumScanner);
            this.Name = "MainForm";
            this.Text = "Facebook MiniApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingNavigator)).EndInit();
            this.userFacadeBindingNavigator.ResumeLayout(false);
            this.userFacadeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlbumScanner;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBlastFromThePast;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.BindingSource userFacadeBindingSource;
        private System.Windows.Forms.BindingNavigator userFacadeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userFacadeBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label friendsCountLabel1;
        private System.Windows.Forms.Label genderLabel1;
        private System.Windows.Forms.Label hometownLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
    }
}