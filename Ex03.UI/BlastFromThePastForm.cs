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
        private int m_SelectedYear;
        private string m_BlastType;
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
            comboBoxYearPicker.Invoke(new Action(() => m_SelectedYear = (int)comboBoxYearPicker.SelectedItem));
        }

        private void displayPost()
        {
            Post postResult = r_BlastFromThePast.PostResult;
            if (postResult != null)
            {
                if (!string.IsNullOrEmpty(postResult.Message))
                {
                    textBoxPostContent.Invoke(new Action(() => textBoxPostContent.Text = postResult.Message));
                }
                else
                {
                    textBoxPostContent.Invoke(new Action(() => textBoxPostContent.Text = "No Textual Content"));
                }

                labelDate.Invoke(new Action(() => labelDate.Text = postResult.CreatedTime.ToString()));
                labelLikes.Invoke(new Action(() => labelLikes.Text = postResult.LikedBy.Count.ToString()));
                labelComments.Invoke(new Action(() => labelComments.Text = postResult.Comments.Count.ToString())); 
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
            commandButtonExecuteBlast.Command = new BlastFromThePast.ExecuteBlastCommand() { Client = (BlastFromThePast)FacebookFeature };
            commandButtonExecuteBlast.CommandFinished += ((IFeatureFrom)this).ExecuteFeature;
            new Thread(addYears).Start();
        }

        void IFeatureFrom.ExecuteFeature()
        {
            new Thread(displayPost).Start();
        }

        private void comboBoxYearPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedYear = (int)comboBoxYearPicker.SelectedItem;
            updateExecuteBlastCommand();
        }

        private void updateExecuteBlastCommand()
        {
            ((BlastFromThePast.ExecuteBlastCommand)commandButtonExecuteBlast.Command).Year = m_SelectedYear;
            ((BlastFromThePast.ExecuteBlastCommand)commandButtonExecuteBlast.Command).BlastType = m_BlastType;
        }

        private void radioButtonStrategy_CheckedChanged(object sender, EventArgs e)
        {
            m_BlastType = getBlastType();
            updateExecuteBlastCommand();
        }
    }
}
