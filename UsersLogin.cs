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
    public partial class usersloginForm : Form
    {
        public usersloginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter CollectingUsersInfo;

            CollectingUsersInfo = File.AppendText("Gathered Data from Users");
            CollectingUsersInfo.WriteLine("Email Address: " + Email.Text);
            CollectingUsersInfo.Close();

            basicinfoForm form = new basicinfoForm();
            form.ShowDialog();
        }
    }
}
