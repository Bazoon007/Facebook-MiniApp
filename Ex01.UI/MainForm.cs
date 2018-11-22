using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.UI
{
    public partial class MainForm : Form
    {
        private User m_User;
        public MainForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_User = i_LoginResult.LoggedInUser;
            initMainForm();
        }

        private void initMainForm()
        {
            labelWelcome.Text = string.Format("Welcome, {0} {1}!", m_User.FirstName, m_User.LastName);
            pictureboxProfilePicture.LoadAsync(m_User.PictureNormalURL);
        }


        private void populateAlbumNames()
        {
            List<Album> albumsList = FacebookServices.PopulateAlbumNames(m_FacebookUser);

            albumListBox.Items.Clear();
            albumListBox.DisplayMember = "Name";
            foreach (Album album in albumsList)
            {
                albumListBox.Items.Add(album);
            }
        }
    }
}
