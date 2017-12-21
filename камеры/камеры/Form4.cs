using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace камеры
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Video Our_video;
        Video Our_video2;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Our_video = new Video(openFileDialog1.FileName);
                Our_video.Open(openFileDialog1.FileName);
                Our_video.Play();
                Our_video.Owner = panel1;
            }

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Our_video2 = new Video(openFileDialog2.FileName);
                Our_video2.Open(openFileDialog2.FileName);
                Our_video2.Play();
                Our_video2.Owner = panel2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Our_video.Playing == true  )
            {
                Our_video.Pause();
            }
            if (Our_video2.Playing == true)
            {
                Our_video2.Pause();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Our_video.Playing == false)
            {
                Our_video.Play();
            }
            if (Our_video2.Playing == false)
            {
                Our_video2.Play();
            }
        }
    }
}
