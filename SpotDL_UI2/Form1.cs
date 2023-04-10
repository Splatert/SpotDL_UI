using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotDL_UI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.tbURL;
        }

        private void tbDownload_Click(object sender, EventArgs e)
        {

            string URL = this.tbURL.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"spotdl.exe";
            startInfo.Arguments = "download " + URL;

            Process.Start(startInfo);

            this.tbURL.Clear();


        }
    }
}
