using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Ass_Teach
{
    public partial class Dashboard : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        public Dashboard()
        {
            InitializeComponent();
            random = new Random();
            label2.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void SendMessage();

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelVitual.BackColor = color;
                    panelVAT.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    label2.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelManu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Attendance(), sender);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin(), sender);
        }

        private void btnQuestion_P_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Authorized_only(), sender);
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Assignment(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Signup_Reg form = new Signup_Reg();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "VAT Dashboard";
            panelVitual.BackColor = Color.FromArgb(0, 150, 136);
            panelVAT.BackColor = Color.FromArgb(31, 31, 58);
            currentButton = null;
            label2.Visible = false;
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelVitual_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage();
        }
    }
}
