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
    public partial class Assignment_Feedback : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");

        
        public Assignment_Feedback()
        {
            InitializeComponent();
           
        }
        void PopulateCombo()
        {
            string select = "Select * from Assignmemt_Dates";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Assignment_number", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbAssignment.ValueMember = "Assignment_number";
                cmbAssignment.DataSource = dt;
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
            string fetch = "Select * from Assignmemt_Dates where Assignment_number = " + cmbAssignment.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["Assignement_Issued"].ToString();
                txtSubject.Text = patname;
            }
            con.Close();
        }
        string potname;
        void FetchSurname()
        {
            con.Open();
            string fetch = "Select * from Assignmemt_Dates where Assignment_number = " + cmbAssignment.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                potname = dr["Assignment_Date_Issued"].ToString();
                txtD_Issued.Text = potname;
            }
            con.Close();
        }
        string PitchName;
        void fetchGender()
        {
            con.Open();
            string fetch = "Select * from Assignmemt_Dates where Assignment_number = " + cmbAssignment.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PitchName = dr["Deadline_For_Assignemt"].ToString();
                txtDate.Text = PitchName;
            }
            con.Close();
        }

        string Pitch;
        void fetchGrade()
        {
            con.Open();
            string fetch = "Select * from Assignmemt_Dates where Assignment_number = " + cmbAssignment.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(fetch, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Pitch = dr["Grade"].ToString();
                txtGrade.Text = Pitch;
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmbAssignment.Text = "";
            txtSubject.Text = "";
            txtD_Issued.Text = "";
            txtDate.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtGrade.Text = "";
            txtMarks.Text = "";
           // txtLevels.Text = "";
        }
        //int num, num1, num2, num3, num4, num5, num6;
        private void button1_Click(object sender, EventArgs e)
        {
                con.Open();
                string query = "insert into Assignemt_Feedback values('"+cmbAssignment.SelectedValue.ToString()+"' , '"+txtSubject.Text+"', '"+txtD_Issued.Text+"', '"+txtDate.Text+"', '"+txtName.Text+"', '"+txtSurname.Text+"', '"+txtGrade.Text+"', '"+txtMarks.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Feedback successfully added! Thank you");
                con.Close();
            
        }

        private void Assignment_Feedback_Load(object sender, EventArgs e)
        {
            LoadTheme();
            PopulateCombo();
            
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

        private void cmbAssignment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fatchDataPath();
            FetchSurname();
            fetchGender();
            fetchGrade();
        }
    }
}
