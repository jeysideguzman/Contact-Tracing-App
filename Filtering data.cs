﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader sr = new StreamReader(@"C: \Users\JOHN CARLO\OOP PROGRAMS\Contact Tracing App\bin\Debug");

        private void button1_Click(object sender, EventArgs e)
        {
            string datafilepath = @"C:\Users\JOHN CARLO\OOP PROGRAMS\Contact Tracing App\bin\Debug\Gathered Data from Users.txt";
            StreamReader stream = new StreamReader(datafilepath);
            string data = stream.ReadToEnd();
            richTextBox1.Text = data.ToString();
            stream.Close();
        }
    }
}