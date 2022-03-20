using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ubuntu_Downloader
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        void HideInfo()
        {
            Invoke((MethodInvoker)delegate {
                progressBarMain.Visible = false;
                lblInfo.Visible = false;
                lblRec.Visible = false;
                lblTotal.Visible = false;
                lblFormat.Visible = false;
                lblTotalFromat.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
            });
        }

        void ShowInfo()
        {
            Invoke((MethodInvoker)delegate {
                progressBarMain.Visible = true;
                lblInfo.Visible = true;
                lblRec.Visible = true;
                lblTotal.Visible = true;
                lblFormat.Visible = true;
                lblTotalFromat.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
            });
        }

        void EnableControls()
        {
            Invoke((MethodInvoker)delegate {
                comboBoxArc.Enabled = true;
                comboBoxEdition.Enabled = true;
                btnDownload.Enabled = true;
            });
        }

        void DisableControls()
        {
            Invoke((MethodInvoker)delegate {
                comboBoxArc.Enabled = false;
                comboBoxEdition.Enabled = false;
                btnDownload.Enabled = false;
            });
        }

        private WebClient client = new WebClient();

        private void MainFrm_Load(object sender, EventArgs e)
        {
            HideInfo();
            comboBoxEdition.SelectedIndex = 0;
            comboBoxArc.SelectedIndex = 0;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (comboBoxEdition.SelectedIndex == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Disc Image|*.iso";
                saveFileDialog.FileName = "ubuntu-20.04.4-desktop-amd64";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Download("https://releases.ubuntu.com/focal/ubuntu-20.04.4-desktop-amd64.iso", saveFileDialog.FileName);
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Disc Image|*.iso";
                saveFileDialog.FileName = "ubuntu-20.04.4-live-server-amd64";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Download("https://releases.ubuntu.com/focal/ubuntu-20.04.4-live-server-amd64.iso", saveFileDialog.FileName);
                }
            }
        }

        private void Download(string url, string savepath)
        {
            ShowInfo();
            DisableControls();
            btnDownload.Enabled = false;
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(url), savepath);
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                lblInfo.Text = "Downloading: %" + Math.Truncate(percentage).ToString();
                BytesToString(e.BytesReceived, lblRec, lblFormat);
                BytesToString(e.TotalBytesToReceive, lblTotal, lblTotalFromat);
                progressBarMain.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed", "Ubuntu Downloader");
            EnableControls();
        }

        void BytesToString(long byteCount, Label ReceiveLabel, Label Format)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
            {
                ReceiveLabel.Text = "0";
                Format.Text = suf[0];
            }
            else
            {
                long bytes = Math.Abs(byteCount);
                int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
                double num = Math.Round(bytes / Math.Pow(1024, place), 1);
                ReceiveLabel.Text = (Math.Sign(byteCount) * num).ToString();
                Format.Text = suf[place];
            }
        }

        private void linkLabelSysReq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("2 GHz dual core processor or better\n4 GB system memory\n25 GB of free hard drive space\nInternet access is helpful\nEither a DVD drive or a USB port for the installer media", "Recommended system requirements for Ubuntu 20.04.4 LTS");
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.CancelAsync();
            client.Dispose();
            Environment.Exit(0);
        }
    }
}
