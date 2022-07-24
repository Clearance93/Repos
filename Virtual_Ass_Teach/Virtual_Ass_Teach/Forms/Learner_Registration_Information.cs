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
    public partial class Learner_Registration_Information : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Learner_Registration_Information()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string pop = "Select * from PersonalTbl";
            SqlDataAdapter da = new SqlDataAdapter(pop, con);
            SqlCommandBuilder build = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LearnerDV.DataSource = ds.Tables[0];
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
            if (txtL_VAT_Id.Text == "")
            {
                MessageBox.Show("Enter Learner VAT Number!");
            }
            else
            {
                con.Open();
                string query = "Delete from  PersonalTbl where VAT_L_Number_Id = " + txtL_VAT_Id.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Learner Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void Learner_Registration_Information_Load(object sender, EventArgs e)
        {
            populate();
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
