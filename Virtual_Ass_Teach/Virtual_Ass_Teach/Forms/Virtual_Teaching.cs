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
    public partial class Virtual_Teaching : Form
    {
        public Virtual_Teaching()
        {
            InitializeComponent();
        }
        int duration = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration++;
            txttimer.Text = duration.ToString();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void txttimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form = new Admin_Dashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtUpload.Text = openFile.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            axWindowsMediaPlayer1.URL = txtUpload.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Virtual_Teaching_Load(object sender, EventArgs e)
        {
            LoadTheme();
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
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
