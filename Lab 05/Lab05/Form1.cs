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
using System.Xml.Linq;
using Lab05.Database1DataSetTableAdapters;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\OneDrive - NSBM\1st Year\3rd semester\Object oriented with c#\Practicals\lab05\Lab05\Database1.mdf"";Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;
            string dob = dateTimePicker1.Value.ToString("yyyy.MM.dd");
            string email = txtemail.Text;
            string username = txtusername.Text;
            string password = txtpass.Text;
            string confirmpassword = txtconfirmpass.Text;

            string Query1 = $"INSERT INTO SignUpNew(FirstName,LastName,DateofBirth,Email,Username,Password,ConfirmPassword) VALUES('{firstname}','{lastname}','{dob}','{email}','{username}','{password}','{confirmpassword}');";
            SqlCommand cmd1 = new SqlCommand(Query1,sqlconnection);

            if(password!=confirmpassword)
            {
                 MessageBox.Show("Passwords do not match. Please re-enter your password.", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }


            if (txtfirstname.Text == "" || txtlastname.Text == "" || dateTimePicker1.Text == "" || txtemail.Text == "" || txtpass.Text == "" || txtconfirmpass.Text == "")
            {
                MessageBox.Show("Please fill all fields", ("Textbox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                sqlconnection.Open();
                cmd1.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Sucessfully Sign Up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("errors:" + sqlEx.Message, "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           Form2 form2 = new Form2();
           form2.firstname = txtfirstname.Text;
           form2.lastname = txtlastname.Text;
           form2.username = txtusername.Text;
           form2.email = txtemail.Text;
           form2.ShowDialog();

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtemail.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
            txtconfirmpass.Text = "";
        }
    }
}
