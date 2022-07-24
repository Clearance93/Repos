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
    public partial class Educational : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Educational()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard form = new Admin_Dashboard();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrevious.Text == "" || cmbHighest.Text == "")
            {
                MessageBox.Show("Enter Medentory fields");
            }
            else if (cmbHighest.Text == "Yes")
            {
                MessageBox.Show("Supply the reason why do you want to repeat from combobox below!");
            }
            else
            {
                con.Open();
                string query = "insert into EducationaTbl values ('" + txtPrevious.Text + "', '" + cmbHighest.SelectedItem.ToString() + "', '" + cmbPassPrevious.SelectedItem.ToString() + "', '" + cmbMath.SelectedItem.ToString() + "', '" + cmbMath_Lit.SelectedItem.ToString() + "', '" + cmbPhysical_Science.SelectedItem.ToString() + "', '" + cmbLife_Science.SelectedItem.ToString() + "', '" + cmbAgricaltural_Science.SelectedItem.ToString() + "', '" + cmbGeography.SelectedItem.ToString() + "', '" + cmbAccounting.SelectedItem.ToString() + "', '" + cmbEconomics.SelectedItem.ToString() + "', '" + cmbBussiness_Study.SelectedItem.ToString() + "', '" + cmbCAT.SelectedItem.ToString() + "', '" + cmbLife_Oriantation.SelectedItem.ToString() + "', '" + cmbtuarims.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edicational information was successful!");
                con.Close();
                // populate();

                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Educational_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int heigt = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }
    }
}
