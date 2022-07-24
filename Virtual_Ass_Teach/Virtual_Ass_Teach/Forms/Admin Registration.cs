using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Virtual_Ass_Teach.Forms
{
    public partial class Admin_Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");

        private Button currentButton;
        private Random random;
        private int tempindex;
        public Admin_Registration()
        {
            InitializeComponent();
            random = new Random();
        }


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempindex == index)
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

        private void Admin_Registration_Load(object sender, EventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if(txtName.Text == "" || txtSurname.Text == "" || txtDate.Text == "" || txtID_Number.Text == "" || cmbGender.Text == "" || txtContact.Text == ""|| txtEmail.Text == "" || txtStreetName.Text == "" || txtSection.Text == "" || txtSuburb.Text == "" || txtCode.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtConfirm_Password.Text == "")
            {
                MessageBox.Show("Enter all the fields");
            }
            else if(txtPassword.Text != txtConfirm_Password.Text)
            {
                MessageBox.Show("Password do not match!");
            }
            else if(txtName.Text != txtUsername.Text)
            {
                MessageBox.Show("Your username should be your registered name");
            }
            else if("select Count (*) AdministratorTbl where IDNumber = "+txtID_Number.Text+"" == txtID_Number.Text)
            {
                MessageBox.Show("The email exist, please use the different email address!");
            }
            else
            {
                con.Open();
                string query = "insert into AdministratorTbl values('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtDate.Text + "', '" + txtID_Number.Text + "', '" + cmbGender.SelectedText.ToString() + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtStreetName.Text + "', '" + txtSection.Text + "', '" + txtSuburb.Text + "', '" + txtCode.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtConfirm_Password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Administrator information was successfully added!");
                con.Close();
            }

            /*con.Open();
            string Sql = "Select Count (*) from AdministratorTbl where IDNumber = " + txtID_Number.Text + " and Email = " + txtEmail.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(Sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("The ID Number or the email does exist in our database!");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            txtName.Text = "";
            txtSurname.Text = "";
            txtSuburb.Text = "";
            txtDate.Text = "";
            txtID_Number.Text = "";
            cmbGender.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtStreetName.Text = "";
            txtSection.Text = "";
            txtSuburb.Text = "";
            txtCode.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm_Password.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
