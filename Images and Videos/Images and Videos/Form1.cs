using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images_and_Videos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // string[] paths, files;
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;

            ImageList image = new ImageList();
            image.ImageSize = new System.Drawing.Size(130, 40);

            var imageFile = Image.FromFile(@"E:\Pictures\Cars\FB_IMG_15723521854732527.jpg");

            image.Images.Add(imageFile);
            ImagesViewer.BackgroundImage = imageFile;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void Imagelist_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ImagesViewer.Update = paths[View.SelectedIndex]
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            
            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               files = open.SafeFileNames;
                paths = open.FileNames;
            }

            for(int i = 0; i < files.Length; i++)
            {
                Imagelist.Items.Add(files[i]);
            }*/
        }
    }
}
