using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class basicinfoForm : Form
    {
        public basicinfoForm()
        {
            InitializeComponent();
        }

        private void Nextbtn1_Click(object sender, EventArgs e)
        {
            StreamWriter CollectingUsersInfo;

            CollectingUsersInfo = File.AppendText("Gathered Data from Users");
            CollectingUsersInfo.WriteLine("Name: " + firstname.Text + ' ' + middlename.Text + ' ' + lastname.Text);
            CollectingUsersInfo.WriteLine("Age: " + Age.Text);
            CollectingUsersInfo.WriteLine("Birthday: " + bday.Text);
            CollectingUsersInfo.WriteLine("Address: " + brgy.Text + ' ' + city.Text + ' ' + provine.Text);
            CollectingUsersInfo.Close();

            QStatusForm form = new QStatusForm();
            form.ShowDialog();
        }
    }
}
