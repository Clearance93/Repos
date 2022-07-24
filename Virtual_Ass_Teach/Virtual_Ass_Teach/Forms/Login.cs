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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        void populate()
        {
            string MySql = "Select * from PersonalTbl";
            SqlCommand cmd = new SqlCommand(MySql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("VAT_L_Number_Id", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbUsername.ValueMember = "VAT_L_Number_Id";
                cmbUsername.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        string Fetch;
        void FetchIdNumber()
        {
            con.Open();
            string fetch = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbUsername.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fetch = dr["ID_Number"].ToString();
                txtId_Number.Text = Fetch;
            }
            con.Close();
        }
        string fetch;
        void FetchName()
        {
            con.Open();
            string take = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbUsername.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(take, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                fetch = dr["First_Name"].ToString();
                txtName.Text = fetch;
            }
            con.Close();
        }
        string take;
        void FetchSurname()
        {
            con.Open();
            string query = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbUsername.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                take = dr["Surname"].ToString();
                txtSurname.Text = take;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form = new Admin_Dashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUsername.Text == "" || txtPassword.Text == "" || txtConfrim_Password.Text == "")
            {
                MessageBox.Show("Enter all the fields");
            }
            else if (cmbUsername.Text == "")
            {
                MessageBox.Show("The Username field is empty!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("The Password field is empty!");
            }
            else if (txtConfrim_Password.Text == "")
            {
                MessageBox.Show("Confirm Password field is empty!");
            }
            else if (txtPassword.Text != txtConfrim_Password.Text)
            {
                MessageBox.Show("The Password do not match!");
            }
            else
            {
                con.Open();
                string query = "insert into LoginTbl  values('" + cmbUsername.Text + "', '" + txtPassword.Text + "', '" + txtConfrim_Password.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration was successful!");
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            populate();
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void cmbUsername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchIdNumber();
            FetchName();
            FetchSurname();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
