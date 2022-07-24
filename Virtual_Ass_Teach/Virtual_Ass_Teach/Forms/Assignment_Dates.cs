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
    public partial class Assignment_Dates : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True"); 
        public Assignment_Dates()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAssignment.Text = "";
            txtDate.Text = "";
            txtGrade.Text = "";
            txtDealine.Text = "";
            txtNumber.Text = "";
            //txtLevel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Assignmemt_Dates values ('" + txtAssignment.Text + "', '" + txtDate.Text + "', '" + txtGrade.Text + "', '" + txtDealine.Text + "', '" + txtNumber.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Assignment successefully captured!");
            con.Close();
        }

        private void Assignment_Dates_Load(object sender, EventArgs e)
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
