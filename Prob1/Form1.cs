using System;
using System.IO;
using System.Windows.Forms;
using YoutubeDLSharp;


namespace Prob1
{
    public partial class Form1 : Form
    {

        private string binDir = AppContext.BaseDirectory; // yt-dlp.exe & ffmpeg.exe will later be saved here
        private string targetDir = @"C:\transfer\YouTube";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(binDir);
            // download binaries
            await YoutubeDLSharp.Utils.DownloadYtDlp(binDir);
            await YoutubeDLSharp.Utils.DownloadFFmpeg(binDir);

            //sanity check
            if (!File.Exists(Path.Combine(binDir, "yt-dlp.exe")) ||
            !File.Exists(Path.Combine(binDir, "ffmpeg.exe")))
            {
                MessageBox.Show("Failed to prepare yt-dlp or ffmpeg.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private async void btnDownload_Click(object sender, EventArgs e)
        { 
            
            string url = txtUrl.Text.Trim();

            // Check if directory is created. If not, create a new directory
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            var ytdl = new YoutubeDL();
            ytdl.YoutubeDLPath = Path.Combine(binDir, "yt-dlp.exe");
            ytdl.FFmpegPath = Path.Combine(binDir, "ffmpeg.exe");
            ytdl.OutputFolder = targetDir;
            
            // download video
            var res = await ytdl.RunVideoDownload(url);
            if (res.Success)
            {
                MessageBox.Show($"Success! Saved to:\n{res.Data}", "Download Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error:\n" + res.ErrorOutput, "Download Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
