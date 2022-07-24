using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Virtual_Ass_Teach.Forms
{
    public partial class Memorundum_upload : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLEARANCE;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
        public Memorundum_upload()
        {
            InitializeComponent();
        }

        private void popolate()
        {
            using (SqlConnection con = GetConnection())
            {

                string query = "select ID, File_Name, Extension from memorandum";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                //var ds = new DataSet();
                da.Fill(dt);
                //DocumentsDV.DataSource = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    memorandumDV.DataSource = dt;
                }
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
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtmemorundum.Text = dlg.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(txtmemorundum.Text);
            MessageBox.Show("Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = memorandumDV.SelectedRows;

            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=Clearance;Initial Catalog=Virtual_Assistance_Teaching;Integrated Security=True");
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

                string query = "Insert into memorandum (File_Name, Data, Extension) values (@name, @Data, @extn)";

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

        private void OpenFile(int id)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = "Select Data, File_Name, Extension from memorandum where ID=@id";
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

        private void Memorundum_upload_Load(object sender, EventArgs e)
        {
            popolate();
            LoadTheme();
        }
    }   
}
