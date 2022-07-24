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
    public partial class Assignment_MArks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Assignment_MArks()
        {
            InitializeComponent();
        }

        private void Assignment_MArks_Load(object sender, EventArgs e)
        {
            populateCombo();
        }

        private void populateCombo()
        {
            using (SqlConnection con = GetConnection())
            {

                string query = "select * from Assignemt_Feedback";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                //var ds = new DataSet();
                da.Fill(dt);
                //DocumentsDV.DataSource = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    Assignment_MarksDV.DataSource = dt;
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=Clearance;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        }
    }
}
