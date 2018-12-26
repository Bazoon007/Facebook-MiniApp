using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex01.Services;

namespace Ex01.UI
{
    public partial class BlastFromThePastForm : Form
    {
        private readonly BlastFromThePast r_BlastFromThePast; 

        public BlastFromThePastForm(UserFacade i_User)
        {
            InitializeComponent();
            r_BlastFromThePast = new BlastFromThePast(i_User);
            initBlastFromThePastForm();
        }

        private void initBlastFromThePastForm()
        {
            addYears();
        }

        private void buttonExecuteBlast_Click(object sender, EventArgs e)
        {
            executeBlast();
        }

        private void addYears()
        {
            ISet<int> yearSet = r_BlastFromThePast.CreateYearSet();
            foreach (int year in yearSet)
            {
                comboBoxYearPicker.Items.Add(year);
            }

            comboBoxYearPicker.SelectedIndex = 1;
        }

        private void executeBlast()
        {
            string blastType = getBlastType();
            int selectedYear = (int)comboBoxYearPicker.SelectedItem;
            Post selectedPost = null;
            if (!string.IsNullOrEmpty(blastType))
            {
                if (blastType == "Random")
                {
                    selectedPost = r_BlastFromThePast.RandomPost(selectedYear);
                }
                else if (blastType == "Most Liked")
                {
                    selectedPost = r_BlastFromThePast.MostLikedPost(selectedYear);
                }

                if (!string.IsNullOrEmpty(selectedPost.Message))
                {
                    textBoxPostContent.Text = selectedPost.Message;
                }
                else
                {
                    textBoxPostContent.Text = "No Textual Content";
                }

                labelDate.Text = selectedPost.CreatedTime.ToString();
                labelLikes.Text = selectedPost.LikedBy.Count.ToString();
                labelComments.Text = selectedPost.Comments.Count.ToString(); 
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
    }
}
