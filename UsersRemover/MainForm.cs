using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UsersRemover
{
 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnPath_Click(object sender, EventArgs e)
        {   
            // Opens the folder browser.
            FolderBrowserDialog location = new FolderBrowserDialog();
            location.ShowNewFolderButton = true;
            DialogResult result = location.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblSelectedPath.Text = location.SelectedPath;
            }

        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            // Starts the timer 
            startTimer.Start();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerProgress.Minimum = 0;
                TimerProgress.Maximum = 100;

                // Gets the folder path from the label and deletes all files in it.
                string path = lblSelectedPath.Text;
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    File.Delete(file);
                    TimerProgress.Value = 0;
                    TimerProgress.Value = 100;
                }
            }   
            catch
            {
                // Message on label if no path is found.
                lblSelectedPath.Text = "Select the folder location";
            }           
        }

        private void bntTimerStop_Click(object sender, EventArgs e)
        {
            startTimer.Stop();
            lblSelectedPath.Text = "";
            TimerProgress.Value = 0;
        }
    }
}
