namespace Contact_Tracing_App
{
    partial class filterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filterForm));
            this.button1 = new System.Windows.Forms.Button();
            this.RTBlistofinfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.dataaaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet3 = new Contact_Tracing_App.Database2DataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.loadbtn = new System.Windows.Forms.Button();
            this.dataaaTableAdapter = new Contact_Tracing_App.Database2DataSet3TableAdapters.dataaaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CV20 = new System.Windows.Forms.CheckBox();
            this.CV21 = new System.Windows.Forms.CheckBox();
            this.CV23 = new System.Windows.Forms.CheckBox();
            this.CV22 = new System.Windows.Forms.CheckBox();
            this.CV24 = new System.Windows.Forms.CheckBox();
            this.CV25 = new System.Windows.Forms.CheckBox();
            this.CV26 = new System.Windows.Forms.CheckBox();
            this.CV27 = new System.Windows.Forms.CheckBox();
            this.CV28 = new System.Windows.Forms.CheckBox();
            this.cv4 = new System.Windows.Forms.CheckBox();
            this.cv3 = new System.Windows.Forms.CheckBox();
            this.cv2 = new System.Windows.Forms.CheckBox();
            this.cv1 = new System.Windows.Forms.CheckBox();
            this.cv30 = new System.Windows.Forms.CheckBox();
            this.cv29 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataaaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBlistofinfo
            // 
            this.RTBlistofinfo.Location = new System.Drawing.Point(64, 51);
            this.RTBlistofinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RTBlistofinfo.Name = "RTBlistofinfo";
            this.RTBlistofinfo.Size = new System.Drawing.Size(660, 204);
            this.RTBlistofinfo.TabIndex = 2;
            this.RTBlistofinfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Gathered Information";
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.DarkBlue;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Location = new System.Drawing.Point(752, 513);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(73, 37);
            this.Exitbtn.TabIndex = 88;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // dataaaBindingSource
            // 
            this.dataaaBindingSource.DataMember = "dataaa";
            this.dataaaBindingSource.DataSource = this.database2DataSet3;
            // 
            // database2DataSet3
            // 
            this.database2DataSet3.DataSetName = "Database2DataSet3";
            this.database2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 97;
            this.label4.Text = "Filter Information";
            // 
            // loadbtn
            // 
            this.loadbtn.BackColor = System.Drawing.Color.DarkBlue;
            this.loadbtn.ForeColor = System.Drawing.Color.White;
            this.loadbtn.Location = new System.Drawing.Point(361, 271);
            this.loadbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(85, 28);
            this.loadbtn.TabIndex = 98;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = false;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // dataaaTableAdapter
            // 
            this.dataaaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(64, 392);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(660, 124);
            this.dataGridView2.TabIndex = 99;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CV20
            // 
            this.CV20.AutoSize = true;
            this.CV20.BackColor = System.Drawing.Color.Transparent;
            this.CV20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV20.Location = new System.Drawing.Point(125, 310);
            this.CV20.Name = "CV20";
            this.CV20.Size = new System.Drawing.Size(90, 20);
            this.CV20.TabIndex = 101;
            this.CV20.Text = "20/06/2022";
            this.CV20.UseVisualStyleBackColor = false;
            // 
            // CV21
            // 
            this.CV21.AutoSize = true;
            this.CV21.BackColor = System.Drawing.Color.Transparent;
            this.CV21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV21.Location = new System.Drawing.Point(125, 336);
            this.CV21.Name = "CV21";
            this.CV21.Size = new System.Drawing.Size(90, 20);
            this.CV21.TabIndex = 105;
            this.CV21.Text = "21/06/2022";
            this.CV21.UseVisualStyleBackColor = false;
            // 
            // CV23
            // 
            this.CV23.AutoSize = true;
            this.CV23.BackColor = System.Drawing.Color.Transparent;
            this.CV23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV23.Location = new System.Drawing.Point(236, 310);
            this.CV23.Name = "CV23";
            this.CV23.Size = new System.Drawing.Size(90, 20);
            this.CV23.TabIndex = 106;
            this.CV23.Text = "23/06/2022";
            this.CV23.UseVisualStyleBackColor = false;
            // 
            // CV22
            // 
            this.CV22.AutoSize = true;
            this.CV22.BackColor = System.Drawing.Color.Transparent;
            this.CV22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV22.Location = new System.Drawing.Point(125, 361);
            this.CV22.Name = "CV22";
            this.CV22.Size = new System.Drawing.Size(90, 20);
            this.CV22.TabIndex = 107;
            this.CV22.Text = "22/06/2022";
            this.CV22.UseVisualStyleBackColor = false;
            // 
            // CV24
            // 
            this.CV24.AutoSize = true;
            this.CV24.BackColor = System.Drawing.Color.Transparent;
            this.CV24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV24.Location = new System.Drawing.Point(236, 335);
            this.CV24.Name = "CV24";
            this.CV24.Size = new System.Drawing.Size(90, 20);
            this.CV24.TabIndex = 108;
            this.CV24.Text = "24/06/2022";
            this.CV24.UseVisualStyleBackColor = false;
            // 
            // CV25
            // 
            this.CV25.AutoSize = true;
            this.CV25.BackColor = System.Drawing.Color.Transparent;
            this.CV25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV25.Location = new System.Drawing.Point(236, 361);
            this.CV25.Name = "CV25";
            this.CV25.Size = new System.Drawing.Size(90, 20);
            this.CV25.TabIndex = 109;
            this.CV25.Text = "25/06/2022";
            this.CV25.UseVisualStyleBackColor = false;
            // 
            // CV26
            // 
            this.CV26.AutoSize = true;
            this.CV26.BackColor = System.Drawing.Color.Transparent;
            this.CV26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV26.Location = new System.Drawing.Point(347, 310);
            this.CV26.Name = "CV26";
            this.CV26.Size = new System.Drawing.Size(90, 20);
            this.CV26.TabIndex = 110;
            this.CV26.Text = "26/06/2022";
            this.CV26.UseVisualStyleBackColor = false;
            // 
            // CV27
            // 
            this.CV27.AutoSize = true;
            this.CV27.BackColor = System.Drawing.Color.Transparent;
            this.CV27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV27.Location = new System.Drawing.Point(347, 335);
            this.CV27.Name = "CV27";
            this.CV27.Size = new System.Drawing.Size(90, 20);
            this.CV27.TabIndex = 111;
            this.CV27.Text = "27/06/2022";
            this.CV27.UseVisualStyleBackColor = false;
            // 
            // CV28
            // 
            this.CV28.AutoSize = true;
            this.CV28.BackColor = System.Drawing.Color.Transparent;
            this.CV28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV28.Location = new System.Drawing.Point(347, 361);
            this.CV28.Name = "CV28";
            this.CV28.Size = new System.Drawing.Size(90, 20);
            this.CV28.TabIndex = 112;
            this.CV28.Text = "28/06/2022";
            this.CV28.UseVisualStyleBackColor = false;
            // 
            // cv4
            // 
            this.cv4.AutoSize = true;
            this.cv4.BackColor = System.Drawing.Color.Transparent;
            this.cv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv4.Location = new System.Drawing.Point(576, 361);
            this.cv4.Name = "cv4";
            this.cv4.Size = new System.Drawing.Size(90, 20);
            this.cv4.TabIndex = 118;
            this.cv4.Text = "04/07/2022";
            this.cv4.UseVisualStyleBackColor = false;
            // 
            // cv3
            // 
            this.cv3.AutoSize = true;
            this.cv3.BackColor = System.Drawing.Color.Transparent;
            this.cv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv3.Location = new System.Drawing.Point(576, 335);
            this.cv3.Name = "cv3";
            this.cv3.Size = new System.Drawing.Size(90, 20);
            this.cv3.TabIndex = 117;
            this.cv3.Text = "03/07/2022";
            this.cv3.UseVisualStyleBackColor = false;
            // 
            // cv2
            // 
            this.cv2.AutoSize = true;
            this.cv2.BackColor = System.Drawing.Color.Transparent;
            this.cv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv2.Location = new System.Drawing.Point(576, 310);
            this.cv2.Name = "cv2";
            this.cv2.Size = new System.Drawing.Size(90, 20);
            this.cv2.TabIndex = 116;
            this.cv2.Text = "02/07/2022";
            this.cv2.UseVisualStyleBackColor = false;
            // 
            // cv1
            // 
            this.cv1.AutoSize = true;
            this.cv1.BackColor = System.Drawing.Color.Transparent;
            this.cv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv1.Location = new System.Drawing.Point(465, 361);
            this.cv1.Name = "cv1";
            this.cv1.Size = new System.Drawing.Size(90, 20);
            this.cv1.TabIndex = 115;
            this.cv1.Text = "01/07/2022";
            this.cv1.UseVisualStyleBackColor = false;
            // 
            // cv30
            // 
            this.cv30.AutoSize = true;
            this.cv30.BackColor = System.Drawing.Color.Transparent;
            this.cv30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv30.Location = new System.Drawing.Point(465, 335);
            this.cv30.Name = "cv30";
            this.cv30.Size = new System.Drawing.Size(90, 20);
            this.cv30.TabIndex = 114;
            this.cv30.Text = "30/06/2022";
            this.cv30.UseVisualStyleBackColor = false;
            // 
            // cv29
            // 
            this.cv29.AutoSize = true;
            this.cv29.BackColor = System.Drawing.Color.Transparent;
            this.cv29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cv29.Location = new System.Drawing.Point(465, 310);
            this.cv29.Name = "cv29";
            this.cv29.Size = new System.Drawing.Size(90, 20);
            this.cv29.TabIndex = 113;
            this.cv29.Text = "29/06/2022";
            this.cv29.UseVisualStyleBackColor = false;
            // 
            // filterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 572);
            this.Controls.Add(this.cv4);
            this.Controls.Add(this.cv3);
            this.Controls.Add(this.cv2);
            this.Controls.Add(this.cv1);
            this.Controls.Add(this.cv30);
            this.Controls.Add(this.cv29);
            this.Controls.Add(this.CV28);
            this.Controls.Add(this.CV27);
            this.Controls.Add(this.CV26);
            this.Controls.Add(this.CV25);
            this.Controls.Add(this.CV24);
            this.Controls.Add(this.CV22);
            this.Controls.Add(this.CV23);
            this.Controls.Add(this.CV21);
            this.Controls.Add(this.CV20);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBlistofinfo);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "filterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtering Collected Info";
            this.Load += new System.EventHandler(this.filterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataaaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RTBlistofinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadbtn;
        private Database2DataSet3 database2DataSet3;
        private System.Windows.Forms.BindingSource dataaaBindingSource;
        private Database2DataSet3TableAdapters.dataaaTableAdapter dataaaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox CV20;
        private System.Windows.Forms.CheckBox CV21;
        private System.Windows.Forms.CheckBox CV23;
        private System.Windows.Forms.CheckBox CV22;
        private System.Windows.Forms.CheckBox CV24;
        private System.Windows.Forms.CheckBox CV25;
        private System.Windows.Forms.CheckBox CV26;
        private System.Windows.Forms.CheckBox CV27;
        private System.Windows.Forms.CheckBox CV28;
        private System.Windows.Forms.CheckBox cv4;
        private System.Windows.Forms.CheckBox cv3;
        private System.Windows.Forms.CheckBox cv2;
        private System.Windows.Forms.CheckBox cv1;
        private System.Windows.Forms.CheckBox cv30;
        private System.Windows.Forms.CheckBox cv29;
    }
}