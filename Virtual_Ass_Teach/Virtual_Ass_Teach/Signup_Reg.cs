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

namespace Virtual_Ass_Teach
{
    public partial class Signup_Reg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Signup_Reg()
        {
            InitializeComponent();
        }

        private void Signup_Reg_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter login Credentials");
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select Count(*) from Logintbl where Userid = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Dashboard form = new Dashboard();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!");
                }
                con.Close();
            }
        }
    }
}
