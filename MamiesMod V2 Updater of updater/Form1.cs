using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace Updater_of_updater_2
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        public Form1()
        {
            InitializeComponent();
            try
            {
                wc.DownloadFileCompleted += FileDownloadComplete;
                Uri url = new Uri("https://drive.google.com/uc?export=download&id=19PiCJqWPlDKNcPoUGmCTWlSSH_NF7smG");
                wc.DownloadFileAsync(url, @"C:/Program Files (x86)/MamiesMod V2/Updater.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Try to lauch in administrator !");
            }
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                try
                {
                    File.Delete(@"C:/Program Files (x86)/MamiesMod V2/Updater.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    //wc.DownloadFile("https://drive.google.com/uc?export=download&id=19PiCJqWPlDKNcPoUGmCTWlSSH_NF7smG", @"C:/Program Files (x86)/MamiesMod V2/Updater.exe");
                    wc.DownloadFile("https://drive.google.com/u/0/uc?export=download&confirm=eLFM&id=19PiCJqWPlDKNcPoUGmCTWlSSH_NF7smG", @"C:/Program Files (x86)/MamiesMod V2/Updater.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show("MamiesMod V2 Updater is update !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
