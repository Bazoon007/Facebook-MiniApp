using Ex01.Services;
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
    public partial class AlbumScannerForm : Form
    {
        private readonly AlbumScanner r_AlbumScanner;
        private readonly ImageList r_AlbumPhotosImageList = new ImageList();
        public AlbumScannerForm(User i_User)
        {
            InitializeComponent();
            r_AlbumScanner = new AlbumScanner(i_User);
            initAlbumScannerForm();
        }

        private void initAlbumScannerForm()
        {
            listBoxAlbumList.Items.Clear();
            listViewAlbumPhotos.Items.Clear();
            listViewAlbumPhotos.View = View.Details;
            listViewAlbumPhotos.Columns.Add("Photos", 200);
            r_AlbumPhotosImageList.ImageSize = new Size(240, 240);
            listViewAlbumPhotos.SmallImageList = r_AlbumPhotosImageList;
            listBoxAlbumList.DisplayMember = "Name";
            int j = 0;
            foreach(Album album in r_AlbumScanner.Albums)
            {
                if(j >= 5)
                {
                    break;
                }
                listBoxAlbumList.Items.Add(album);
                j++;
            }
        }

        private void listBoxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbumList.Items.Count > 0)
            {
                Album selectedAlbum = listBoxAlbumList.SelectedItem as Album;
                pictureBoxAlbumPicture.LoadAsync(selectedAlbum.CoverPhoto.PictureAlbumURL);
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            if (listBoxAlbumList.SelectedItem != null)
            {
                r_AlbumScanner.ScannedAlbum = listBoxAlbumList.SelectedItem as Album;
                listViewAlbumPhotos.Items.Clear();
                if (r_AlbumScanner.ScannedAlbum.Photos != null)
                {
                    foreach (Photo photo in r_AlbumScanner.ScannedAlbum.Photos)
                    {
                        r_AlbumPhotosImageList.Images.Add(photo.ImageNormal);
                        if (photo.Tags != null)
                        {
                            foreach (PhotoTag tag in photo.Tags)
                            {
                                addTaggedFriendNameToCheckedListBox(tag.User.Name);
                            }
                        }
                    }
                    for (int i = 0; i < r_AlbumPhotosImageList.Images.Count; i++)
                    {
                        listViewAlbumPhotos.Items.Add("", i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Album not selected - please select an album to scan.");
            }
        }

        private void addTaggedFriendNameToCheckedListBox(string i_TaggedFriendName)
        {
            if (!checkedListBoxTaggedFriends.Items.Contains(i_TaggedFriendName)) {
                checkedListBoxTaggedFriends.Items.Add(i_TaggedFriendName);
            }
        }
    }
}
