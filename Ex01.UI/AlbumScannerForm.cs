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
            listboxAlbumList.Items.Clear();
            listviewAlbumPhotos.Items.Clear();
            listviewAlbumPhotos.View = View.Details;
            listviewAlbumPhotos.Columns.Add("Photos", 200);
            r_AlbumPhotosImageList.ImageSize = new Size(240, 240);
            listviewAlbumPhotos.SmallImageList = r_AlbumPhotosImageList;
            listboxAlbumList.DisplayMember = "Name";
            foreach(Album album in r_AlbumScanner.Albums)
            {
                listboxAlbumList.Items.Add(album);
            }
        }

        private void listboxAlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxAlbumList.Items.Count > 0)
            {
                Album selectedAlbum = listboxAlbumList.SelectedItem as Album;
                pictureboxAlbumPicture.LoadAsync(selectedAlbum.CoverPhoto.PictureAlbumURL);
            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            if (listboxAlbumList.SelectedItem != null)
            {
                r_AlbumScanner.ScannedAlbum = listboxAlbumList.SelectedItem as Album;
                listviewAlbumPhotos.Items.Clear();
                foreach (Photo photo in r_AlbumScanner.ScannedAlbum.Photos)
                {
                    r_AlbumPhotosImageList.Images.Add(photo.ImageNormal);
                    foreach(PhotoTag tag in photo.Tags)
                    {
                        MessageBox.Show(tag.User.Name);
                    }
                }
                for(int i = 0; i < r_AlbumPhotosImageList.Images.Count; i++)
                {
                    listviewAlbumPhotos.Items.Add("", i);
                }
            }
            else
            {
                MessageBox.Show("Please select an album to scan.");
            }
        }
    }
}
