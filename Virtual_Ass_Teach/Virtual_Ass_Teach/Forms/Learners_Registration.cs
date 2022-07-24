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
    public partial class Learners_Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");

        private Button currentButton;
        private Random random;
        private int tempindex;
        public Learners_Registration()
        {
            InitializeComponent();
            random = new Random();
        }

        /*private Color SelectThemeColor()
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
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            /*ActiveButton(sender);
            txtFull_Name.Text = "";
            txtSecond_Number.Text = "";
            txtDate.Text = "";
            txtID_Number.Text = "";
            cmbGender.Text = "";
            txtContact_Number.Text = "";
            txtEmail_Address.Text = "";
            txtStreet_Number.Text = "";
            txtSection.Text = "";
            txtSuburb.Text = "";
            txtCode.Text = "";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form = new Admin_Dashboard();
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtFull_Name.Text = "";
            txtSecond_Number.Text = "";
            txtDate.Text = "";
            txtID_Number.Text = "";
            cmbGender.Text = "";
            txtContact_Number.Text = "";
            txtEmail_Address.Text = "";
            txtStreet_Number.Text = "";
            txtSection.Text = "";
            txtSuburb.Text = "";
            txtCode.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtFull_Name.Text == "" || txtSecond_Number.Text == "" || txtDate.Text == "" || txtID_Number.Text == "" || cmbGender.Text == "" || txtContact_Number.Text == "" || txtEmail_Address.Text == "" || txtStreet_Number.Text == "" || txtSection.Text == "" || txtSuburb.Text == "" || txtCode.Text == "")
            {
                MessageBox.Show("Fill the all the fields");
            }
            /*else if(cmbGender.Text != "Male" || cmbGender.Text != "Female")
            {
                MessageBox.Show("Please select your gender!");
            }*/
            else
            {
                con.Open();
                string query = "insert into PersonalTbl values ('" + txtFull_Name.Text + "', '" + txtSecond_Number.Text + "', '" + txtDate.Text + "', '" + txtID_Number.Text + "', '" + cmbGender.SelectedItem.ToString() + "', '" + txtContact_Number.Text + "', '" + txtEmail_Address.Text + "', '" + txtStreet_Number.Text + "', '" + txtSection.Text + "', '" + txtSuburb.Text + "', '" + txtCode.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Learner Successfully added to the database!");
                con.Close();
                //populate();

                Educational form = new Educational();
                form.Show();
                this.Hide();
            }
        }

        private void Learners_Registration_Load(object sender, EventArgs e)
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
