using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Ex03.Services;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    public partial class AlbumScannerForm : Form, IFeatureFrom
    {
        private readonly AlbumScanner r_AlbumScanner;
        private readonly ImageList imageListAlbumPhoto = new ImageList();
        private int m_NumberOfPhotosToLike = 0;

        public FacebookFeature FacebookFeature
        {
            get
            {
                return r_AlbumScanner;
            }
        }

        public AlbumScannerForm(UserFacade i_User)
        {
            InitializeComponent();
            r_AlbumScanner = new AlbumScanner(i_User);
            ((IFeatureFrom)this).InitFeatureForm();
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
            ((IFeatureFrom)this).ExecuteFeature();
        }

        private void showAlbumPhotosByFilter(bool i_Filter, bool i_Reset)
        {
            if (r_AlbumScanner.ScannedAlbum != null)
            {
                listViewAlbumPhotos.Invoke(new Action(() => listViewAlbumPhotos.Items.Clear()));
                imageListAlbumPhoto.Images.Clear();
                List<PhotoProxy> photoList = (List<PhotoProxy>)r_AlbumScanner.FetchPhotosByFilter(i_Filter, createTaggedPersonList());
                addImagestoImageList(photoList);
                for (int i = 0; i < imageListAlbumPhoto.Images.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = photoList[i];
                    item.ImageIndex = i;
                    listViewAlbumPhotos.Invoke(new Action(() => listViewAlbumPhotos.Items.Add(item)));              
                }

                List<string> taggedPersonList = (List<string>)r_AlbumScanner.FetchTaggedPersonList(i_Filter);
                addTaggedFriendNameToCheckedListBox(taggedPersonList);
                bool enableScanButtons = imageListAlbumPhoto.Images.Count > 0;
                commandButtonTagFilter.Invoke(new Action(() => commandButtonTagFilter.Enabled = enableScanButtons));
                commandButtonResetFilter.Invoke(new Action(() => commandButtonResetFilter.Enabled = enableScanButtons));
                if (!i_Filter && !i_Reset)
                { 
                    r_SelectedPhotosList.Add(new CompositePhotoProxy());
                }
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
                    checkedListBoxTaggedFriends.Invoke(new Action(() => checkedListBoxTaggedFriends.Items.Add(taggedPersonName)));
                }
            }
        }

        private void buttonResetFilter_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBoxTaggedFriends.CheckedIndices)
            {
                checkedListBoxTaggedFriends.SetItemChecked(i, false);
            }

            new Thread(() => showAlbumPhotosByFilter(false, true)).Start();
        }

        private void buttonTagFilter_Click(object sender, EventArgs e)
        {
            new Thread(() => showAlbumPhotosByFilter(true, false)).Start();
        }

        private void fetchAlbums()
        {
            imageListAlbumPhoto.ImageSize = new Size(256, 256);
            listViewAlbumPhotos.View = View.Details;
            listViewAlbumPhotos.Columns.Add("Photo", 256);
            listViewAlbumPhotos.SmallImageList = imageListAlbumPhoto;
            foreach (Album album in r_AlbumScanner.Albums)
            {
                listBoxAlbumList.Invoke(new Action(() => listBoxAlbumList.Items.Add(album)));
            }

            listBoxAlbumList.Invoke(new Action(() => listBoxAlbumList.DisplayMember = "Name"));
        }
        
        private void addImagestoImageList(IList<PhotoProxy> i_PhotoList)
        {
            foreach (PhotoProxy photo in i_PhotoList)
            {
                imageListAlbumPhoto.Images.Add(photo.Photo.ImageNormal);
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

         void IFeatureFrom.InitFeatureForm()
        {
            listBoxAlbumList.Items.Clear();
            listViewAlbumPhotos.Items.Clear();
            commandButtonLikeSelectedPhotos.Command = new AlbumScanner.LikeSelectedPhotosCommand() { Client = (AlbumScanner)FacebookFeature };
            commandButtonLikeSelectedPhotos.CommandFinished += ((IFeatureFrom)this).ExecuteFeature;
            commandButtonExecuteBlast.Command = new BlastFromThePast.ExecuteBlastCommand() { Client = (BlastFromThePast)FacebookFeature };
            commandButtonExecuteBlast.CommandFinished += ((IFeatureFrom)this).ExecuteFeature;
            commandButtonExecuteBlast.Command = new BlastFromThePast.ExecuteBlastCommand() { Client = (BlastFromThePast)FacebookFeature };
            commandButtonExecuteBlast.CommandFinished += ((IFeatureFrom)this).ExecuteFeature;
            commandButtonExecuteBlast.Command = new BlastFromThePast.ExecuteBlastCommand() { Client = (BlastFromThePast)FacebookFeature };
            commandButtonExecuteBlast.CommandFinished += ((IFeatureFrom)this).ExecuteFeature;
            new Thread(fetchAlbums).Start();
        }

        void IFeatureFrom.ExecuteFeature()
        {
            checkedListBoxTaggedFriends.Items.Clear();
            r_AlbumScanner.ScannedAlbum = listBoxAlbumList.SelectedItem as Album;
            new Thread(() => showAlbumPhotosByFilter(false, false)).Start();
        }

        private void listViewAlbumPhotos_Click(object sender, EventArgs e)
        {
            selectPhoto(sender);
        }

        private void selectPhoto(object i_Sender)
        {
            IPhotoComponent photoProxy = (PhotoProxy)(i_Sender as ListView).SelectedItems[0].Tag;
            try
            {
                r_AlbumScanner.SelectedPhotosList[r_AlbumScanner.SelectedPhotosList.Count - 1].Add(photoProxy);
            }
            catch (NotImplementedException)
            {
                if (!photoProxy.Equals(r_AlbumScanner.SelectedPhotosList[r_AlbumScanner.SelectedPhotosList.Count - 1]))
                {
                    r_AlbumScanner.SelectedPhotosList[r_AlbumScanner.SelectedPhotosList.Count - 1] = photoProxy;
                }
                else
                {
                    r_AlbumScanner.SelectedPhotosList[r_AlbumScanner.SelectedPhotosList.Count - 1] = new PhotoProxy();
                }
            }

            m_NumberOfPhotosToLike = 0;
            foreach (IPhotoComponent photoComponent in r_AlbumScanner.SelectedPhotosList)
            {
                m_NumberOfPhotosToLike += photoComponent.GetChildren().Count;
            }

            labelNumberOfPhotosToLike.Text = m_NumberOfPhotosToLike.ToString();
            commandButtonLikeSelectedPhotos.Enabled = m_NumberOfPhotosToLike > 0;
        }

        private void buttonLikeSelectedPhotos_Click(object sender, EventArgs e)
        {
            new Thread(likeSelectedPhotos).Start();
        }

        private void likeSelectedPhotos()
        {
            try
            {
                {
                    MessageBox.Show(string.Format("Liking all selected photos - complete!!"));
                }
            }
            catch
            {
                MessageBox.Show(string.Format("Error - not all selected photos were liked :(."));
            }
        }
    }
}
