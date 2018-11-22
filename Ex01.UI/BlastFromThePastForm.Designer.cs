namespace Ex01.UI
{
    partial class BlastFromThePastForm
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
            this.buttonExecuteBlast = new System.Windows.Forms.Button();
            this.textBoxPostContent = new System.Windows.Forms.TextBox();
            this.comboBoxYearPicker = new System.Windows.Forms.ComboBox();
            this.groupBoxBlastType = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxBlastType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecuteBlast
            // 
            this.buttonExecuteBlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExecuteBlast.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonExecuteBlast.Location = new System.Drawing.Point(345, 111);
            this.buttonExecuteBlast.Name = "buttonExecuteBlast";
            this.buttonExecuteBlast.Size = new System.Drawing.Size(316, 92);
            this.buttonExecuteBlast.TabIndex = 3;
            this.buttonExecuteBlast.Text = "Blast yourself to the past!";
            this.buttonExecuteBlast.UseVisualStyleBackColor = true;
            this.buttonExecuteBlast.Click += new System.EventHandler(this.buttonExecuteBlast_Click);
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
            this.comboBoxYearPicker.Size = new System.Drawing.Size(121, 28);
            this.comboBoxYearPicker.TabIndex = 6;
            // 
            // groupBoxBlastType
            // 
            this.groupBoxBlastType.Controls.Add(this.radioButton2);
            this.groupBoxBlastType.Controls.Add(this.radioButton1);
            this.groupBoxBlastType.Location = new System.Drawing.Point(72, 191);
            this.groupBoxBlastType.Name = "groupBoxBlastType";
            this.groupBoxBlastType.Size = new System.Drawing.Size(200, 148);
            this.groupBoxBlastType.TabIndex = 7;
            this.groupBoxBlastType.TabStop = false;
            this.groupBoxBlastType.Text = "Blast Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Random";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Most Liked";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // BlastFromThePastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1891, 1071);
            this.Controls.Add(this.groupBoxBlastType);
            this.Controls.Add(this.comboBoxYearPicker);
            this.Controls.Add(this.textBoxPostContent);
            this.Controls.Add(this.buttonExecuteBlast);
            this.Name = "BlastFromThePastForm";
            this.Text = "Blast From The Past";
            this.groupBoxBlastType.ResumeLayout(false);
            this.groupBoxBlastType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExecuteBlast;
        private System.Windows.Forms.TextBox textBoxPostContent;
        private System.Windows.Forms.ComboBox comboBoxYearPicker;
        private System.Windows.Forms.GroupBox groupBoxBlastType;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}