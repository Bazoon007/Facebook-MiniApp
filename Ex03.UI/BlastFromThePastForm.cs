using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using Ex03.Services;

namespace Ex03.UI
{
    public partial class BlastFromThePastForm : Form, IFeatureFrom
    {
        private readonly BlastFromThePast r_BlastFromThePast;

        public FacebookFeature FacebookFeature
        {
            get
            {
                return r_BlastFromThePast;
            }
        }

        public BlastFromThePastForm(UserFacade i_User)
        {
            InitializeComponent();
            r_BlastFromThePast = new BlastFromThePast(i_User);
            ((IFeatureFrom)this).InitFeatureForm();
        }

        private void buttonExecuteBlast_Click(object sender, EventArgs e)
        {
            ((IFeatureFrom)this).ExecuteFeature();
        }

        private void addYears()
        {
            ISet<int> yearSet = r_BlastFromThePast.CreateYearSet();
            foreach (int year in yearSet)
            {
                comboBoxYearPicker.Invoke(new Action(() => comboBoxYearPicker.Items.Add(year)));
            }

            comboBoxYearPicker.Invoke(new Action(() => comboBoxYearPicker.SelectedIndex = 1));
        }

        private void executeBlast(int i_SelectedYear, string i_BlastType)
        {
            Post selectedPost = null;
            if (!string.IsNullOrEmpty(i_BlastType))
            {
                if (i_BlastType == "Random")
                {
                    selectedPost = r_BlastFromThePast.RandomPost(i_SelectedYear);
                }
                else if (i_BlastType == "Most Liked")
                {
                    selectedPost = r_BlastFromThePast.MostLikedPost(i_SelectedYear);
                }

                if (!string.IsNullOrEmpty(selectedPost.Message))
                {
                    textBoxPostContent.Invoke(new Action(() => textBoxPostContent.Text = selectedPost.Message));
                }
                else
                {
                    textBoxPostContent.Invoke(new Action(() => textBoxPostContent.Text = "No Textual Content"));
                }

                labelDate.Invoke(new Action(() => labelDate.Text = selectedPost.CreatedTime.ToString()));
                labelLikes.Invoke(new Action(() => labelLikes.Text = selectedPost.LikedBy.Count.ToString()));
                labelComments.Invoke(new Action(() => labelComments.Text = selectedPost.Comments.Count.ToString())); 
            }
            else
            {
                MessageBox.Show("Please select a blast type and year");
            }
        }

        private string getBlastType()
        {
            string blastType = string.Empty;
            foreach (RadioButton radioButton in groupBoxBlastType.Controls)
            {
                if (radioButton.Checked)
                {
                    blastType = radioButton.Text;
                    break;
                }
            }

            return blastType;
        }

        private void textBoxPostContent_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(textBoxPostContent.Text, textBoxPostContent.Font);
            textBoxPostContent.Width = size.Width;
            textBoxPostContent.Height = size.Height * 2;
        }

        void IFeatureFrom.InitFeatureForm()
        {
            new Thread(addYears).Start();
        }

        void IFeatureFrom.ExecuteFeature()
        {
            int selectedYear = (int)comboBoxYearPicker.SelectedItem;
            string blastType = getBlastType();
            new Thread(() => executeBlast(selectedYear, blastType)).Start();
        }
    }
}
