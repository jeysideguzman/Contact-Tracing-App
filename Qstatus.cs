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
    public partial class QStatusForm : Form
    {
        public QStatusForm()
        {
            InitializeComponent();
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            StreamWriter CollectingUsersInfo;

            CollectingUsersInfo = File.AppendText("Gathered Data from Users");
            //question#1F3
            if (Q1RBYes.Checked)
            {
                CollectingUsersInfo.WriteLine("Strict Quarantine: Yes");
            }
            else
            {
                CollectingUsersInfo.WriteLine("Strict Quarantine: No");
            }
            //question#2F3
            if (Q2RBYes.Checked)
            {
                CollectingUsersInfo.WriteLine("Rapid Testing: Yes");
            }
            else
            {
                CollectingUsersInfo.WriteLine("Rapid Testing: No");
            }
            //question#3F3
            if (Q3RBYes.Checked)
            {
                CollectingUsersInfo.WriteLine("Swab Testing: Yes");
            }
            else
            {
                CollectingUsersInfo.WriteLine("Swab Testing: No");
            }
            CollectingUsersInfo.Close();

            tempsympForm form = new tempsympForm();
            form.ShowDialog();
        }
    }
}
