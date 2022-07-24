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
    public partial class Learner_s_Register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Learner_s_Register()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "Select * From AttendanceTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Learner_infoDV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Learner_s_Register_Load(object sender, EventArgs e)
        {
            populate();
            LoadTheme();
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
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

            private void button2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form = new Admin_Dashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLearner.Text == "")
            {
                MessageBox.Show("Enter Learner ID Number of a learner!");
            }
            else
            {
                con.Open();
                string query = "Delete from AttendanceTbl where ID_NUmber = " + txtLearner.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Learner successfully removed in the class!");
                con.Close();
                populate();
            }
        }
    }
}
