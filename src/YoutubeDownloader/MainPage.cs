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
using VideoLibrary;

namespace YoutubeDownloader
{
    public partial class MainPage : Form
    {
        string path = @"C:\Users\User\Downloads\";
        public MainPage()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSelectFolder(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    guna2TextBox2.Text = folderDialog.SelectedPath+@"\";
                    path = folderDialog.SelectedPath;
                }
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            SaveVideoToDisk(guna2TextBox1.Text);
        }

        void SaveVideoToDisk(string link)
        {
            var youTube = YouTube.Default;
            //var videos = youTube.GetAllVideos(link);
            var video = youTube.GetVideo(link);

            File.WriteAllBytes($@"{path}\" + video.FullName, video.GetBytes());
        }
    }
}
