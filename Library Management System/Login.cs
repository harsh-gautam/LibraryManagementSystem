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
using System.Data.Sql;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LmsDB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String s = "Select * From Profile_Master Where Pro_User_Id='" + textUserID.Text + "' and Pro_User_Password='" + textPassword.Text + "'";
            
                

                SqlDataAdapter sda = new SqlDataAdapter("Select * From Profile_Master Where Pro_User_Id='" + textUserID.Text + "' and Pro_User_Password='" + textPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    LMS obj = new LMS();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                    MessageBox.Show("Invalid UserID or Password...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.ShowDialog();
        }
    }
}
