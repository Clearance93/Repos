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

namespace Hospital_Management_System
{
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=clearance;Initial Catalog=Hospital_Management_System;Integrated Security=True");
        public Doctor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDocName.Text == "" || txtDocSurname.Text == "" || cmbGender.Text == "" || txtExp.Text == "")
            {
                MessageBox.Show("Enter all the fields except Doctor HMS Id");
            }
            else
            {
                con.Open();
                string query = "insert into DoctorTbl values (" + txtDocName.Text + ", '" + txtDocSurname.Text + "', '" + cmbGender.SelectedValue.ToString() + "', '" + txtExp.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
            }
        }
    }
}
