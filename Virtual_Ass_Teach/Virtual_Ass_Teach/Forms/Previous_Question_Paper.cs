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
using System.IO;

namespace Virtual_Ass_Teach.Forms
{
    public partial class Previous_Question_Paper : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");

       // private Button currentButton;
        //private Random random;
        //private int tempindex;
        //private Form activeForm;
        public Previous_Question_Paper()
        {
            InitializeComponent();
            //random = new Random();
        }

        /*private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }*/

       /* private void ActiveButton(object btnSender)
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
        }*/

        private void populate()
        {
            using (SqlConnection con = GetConnection())
            {

                string query = "select ID, File_Name, Extension from Previous_Question_Paper";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                //var ds = new DataSet();
                da.Fill(dt);
                //DocumentsDV.DataSource = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    PreviousQuestionPaperDV.DataSource = dt;
                }
            }
        }
        private void SaveFile(string filepath)
        {
            using (Stream stream = File.OpenRead(filepath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filepath);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "Insert into Previous_Question_Paper (File_Name, Data, Extension) values (@name, @Data, @extn)";

                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    //con.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void Previous_Question_Paper_Load(object sender, EventArgs e)
        {
           // LoadTheme();
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
          
                SaveFile(txtFilePath.Text);
                MessageBox.Show("Saved");
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // ActiveButton(sender);
            var selectedRow = PreviousQuestionPaperDV.SelectedRows;

            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
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


        private void OpenFile(int id)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = "Select Data, File_Name, Extension from Previous_Question_Paper where ID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["File_Name"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var filename = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss") + extn);
                    File.WriteAllBytes(filename, data);
                    System.Diagnostics.Process.Start(filename);
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=Clearance;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            populate();
           // LoadTheme();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authorized_Registration form = new Authorized_Registration();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(txtFilePath.Text == "")
            {
                MessageBox.Show("Please enter File Path number!");
            }
            else
            {
                con.Open();
                string query = "Delete from Previous_Question_Paper where ID = " + txtFilePath.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("File successfully removed");
                con.Close();
            }
        }
    }
}
