using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sponcer_Csharp_System
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from users where Username=@usnm and Password=@pass";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("@usnm", usnmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@pass", passtxt.Text));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        MessageBox.Show("User Already Exist. Please Change your Username or Password.");
                    }
                    else
                    {
                        sqlData.Close();
                        string insert = "insert into users values(@usnm, @pass, getdate());";
                        com = new SqlCommand(insert, connection);
                        com.Parameters.Add(new SqlParameter("@usnm", usnmtxt.Text));
                        com.Parameters.Add(new SqlParameter("@pass", passtxt.Text));
                        var res = com.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Hide();
                            MessageBox.Show("User created successfully Please Refresh the grid.");
                        }
                        else
                        {
                            MessageBox.Show("User not created. Please try again later.");
                        }
                    }
                    sqlData.Close();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        internal static string usnm;

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                    string select = "Select * from users where Username=@usnm and Password=@pass";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("@usnm", usnmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@pass", passtxt.Text));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        usnm = usnmtxt.Text;
                        Dashboard dashboard= new Dashboard();
                        dashboard.usnmtxt.Text=usnmtxt.Text;
                        Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found Please Make sure that you are Registered.");
                    }
                    sqlData.Close();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        internal string id;

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string update = "Update User set Username=@usnm, Password=@pass where ID=@id";
                    com = new SqlCommand(update, connection);
                    com.Parameters.Add(new SqlParameter("@usnm", usnmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@pass", passtxt.Text));
                    com.Parameters.Add(new SqlParameter("@id", id));
                    var res= com.ExecuteNonQuery();
                    if (res != 0)
                    {
                        Hide();
                        MessageBox.Show("User Updated.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
