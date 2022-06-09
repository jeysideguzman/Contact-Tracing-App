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
            this.temp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Fever = new System.Windows.Forms.CheckBox();
            this.Tiredness = new System.Windows.Forms.CheckBox();
            this.Chills = new System.Windows.Forms.CheckBox();
            this.Sorethroat = new System.Windows.Forms.CheckBox();
            this.Headache = new System.Windows.Forms.CheckBox();
            this.Cough = new System.Windows.Forms.CheckBox();
            this.Lossofsmell = new System.Windows.Forms.CheckBox();
            this.Lossoftaste = new System.Windows.Forms.CheckBox();
            this.Chestpain = new System.Windows.Forms.CheckBox();
            this.None = new System.Windows.Forms.CheckBox();
            this.Difficultyinbreathing = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkBlue;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(422, 319);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 31);
            this.Submit.TabIndex = 88;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FinalQNo
            // 
            this.FinalQNo.AutoSize = true;
            this.FinalQNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalQNo.Location = new System.Drawing.Point(252, 314);
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
            this.FinalQYes.Location = new System.Drawing.Point(205, 314);
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
            this.label1.Location = new System.Drawing.Point(141, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 85;
            this.label1.Text = "Have you had any close contact with a \r\nCOVID-19 positive person?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(141, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(296, 19);
            this.label15.TabIndex = 84;
            this.label15.Text = "Do you experience any COVID-19 symptoms?";
            // 
            // temp
            // 
            this.temp.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(238, 42);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(84, 20);
            this.temp.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(208, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 19);
            this.label14.TabIndex = 81;
            this.label14.Text = "Enter your Temperature:";
            // 
            // Fever
            // 
            this.Fever.AutoSize = true;
            this.Fever.FlatAppearance.BorderSize = 0;
            this.Fever.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Fever.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fever.Location = new System.Drawing.Point(155, 110);
            this.Fever.Name = "Fever";
            this.Fever.Size = new System.Drawing.Size(53, 19);
            this.Fever.TabIndex = 89;
            this.Fever.Text = "Fever";
            this.Fever.UseVisualStyleBackColor = true;
            // 
            // Tiredness
            // 
            this.Tiredness.AutoSize = true;
            this.Tiredness.FlatAppearance.BorderSize = 0;
            this.Tiredness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Tiredness.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiredness.Location = new System.Drawing.Point(155, 135);
            this.Tiredness.Name = "Tiredness";
            this.Tiredness.Size = new System.Drawing.Size(73, 19);
            this.Tiredness.TabIndex = 90;
            this.Tiredness.Text = "Tiredness";
            this.Tiredness.UseVisualStyleBackColor = true;
            // 
            // Chills
            // 
            this.Chills.AutoSize = true;
            this.Chills.FlatAppearance.BorderSize = 0;
            this.Chills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chills.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chills.Location = new System.Drawing.Point(155, 160);
            this.Chills.Name = "Chills";
            this.Chills.Size = new System.Drawing.Size(54, 19);
            this.Chills.TabIndex = 91;
            this.Chills.Text = "Chills";
            this.Chills.UseVisualStyleBackColor = true;
            // 
            // Sorethroat
            // 
            this.Sorethroat.AutoSize = true;
            this.Sorethroat.FlatAppearance.BorderSize = 0;
            this.Sorethroat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Sorethroat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sorethroat.Location = new System.Drawing.Point(307, 110);
            this.Sorethroat.Name = "Sorethroat";
            this.Sorethroat.Size = new System.Drawing.Size(79, 19);
            this.Sorethroat.TabIndex = 94;
            this.Sorethroat.Text = "Sore throat";
            this.Sorethroat.UseVisualStyleBackColor = true;
            // 
            // Headache
            // 
            this.Headache.AutoSize = true;
            this.Headache.FlatAppearance.BorderSize = 0;
            this.Headache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Headache.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headache.Location = new System.Drawing.Point(155, 210);
            this.Headache.Name = "Headache";
            this.Headache.Size = new System.Drawing.Size(72, 19);
            this.Headache.TabIndex = 93;
            this.Headache.Text = "Headache";
            this.Headache.UseVisualStyleBackColor = true;
            // 
            // Cough
            // 
            this.Cough.AutoSize = true;
            this.Cough.FlatAppearance.BorderSize = 0;
            this.Cough.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cough.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cough.Location = new System.Drawing.Point(155, 185);
            this.Cough.Name = "Cough";
            this.Cough.Size = new System.Drawing.Size(57, 19);
            this.Cough.TabIndex = 92;
            this.Cough.Text = "Cough";
            this.Cough.UseVisualStyleBackColor = true;
            // 
            // Lossofsmell
            // 
            this.Lossofsmell.AutoSize = true;
            this.Lossofsmell.FlatAppearance.BorderSize = 0;
            this.Lossofsmell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lossofsmell.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lossofsmell.Location = new System.Drawing.Point(307, 185);
            this.Lossofsmell.Name = "Lossofsmell";
            this.Lossofsmell.Size = new System.Drawing.Size(90, 19);
            this.Lossofsmell.TabIndex = 97;
            this.Lossofsmell.Text = "Loss of smell";
            this.Lossofsmell.UseVisualStyleBackColor = true;
            // 
            // Lossoftaste
            // 
            this.Lossoftaste.AutoSize = true;
            this.Lossoftaste.FlatAppearance.BorderSize = 0;
            this.Lossoftaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lossoftaste.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lossoftaste.Location = new System.Drawing.Point(307, 160);
            this.Lossoftaste.Name = "Lossoftaste";
            this.Lossoftaste.Size = new System.Drawing.Size(88, 19);
            this.Lossoftaste.TabIndex = 96;
            this.Lossoftaste.Text = "Loss of taste";
            this.Lossoftaste.UseVisualStyleBackColor = true;
            // 
            // Chestpain
            // 
            this.Chestpain.AutoSize = true;
            this.Chestpain.FlatAppearance.BorderSize = 0;
            this.Chestpain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chestpain.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chestpain.Location = new System.Drawing.Point(307, 135);
            this.Chestpain.Name = "Chestpain";
            this.Chestpain.Size = new System.Drawing.Size(78, 19);
            this.Chestpain.TabIndex = 95;
            this.Chestpain.Text = "Chest pain";
            this.Chestpain.UseVisualStyleBackColor = true;
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.FlatAppearance.BorderSize = 0;
            this.None.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.None.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.Location = new System.Drawing.Point(245, 236);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(52, 19);
            this.None.TabIndex = 98;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            // 
            // Difficultyinbreathing
            // 
            this.Difficultyinbreathing.AutoSize = true;
            this.Difficultyinbreathing.FlatAppearance.BorderSize = 0;
            this.Difficultyinbreathing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Difficultyinbreathing.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficultyinbreathing.Location = new System.Drawing.Point(307, 210);
            this.Difficultyinbreathing.Name = "Difficultyinbreathing";
            this.Difficultyinbreathing.Size = new System.Drawing.Size(133, 19);
            this.Difficultyinbreathing.TabIndex = 99;
            this.Difficultyinbreathing.Text = "Difficulty in breathing";
            this.Difficultyinbreathing.UseVisualStyleBackColor = true;
            // 
            // tempsympForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 372);
            this.Controls.Add(this.Difficultyinbreathing);
            this.Controls.Add(this.None);
            this.Controls.Add(this.Lossofsmell);
            this.Controls.Add(this.Lossoftaste);
            this.Controls.Add(this.Chestpain);
            this.Controls.Add(this.Sorethroat);
            this.Controls.Add(this.Headache);
            this.Controls.Add(this.Cough);
            this.Controls.Add(this.Chills);
            this.Controls.Add(this.Tiredness);
            this.Controls.Add(this.Fever);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FinalQNo);
            this.Controls.Add(this.FinalQYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label14);
            this.Name = "tempsympForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature and Symptoms";
            this.Load += new System.EventHandler(this.tempsympForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton FinalQNo;
        private System.Windows.Forms.RadioButton FinalQYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox Fever;
        private System.Windows.Forms.CheckBox Tiredness;
        private System.Windows.Forms.CheckBox Chills;
        private System.Windows.Forms.CheckBox Sorethroat;
        private System.Windows.Forms.CheckBox Headache;
        private System.Windows.Forms.CheckBox Cough;
        private System.Windows.Forms.CheckBox Lossofsmell;
        private System.Windows.Forms.CheckBox Lossoftaste;
        private System.Windows.Forms.CheckBox Chestpain;
        private System.Windows.Forms.CheckBox None;
        private System.Windows.Forms.CheckBox Difficultyinbreathing;
    }
}