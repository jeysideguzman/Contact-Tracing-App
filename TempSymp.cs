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
    public partial class tempsympForm : Form
    {
        public tempsympForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter CollectingUsersInfo;

            CollectingUsersInfo = File.AppendText("Gathered Data from Users");
            CollectingUsersInfo.WriteLine("Temperature: " + temp.Text);
            CollectingUsersInfo.WriteLine("Symptoms: ");

            //SYMPTOMS
            if (Fever.Checked)
                CollectingUsersInfo.WriteLine("Fever");
            if (Tiredness.Checked)
                CollectingUsersInfo.WriteLine("Tiredness");
            if (Chills.Checked)
                CollectingUsersInfo.WriteLine("Chills");
            if (Cough.Checked)
                CollectingUsersInfo.WriteLine("Cough");
            if (Headache.Checked)
                CollectingUsersInfo.WriteLine("Headache.Checked");
            if (Sorethroat.Checked)
                CollectingUsersInfo.WriteLine("Sorethroat");
            if (Lossoftaste.Checked)
                CollectingUsersInfo.WriteLine("Loss of taste");
            if (Lossofsmell.Checked)
                CollectingUsersInfo.WriteLine("Loss of smell");
            if (Difficultyinbreathing.Checked)
                CollectingUsersInfo.WriteLine("Difficulty in breathing");
            if (None.Checked)
                CollectingUsersInfo.WriteLine("None");

            // last questionF4
            if (FinalQYes.Checked)
                CollectingUsersInfo.WriteLine("Had close contact with a COVID-19 positive person: Yes ");
            else
                CollectingUsersInfo.WriteLine("Had close contact with a COVID-19 positive person: No ");

            CollectingUsersInfo.Close();

            
            
        }

        private void tempsympForm_Load(object sender, EventArgs e)
        {

        }
    }
}
