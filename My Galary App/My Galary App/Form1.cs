using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Galary_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SelectedImage_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    ImagesListView.Items.Add(files[i]);
                    
                }
            }
        }
    }
}
