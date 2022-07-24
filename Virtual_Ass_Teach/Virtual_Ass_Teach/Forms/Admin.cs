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
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdmin_UserName.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdmin_UserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter Administrator login in details");
            }
            else
            {
                con.Open();
                string query = "Select Count(*) from AuthorizedTbl where UserName= '" + txtAdmin_UserName.Text + "' and Password = '" + txtPassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Admin_Dashboard form = new Admin_Dashboard();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorrect username or password!");
                }
                con.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Registration form = new Admin_Registration();
            form.Show();
            this.Hide();
        }
    }
}
