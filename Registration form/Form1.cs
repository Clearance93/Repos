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

namespace Registration_form
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=clearance;Initial Catalog=Registration_form;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into regTbl values ('"+ txtFullname.Text+ "', '"+txtSurname.Text+"', '"+txtEmail.Text+"', '"+txtAddress.Text+"', '"+txtPhone.Text+"', '"+cmbGender.SelectedItem.ToString()+"', '"+txtUsername.Text+"', '"+txtPass.Text+"' )";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration successful");
            con.Close();
        }
    }
}
