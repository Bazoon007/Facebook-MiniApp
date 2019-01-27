namespace Ex03.UI
{
    public partial class BlastFromThePastForm
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
            this.textBoxPostContent = new System.Windows.Forms.TextBox();
            this.comboBoxYearPicker = new System.Windows.Forms.ComboBox();
            this.groupBoxBlastType = new System.Windows.Forms.GroupBox();
            this.radioButtonMostLiked = new System.Windows.Forms.RadioButton();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPostDetails = new System.Windows.Forms.GroupBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.commandButtonExecuteBlast = new Ex03.UI.CommandButton();
            this.groupBoxBlastType.SuspendLayout();
            this.groupBoxPostDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPostContent
            // 
            this.textBoxPostContent.Location = new System.Drawing.Point(634, 532);
            this.textBoxPostContent.Multiline = true;
            this.textBoxPostContent.Name = "textBoxPostContent";
            this.textBoxPostContent.Size = new System.Drawing.Size(544, 26);
            this.textBoxPostContent.TabIndex = 4;
            this.textBoxPostContent.TextChanged += new System.EventHandler(this.textBoxPostContent_TextChanged);
            // 
            // comboBoxYearPicker
            // 
            this.comboBoxYearPicker.FormattingEnabled = true;
            this.comboBoxYearPicker.Location = new System.Drawing.Point(72, 111);
            this.comboBoxYearPicker.Name = "comboBoxYearPicker";
            this.comboBoxYearPicker.Size = new System.Drawing.Size(280, 28);
            this.comboBoxYearPicker.TabIndex = 6;
            this.comboBoxYearPicker.SelectedIndexChanged += new System.EventHandler(this.comboBoxYearPicker_SelectedIndexChanged);
            // 
            // groupBoxBlastType
            // 
            this.groupBoxBlastType.Controls.Add(this.radioButtonMostLiked);
            this.groupBoxBlastType.Controls.Add(this.radioButtonRandom);
            this.groupBoxBlastType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxBlastType.Location = new System.Drawing.Point(79, 177);
            this.groupBoxBlastType.Name = "groupBoxBlastType";
            this.groupBoxBlastType.Size = new System.Drawing.Size(200, 148);
            this.groupBoxBlastType.TabIndex = 7;
            this.groupBoxBlastType.TabStop = false;
            this.groupBoxBlastType.Text = "Blast Type";
            // 
            // radioButtonMostLiked
            // 
            this.radioButtonMostLiked.AutoSize = true;
            this.radioButtonMostLiked.Location = new System.Drawing.Point(6, 87);
            this.radioButtonMostLiked.Name = "radioButtonMostLiked";
            this.radioButtonMostLiked.Size = new System.Drawing.Size(155, 33);
            this.radioButtonMostLiked.TabIndex = 1;
            this.radioButtonMostLiked.TabStop = true;
            this.radioButtonMostLiked.Text = "Most Liked";
            this.radioButtonMostLiked.UseVisualStyleBackColor = true;
            this.radioButtonMostLiked.CheckedChanged += new System.EventHandler(this.radioButtonStrategy_CheckedChanged);
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(6, 44);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(129, 33);
            this.radioButtonRandom.TabIndex = 0;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonStrategy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Go back in time to...";
            // 
            // groupBoxPostDetails
            // 
            this.groupBoxPostDetails.Controls.Add(this.labelComments);
            this.groupBoxPostDetails.Controls.Add(this.labelLikes);
            this.groupBoxPostDetails.Controls.Add(this.labelDate);
            this.groupBoxPostDetails.Controls.Add(this.label5);
            this.groupBoxPostDetails.Controls.Add(this.label4);
            this.groupBoxPostDetails.Controls.Add(this.label3);
            this.groupBoxPostDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxPostDetails.Location = new System.Drawing.Point(79, 500);
            this.groupBoxPostDetails.Name = "groupBoxPostDetails";
            this.groupBoxPostDetails.Size = new System.Drawing.Size(476, 311);
            this.groupBoxPostDetails.TabIndex = 9;
            this.groupBoxPostDetails.TabStop = false;
            this.groupBoxPostDetails.Text = "Post Details";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(201, 196);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(0, 32);
            this.labelComments.TabIndex = 5;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(203, 133);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(0, 32);
            this.labelLikes.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(203, 67);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 32);
            this.labelDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comments -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Likes -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(627, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Post Message";
            // 
            // commandButtonExecuteBlast
            // 
            this.commandButtonExecuteBlast.Command = null;
            this.commandButtonExecuteBlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.commandButtonExecuteBlast.ForeColor = System.Drawing.Color.DarkGreen;
            this.commandButtonExecuteBlast.Location = new System.Drawing.Point(348, 205);
            this.commandButtonExecuteBlast.Name = "commandButtonExecuteBlast";
            this.commandButtonExecuteBlast.Size = new System.Drawing.Size(316, 92);
            this.commandButtonExecuteBlast.TabIndex = 11;
            this.commandButtonExecuteBlast.Text = "Blast yourself to the past!";
            this.commandButtonExecuteBlast.UseVisualStyleBackColor = true;
            // 
            // BlastFromThePastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1891, 1071);
            this.Controls.Add(this.commandButtonExecuteBlast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxPostDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBlastType);
            this.Controls.Add(this.comboBoxYearPicker);
            this.Controls.Add(this.textBoxPostContent);
            this.Name = "BlastFromThePastForm";
            this.Text = "Blast From The Past";
            this.groupBoxBlastType.ResumeLayout(false);
            this.groupBoxBlastType.PerformLayout();
            this.groupBoxPostDetails.ResumeLayout(false);
            this.groupBoxPostDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPostContent;
        private System.Windows.Forms.ComboBox comboBoxYearPicker;
        private System.Windows.Forms.GroupBox groupBoxBlastType;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonMostLiked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPostDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CommandButton commandButtonExecuteBlast;
    }
}