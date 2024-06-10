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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        internal static string usnm;

        void activity()
        {
            string insert = "insert into activities values(@id, @act, @tm, getdate());";
            com= new SqlCommand(insert, connection);
            com.Parameters.Add(new SqlParameter("@id", id));
            com.Parameters.Add(new SqlParameter("@act", "User Logged-in"));
            com.Parameters.Add(new SqlParameter("@tm", DateTime.Now.ToString("HH:mm:ss")));
            com.ExecuteNonQuery();
        }

        internal static string id;

        private void loginbtn_Click(object sender, EventArgs e)
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
                        sqlData.Read();
                        usnm = usnmtxt.Text;
                        id = sqlData[0].ToString();
                        Dashboard.uid = id;
                        sqlData.Close();
                        activity();
                        Dashboard dashboard = new Dashboard();
                        dashboard.usnmtxt.Text = usnmtxt.Text;
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
                MessageBox.Show("Login error " + er.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
