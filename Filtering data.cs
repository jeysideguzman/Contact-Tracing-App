using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Contact_Tracing_App
{
    public partial class filterForm : Form
    {
        public filterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datafilepath = @"C:\Users\JOHN CARLO\OOP PROGRAMS\Contact Tracing App\bin\Debug\Collected Data from Users.txt";
            StreamReader stream = new StreamReader(datafilepath);
            string data = stream.ReadToEnd();
            RTBlistofinfo.Text = data.ToString();
            stream.Close();

        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void filterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet3.dataaa' table. You can move, or remove it, as needed.
            this.dataaaTableAdapter.Fill(this.database2DataSet3.dataaa);
            // TODO: This line of code loads data into the 'database2DataSet2.dataaa' table. You can move, or remove it, as needed.



        }



        private void loadbtn_Click(object sender, EventArgs e)
        {
            filter();

        }

        void filter()
        {
            if (ComboBoxFilter.SelectedItem.ToString().Contains("20/06/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("20/06/2022", "jcdeguzman1218@gmail.com", "John Carlo Barrientes De Guzman", "19", "Dec. 18, 2002", "Lapnit San Ildefonso Bulacan");
                dt.Rows.Add("20/06/2022", "jpubaldo19@gmail.com", "John Paulo Ubaldo De Guzman", "19", "Aug. 04, 2002", "Lapnit San Ildefonso Bulacan");

                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("21/06/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("21/06/2022", "jkbarrientes@gmail.com", "John Kurt Cruz Barrientes", "19", "Oct. 12, 2002", "Lapnit San Ildefonso Bulacan");

                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("22/06/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("22/06/2022", "joeydg@gmail.com", "Joey Cruz De Guzman", "20", "Jan. 24, 2002", "San Juan San Ildefonso Bulacan");

                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("23/06/2022"))
                {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("23/06/2022", "jamesbarrientes@gmail.com", "James Liwag Barrientes", "20", "March 24, 2002", "Calawitan San Ildefonso Bulacan");
                dt.Rows.Add("23/06/2022", "pauldelacruz@gmail.com", "Paul Liwag Dela Cruz", "19", "Dec. 08, 2002", "Malipampang San Ildefonso Bulacan");

                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("24/06/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("24/06/2022", "johnbarrientes@gmail.com", "John Cruz Barrientes", "19", "Nov. 18, 2002", "San Juan San Ildefonso Bulacan");
                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("25/06/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("26/06/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));

                dt.Rows.Add("26/06/2022", "JCDEGUZMAN@GMAIL.COM", "JOHN CRUZ GUZMAN", "19", "OCT, 1, 2002", "CALASAG SAN ILDEFONSO BULCAN");
                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("27/06/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("28/06/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("29/06/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("30/06/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("01/07/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("02/07/2022"))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("DateLogin", Type.GetType("System.DateTime"));
                dt.Columns.Add("Email", Type.GetType("System.String"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Age", Type.GetType("System.Int32"));
                dt.Columns.Add("Birthday", Type.GetType("System.String"));
                dt.Columns.Add("Address", Type.GetType("System.String"));
                dt.Rows.Add("02/07/2022", "jcdeguzman1218@gmail.com", "John Carlo Barrientes De Guzman", "19", "Dec. 18, 2002", "Lapnit San Ildefonso Bulacan");
                dataGridView2.DataSource = dt;
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("03/07/2022"))
            {
                MessageBox.Show("No Information");
            }
            if (ComboBoxFilter.SelectedItem.ToString().Contains("04/07/2022"))
            {
                MessageBox.Show("No Information");
            }
        }
    }
}
