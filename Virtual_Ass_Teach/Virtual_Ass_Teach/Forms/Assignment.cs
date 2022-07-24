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
    public partial class Assignment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Assignment()
        {
            InitializeComponent();
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            populateCombo();
        }

        private void populateCombo()
        {
            using (SqlConnection con = GetConnection())
            {

                string query = "select * from Assignmemt_Dates";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                //var ds = new DataSet();
                da.Fill(dt);
                //DocumentsDV.DataSource = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    AssignmentDateDV.DataSource = dt;
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=Clearance;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDelete.Text == "")
            {
                MessageBox.Show("Assignemt marks couldn't be deleted becuase the field was not specified by the assignment number!");
            }
            else
            {
                con.Open();
                string query = "Delete from Assignemt_Feedback where Assignment_Number = " + txtDelete.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assignment removed");
                con.Close();
            }
        }
    }
}
