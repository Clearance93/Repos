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

namespace Application_Form
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
         
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserNumber.Text == "" || txtPassoword.Text == "")
            {
                MessageBox.Show("Please fill in the medentory fields");
            }
            else if (txtPassoword.Text != txtCpassword.Text)
            {
                MessageBox.Show("The Password does not match");
            }

            SqlConnection con = new SqlConnection("Data Source=CLEARANCE;Initial Catalog=Online_Application_Registration_Form;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Application_Registration_Form]
           ([First_Name]
           ,[Last_Name]
           ,[Home_Langauge]
           ,[Date_Of_Birth]
           ,[Id_Number]
           ,[Contact_Number]
           ,[Altanative_Number]
           ,[Email_Address]
           ,[Gender]
           ,[Ethic]
           ,[Birth_Province]
           ,[Prefered_Work_Province]
           ,[User_Name]
           ,[Password]
           ,[Confirm_Password])
     VALUES
           ('"+txtFname.Text+"', '"+txtLname.Text+"','"+cmbHlanguage.SelectedItem.ToString()+"', '"+txtDateOfBirth.Text+"', '"+txtIdNumber.Text+"', '"+txtContact.Text+"'" +
           "'"+txtAlternative.Text+"', '"+txtEmailAddress.Text+"', '"+cmbGender.SelectedItem.ToString()+"', '"+cmbEthic.SelectedItem.ToString()+"'" +
           "'"+cmbBprovince.SelectedItem.ToString()+"', '"+cmbPWprovince.SelectedItem.ToString()+"', '"+txtUserNumber.Text+"', '"+txtPassoword.Text+"', '"+txtCpassword.Text+"')");


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration was Successful");


            Close();
        }
    }
}
