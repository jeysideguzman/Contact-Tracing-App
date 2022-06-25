using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

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
        
        string connectionString = @"OneDrive - Polytechnic University of the Philippines";
       
        public class filterrr
        {
            public DateTime Date { get; set; }
            public string Email { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Bday { get; set; }
            public string Address { get; set; }
            
        }
        private void loadbtn_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                
 
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dataaa", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                string query = "select o.Date, c.Email, c.Name, c.Age, c.Bday, o.Address" + 
                    "from dataaa o inner join Emails c on o.Email" +
                    $" where o.Date between '{fromdate.Value}' and '{todate.Value}'";
                dataaaBindingSource.DataSource = connection.Query<dataaa>(query, CommandType: CommandType.Text);
 
            }
        }

        private void filterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet1.dataaa' table. You can move, or remove it, as needed.
            this.dataaaTableAdapter1.Fill(this.database2DataSet1.dataaa);


        }
    }
}
