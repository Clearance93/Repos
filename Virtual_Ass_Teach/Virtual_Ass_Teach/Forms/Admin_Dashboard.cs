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
    public partial class Admin_Dashboard : Form
    {

        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        public Admin_Dashboard()
        {
            InitializeComponent();
            random = new Random();
            label3.Visible = false;
        }

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
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelVirtual.BackColor = color;
                    panelVAT.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    label3.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelManu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            //LoadTheme();
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
            label2.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Learners_Registration(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Learner_Educational_Information(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Assignment_Updates(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Documents(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Virtual_Classes(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Learner_s_Register(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Learner_Registration_Information(), sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label2.Text = "VAT Dashboard";
            panelVAT.BackColor = Color.FromArgb(0, 150, 136);
            panelVAT.BackColor = Color.FromArgb(31, 31, 58);
            currentButton = null;
            label3.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Assignment_Dates(), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Assignment_Feedback(), sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Assignment_MArks(), sender);
        }

        private void panelManu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
