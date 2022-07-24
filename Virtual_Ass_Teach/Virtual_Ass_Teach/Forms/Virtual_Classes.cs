using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Ass_Teach.Forms
{
    public partial class Virtual_Classes : Form
    {
        public Virtual_Classes()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Virtual_Teaching form = new Virtual_Teaching();
            form.Show();
            this.Hide();
        }

        private void Virtual_Classes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
