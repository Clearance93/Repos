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
    public partial class Authorized_Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");

        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        public Authorized_Registration()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelVirtual.BackColor = color;
                    panelVAT.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelManu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        void populate()
        {
            string MySql = "Select * from PersonalTbl";
            SqlCommand cmd = new SqlCommand(MySql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("VAT_L_Number_Id", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbUserName.ValueMember = "VAT_L_Number_Id";
                cmbUserName.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }

        string fetch;
        void FetchId()
        {
            con.Open();
            string query = "select * from PersonalTbl where VAT_L_Number_Id= " + cmbUserName.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                fetch = dr["ID_Number"].ToString();
                txtId_Number.Text = fetch;
            }
            con.Close();
        }

        string Take;
        void FetchName()
        {
            con.Open();
            string query = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbUserName.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Take = dr["First_Name"].ToString();
                txtName.Text = Take;
            }
            con.Close();
        }

        string binary;
        void fetchSurname()
        {
            con.Open();
            string query = "Select * from PersonalTbl where VAT_L_Number_Id = " + cmbUserName.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                binary = dr["Surname"].ToString();
                txtSurname.Text = binary;
            }
            con.Close();

        }
        private void Authorized_Registration_Load(object sender, EventArgs e)
        {
            populate();
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            cmbUserName.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtId_Number.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Some or all the fields are empty!");
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passowrd do not match!");
            }
            else if (txtName.Text != txtUsername.Text)
            {
                MessageBox.Show("Please use your name as your username!");
            }
            else
            {
                con.Open();
                string query = "insert into AuthorizedTbl Values ('" + cmbUserName.SelectedValue.ToString() + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtConfirmPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You are now authorized to access the authorized side Congratulations");
                con.Close();
            }
        }

        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchId();
            FetchName();
            fetchSurname();
        }
    }
}
