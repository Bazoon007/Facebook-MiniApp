using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ex01.Services;
using FacebookWrapper.ObjectModel;

namespace Ex01.UI
{
    public partial class AlbumScannerForm : Form
    {
        private readonly AlbumScanner r_AlbumScanner;
        private readonly ImageList imageListAlbumPhoto = new ImageList();

        public AlbumScannerForm(UserFacade i_User)
        {
            InitializeComponent();
            r_AlbumScanner = new AlbumScanner(i_User);
            initAlbumScannerForm();
        }

        private void initAlbumScannerForm()
        {
            listBoxAlbumList.Items.Clear();
            listViewAlbumPhotos.Items.Clear();
            fetchAlbums();
        }

        private void listBoxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAlbumList.Items.Count > 0)
                {
                    Album selectedAlbum = listBoxAlbumList.SelectedItem as Album;
                    pictureBoxAlbumPicture.LoadAsync(selectedAlbum.CoverPhoto.PictureAlbumURL);
                }
            }
            catch
            {
                MessageBox.Show("Error - cannot load album :(.");
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            checkedListBoxTaggedFriends.Items.Clear();
            showAlbumPhotosByFilter(false);
        }

        private void showAlbumPhotosByFilter(bool i_Filter)
        {
            if (listBoxAlbumList.SelectedItem != null)
            {
                r_AlbumScanner.ScannedAlbum = listBoxAlbumList.SelectedItem as Album;
                listViewAlbumPhotos.Items.Clear();
                imageListAlbumPhoto.Images.Clear();
                List<Image> imageList = (List<Image>)r_AlbumScanner.FetchPhotosByFilter(i_Filter, createTaggedPersonList());
                addImagestoImageList(imageList);
                for (int i = 0; i < imageListAlbumPhoto.Images.Count; i++)
                {
                    listViewAlbumPhotos.Items.Add(string.Empty, i);
                }

                List<string> taggedPersonList = (List<string>)r_AlbumScanner.FetchTaggedPersonList(i_Filter);
                addTaggedFriendNameToCheckedListBox(taggedPersonList);
                bool enableScanButtons = imageListAlbumPhoto.Images.Count > 0;
                buttonLikeAllPhotos.Enabled = enableScanButtons;
                buttonTagFilter.Enabled = enableScanButtons;
                buttonResetFilter.Enabled = enableScanButtons;             
            }
            else
            {
                MessageBox.Show("Album not selected - please select an album to scan.");
            }
        }

        private void addTaggedFriendNameToCheckedListBox(List<string> i_TaggedPersonListstring)
        {
            foreach (string taggedPersonName in i_TaggedPersonListstring)
            {
                if (!checkedListBoxTaggedFriends.Items.Contains(taggedPersonName))
                {
                    checkedListBoxTaggedFriends.Items.Add(taggedPersonName);
                }
            }
        }

        private void buttonLikeAllPhotos_Click(object sender, EventArgs e)
        {
            try
            {
                if (r_AlbumScanner.LikeAllPhotos())
                {
                    MessageBox.Show(string.Format("Liking all photos in album {0} - complete!!", r_AlbumScanner.ScannedAlbum.Name));
                }
            }
            catch
            {
                MessageBox.Show(string.Format("Error - cannot like photos in album {0} :(.", r_AlbumScanner.ScannedAlbum.Name));   
            }
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBoxTaggedFriends.CheckedIndices)
            {
                checkedListBoxTaggedFriends.SetItemChecked(i, false);
            }

            showAlbumPhotosByFilter(false);
        }

        private void buttonTagFilter_Click(object sender, EventArgs e)
        {
            showAlbumPhotosByFilter(true);
        }

        private void fetchAlbums()
        {
            listViewAlbumPhotos.View = View.Details;
            listViewAlbumPhotos.Columns.Add(string.Empty, 256);
            imageListAlbumPhoto.ImageSize = new Size(256, 256);
            listViewAlbumPhotos.SmallImageList = imageListAlbumPhoto;
            foreach (Album album in r_AlbumScanner.Albums)
            {
                listBoxAlbumList.Items.Add(album);
            }

            listBoxAlbumList.DisplayMember = "Name";
        }
        
        private void addImagestoImageList(IList<Image> i_ImageList)
        {
            foreach (Image image in i_ImageList)
            {
                imageListAlbumPhoto.Images.Add(image);
            }
        }

        private IList<string> createTaggedPersonList()
        {
            IList<string> taggedPersonList = new List<string>();
            foreach (string taggedPersonName in checkedListBoxTaggedFriends.CheckedItems)
            {
                taggedPersonList.Add(taggedPersonName);
            }

            return taggedPersonList;
        }
    }
}
