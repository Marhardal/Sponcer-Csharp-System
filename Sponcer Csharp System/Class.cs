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
    public partial class Class : UserControl
    {
        public Class()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        internal static string uid;
        private void Class_Load(object sender, EventArgs e)
        {
            Dashboard.uid=uid;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select Name from school";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        while (sqlData.Read())
                        {
                            nmcmd.Items.Add(sqlData.GetString(0));
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

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string sele = "Select ID from School where Name=@nm";
                    com = new SqlCommand(sele, connection);
                    com.Parameters.Add(new SqlParameter("@nm", nmcmd.selectedValue));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        var id = sqlData[0].ToString();
                        sqlData.Close();
                        string select = "select * from Classes where Class=@cla and School_id=@id;";
                        com = new SqlCommand(select, connection);
                        com.Parameters.Add(new SqlParameter("@cla", nmtxt.Text));
                        com.Parameters.Add(new SqlParameter("@id", id));
                        sqlData = com.ExecuteReader();
                        if (sqlData.HasRows)
                        {
                            sqlData.Read();
                            MessageBox.Show("Class already exist!! Please choose another class or school name.");
                        }
                        else
                        {
                            MessageBox.Show(id);
                            sqlData.Close();
                            string insert = "insert into classes values(@id, @cla, getdate());";
                            com= new SqlCommand(insert, connection);
                            com.Parameters.Add(new SqlParameter("@cla", nmtxt.Text));
                            com.Parameters.Add(new SqlParameter("@id", id));
                            var res = com.ExecuteNonQuery();
                            if (res != 0)
                            {
                                insert = "insert into activities values(@id, @act, @tm, getdate());";
                                com = new SqlCommand(insert, connection);
                                com.Parameters.Add(new SqlParameter("@id", uid));
                                com.Parameters.Add(new SqlParameter("@act", "User Logged-in"));
                                com.Parameters.Add(new SqlParameter("@tm", DateTime.Now.ToString("HH:mm:ss")));
                                com.ExecuteNonQuery();
                                Hide();
                                Parent.Hide();
                                MessageBox.Show("Class created successfully!! Please refresh the grid.");
                            }
                            else
                            {
                                MessageBox.Show("Class not created!! Please retry later.");
                            }
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

        internal string id;

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                    string sele = "Select ID from School where Name=@nm";
                    com = new SqlCommand(sele, connection);
                    com.Parameters.Add(new SqlParameter("@nm", nmcmd.selectedValue));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        var sid = sqlData[0].ToString();
                        sqlData.Close();
                        string update = "Update Classes set School_ID=@sid, Name=@nm where ID=@id";
                        com = new SqlCommand(update, connection);
                        com.Parameters.Add(new SqlParameter("@sid", sid));
                        com.Parameters.Add(new SqlParameter("@nm", nmtxt.Text));
                        com.Parameters.Add(new SqlParameter("@id", id));
                        var res = com.ExecuteNonQuery();
                        if (res != 0)
                        {
                            string insert = "insert into activities values(@id, @act, @tm, getdate());";
                            com = new SqlCommand(insert, connection);
                            com.Parameters.Add(new SqlParameter("@id", uid));
                            com.Parameters.Add(new SqlParameter("@act", "User Logged-in"));
                            com.Parameters.Add(new SqlParameter("@tm", DateTime.Now.ToString("HH:mm:ss")));
                            com.ExecuteNonQuery();
                            Hide();
                            Parent.Hide();
                            MessageBox.Show("Class updated Successfully!! Please refresh the grid to continue.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update class!! Please try again later.");
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
    }
}
