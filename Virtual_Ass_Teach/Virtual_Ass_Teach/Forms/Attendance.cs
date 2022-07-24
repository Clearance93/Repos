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
    public partial class Attendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Attendance()
        {
            InitializeComponent();
            //LoadTheme();
        }


        void PopulateCombo()
        {
            string select = "Select * from PersonalTbl";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("VAT_L_Number_Id", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbLearner.ValueMember = "VAT_L_Number_Id";
                cmbLearner.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

        string patname;
        void fatchDataPath()
        {
            con.Open();
            string fetch = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbLearner.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["First_Name"].ToString();
                txtName.Text = patname;
            }
            con.Close();
        }
        string potname;
        void FetchSurname()
        {
            con.Open();
            string fetch = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbLearner.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                potname = dr["Surname"].ToString();
                txtSurname.Text = potname;
            }
            con.Close();
        }
        string PitchName;
        void fetchGender()
        {
            con.Open();
            string fetch = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbLearner.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PitchName = dr["ID_Number"].ToString();
                txtIDNumber.Text = PitchName;
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmbLearner.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtIDNumber.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbLearner.Text == "")
            {
                MessageBox.Show("Enter Learner's Number");
            }
            else
            {
                con.Open();
                string query = "insert into AttendanceTbl values ('" + cmbLearner.SelectedText.ToString() + "', '" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtIDNumber.Text + "', '"+txtDate.Text+"', '"+txtTime.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("We Welcome you '" + txtName.Text + "'  '" + txtSurname.Text + "'to our class, have a nice virtual class. All the best!");
                con.Close();
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach(Control btns in this.Controls)
            {
                if(btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void cmbLearner_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fatchDataPath();
            FetchSurname();
            fetchGender();
        }
    }
}
