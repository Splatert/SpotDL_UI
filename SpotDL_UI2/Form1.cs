using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SpotDL_UI2
{

    public partial class Form1 : Form
    {


        public class Vars
        {
            public static bool cb_retrieve = false; // allow app to take URLS from clipboard
            public static string cb_CurrentUrl = ""; // placeholder for URL taken from clipboard.
        }


        public void sendQueryToSpotdl(string MyURL, bool minimized)
        {
            string URL = MyURL;

            bool IsAPhrase = URL.Contains(" ");
            if (IsAPhrase)
            {
                URL = "\"" + URL + "\"";
            }


            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"spotdl.exe";
            startInfo.Arguments = "download " + URL;
            
            if (minimized)
            {
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                var downloadNotify = new NotifyIcon()
                {
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Information,
                    BalloonTipIcon = ToolTipIcon.Info,
                    BalloonTipTitle = "Spot-DL Ui - Downloading URL",
                    BalloonTipText = URL,
                };

                downloadNotify.ShowBalloonTip(5000);


            }

            Process.Start(startInfo);

            this.tbURL.Clear();
        }



        public void monitorClipboard()
        {
            while (true)
            {
                Task.Delay(1000).Wait(); // simple wait function.

                if (Vars.cb_retrieve) // if app is allowed to take URLS from clipboard
                {
                    Console.WriteLine("Checking...");

                    Thread staThread = new Thread(x =>
                    {
                        string cbUrl = Clipboard.GetText(TextDataFormat.Text);

                        if (cbUrl.StartsWith("https://open.spotify.com/") && cbUrl != Vars.cb_CurrentUrl) // user has spotify url copied
                        {
                            Vars.cb_CurrentUrl = cbUrl;
                            Console.WriteLine("Spotify URL detected.");

                            sendQueryToSpotdl(Vars.cb_CurrentUrl, true);

                        }
                    });

                    staThread.SetApartmentState(ApartmentState.STA);
                    staThread.Start();
                    staThread.Join();

                }

            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.tbURL;

            Task t = new Task(monitorClipboard);
            t.Start();



        }

        private void tbDownload_Click(object sender, EventArgs e)
        {
            string URL = this.tbURL.Text;
            sendQueryToSpotdl(URL, true);
        }

        private void cbAutoDL_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbAutoDL.Checked)
            {
                Vars.cb_retrieve = true;
            }
            else
            {
                Vars.cb_retrieve = false;
            }    
        }
    }
}
