namespace Contact_Tracing_App
{
    partial class qrcodeform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qrcodeform));
            this.scanbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewinfobtn = new System.Windows.Forms.Button();
            this.exitbtn2 = new System.Windows.Forms.Button();
            this.scanrtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scanbtn
            // 
            this.scanbtn.BackColor = System.Drawing.Color.DimGray;
            this.scanbtn.ForeColor = System.Drawing.Color.White;
            this.scanbtn.Location = new System.Drawing.Point(483, 84);
            this.scanbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanbtn.Name = "scanbtn";
            this.scanbtn.Size = new System.Drawing.Size(78, 33);
            this.scanbtn.TabIndex = 0;
            this.scanbtn.Text = "Scan";
            this.scanbtn.UseVisualStyleBackColor = false;
            this.scanbtn.Click += new System.EventHandler(this.scanbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewinfobtn
            // 
            this.viewinfobtn.BackColor = System.Drawing.Color.Black;
            this.viewinfobtn.ForeColor = System.Drawing.Color.White;
            this.viewinfobtn.Location = new System.Drawing.Point(598, 329);
            this.viewinfobtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewinfobtn.Name = "viewinfobtn";
            this.viewinfobtn.Size = new System.Drawing.Size(88, 33);
            this.viewinfobtn.TabIndex = 5;
            this.viewinfobtn.Text = "View Info";
            this.viewinfobtn.UseVisualStyleBackColor = false;
            this.viewinfobtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbtn2
            // 
            this.exitbtn2.BackColor = System.Drawing.Color.Black;
            this.exitbtn2.ForeColor = System.Drawing.Color.White;
            this.exitbtn2.Location = new System.Drawing.Point(700, 515);
            this.exitbtn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitbtn2.Name = "exitbtn2";
            this.exitbtn2.Size = new System.Drawing.Size(88, 33);
            this.exitbtn2.TabIndex = 6;
            this.exitbtn2.Text = "Exit";
            this.exitbtn2.UseVisualStyleBackColor = false;
            this.exitbtn2.Click += new System.EventHandler(this.exitbtn2_Click);
            // 
            // scanrtb
            // 
            this.scanrtb.Location = new System.Drawing.Point(483, 125);
            this.scanrtb.Name = "scanrtb";
            this.scanrtb.Size = new System.Drawing.Size(305, 185);
            this.scanrtb.TabIndex = 7;
            this.scanrtb.Text = "";
            // 
            // qrcodeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 572);
            this.Controls.Add(this.scanrtb);
            this.Controls.Add(this.exitbtn2);
            this.Controls.Add(this.viewinfobtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.scanbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "qrcodeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qrcodeform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qrcodeform_FormClosing);
            this.Load += new System.EventHandler(this.qrcodeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button viewinfobtn;
        private System.Windows.Forms.Button exitbtn2;
        private System.Windows.Forms.RichTextBox scanrtb;
    }
}