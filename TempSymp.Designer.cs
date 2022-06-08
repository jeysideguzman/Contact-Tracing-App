namespace Contact_Tracing_App
{
    partial class tempsympForm
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
            this.Submit = new System.Windows.Forms.Button();
            this.FinalQNo = new System.Windows.Forms.RadioButton();
            this.FinalQYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Submit.Location = new System.Drawing.Point(444, 297);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 31);
            this.Submit.TabIndex = 88;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // FinalQNo
            // 
            this.FinalQNo.AutoSize = true;
            this.FinalQNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalQNo.Location = new System.Drawing.Point(154, 217);
            this.FinalQNo.Name = "FinalQNo";
            this.FinalQNo.Size = new System.Drawing.Size(47, 23);
            this.FinalQNo.TabIndex = 87;
            this.FinalQNo.TabStop = true;
            this.FinalQNo.Text = "No";
            this.FinalQNo.UseVisualStyleBackColor = true;
            // 
            // FinalQYes
            // 
            this.FinalQYes.AutoSize = true;
            this.FinalQYes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalQYes.Location = new System.Drawing.Point(107, 217);
            this.FinalQYes.Name = "FinalQYes";
            this.FinalQYes.Size = new System.Drawing.Size(49, 23);
            this.FinalQYes.TabIndex = 86;
            this.FinalQYes.TabStop = true;
            this.FinalQYes.Text = "Yes";
            this.FinalQYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 85;
            this.label1.Text = "Have you had any close contact with a \r\nCOVID positive person?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(323, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 84;
            this.label15.Text = "Symptoms:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Fever",
            "Tiredness",
            "Chills ",
            "Cough",
            "Headache",
            "Sore throat",
            "Chest pain",
            "Loss of taste/smell",
            "Difficulty in breathing",
            "None"});
            this.checkedListBox2.Location = new System.Drawing.Point(327, 80);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(169, 210);
            this.checkedListBox2.TabIndex = 83;
            this.checkedListBox2.Tag = "";
            // 
            // temp
            // 
            this.temp.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(98, 67);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(84, 20);
            this.temp.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 19);
            this.label14.TabIndex = 81;
            this.label14.Text = "Enter your Temperature:";
            // 
            // tempsympForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 372);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FinalQNo);
            this.Controls.Add(this.FinalQYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label14);
            this.Name = "tempsympForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature and Symptoms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton FinalQNo;
        private System.Windows.Forms.RadioButton FinalQYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Label label14;
    }
}