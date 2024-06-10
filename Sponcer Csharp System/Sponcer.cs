using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Sponcer_Csharp_System
{
    public partial class Sponcer : UserControl
    {
        public Sponcer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            if (sponcertxt.Text!="")
            {
                try
                {
                    if (connection.State==ConnectionState.Closed)
                    {
                        connection.Open();
                        string sql = "Select * from Sponser Where Name='" + sponcertxt.Text + "'";
                        com = new SqlCommand(sql, connection);
                        SqlDataReader sdr= com.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            sdr.Read();
                            MessageBox.Show("Sponcer already exist!! Please change the Sponcer Name.");
                            sdr.Close();
                        }
                        else
                        {
                            sdr.Close();
                            string insert = "Insert into Sponser values('" + sponcertxt.Text + "', '" + DateTime.Now.ToString("dd/mm/yyyy") + "')";
                            com = new SqlCommand(insert, connection);
                            var res = com.ExecuteNonQuery();
                            if (res > 0)
                            {
                                insert = "insert into activities values(@id, @act, @tm, getdate());";
                                com = new SqlCommand(insert, connection);
                                com.Parameters.Add(new SqlParameter("@id", uid));
                                com.Parameters.Add(new SqlParameter("@act", "User Logged-in"));
                                com.Parameters.Add(new SqlParameter("@tm", DateTime.Now.ToString("HH:mm:ss")));
                                com.ExecuteNonQuery();
                                Hide();
                                Parent.Hide();
                                MessageBox.Show("Sponcer Successfully Entered!! Don't forget to refresh the grid.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert Sponcer.");
                            }
                        }
                        connection.Close();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Fill in the textbox.");
            }
        }

        internal string id;

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State ==ConnectionState.Closed)
                {
                    string sql = "Update Sponser set Name='" + sponcertxt.Text + "' where ID='" + id + "';";
                    com = new SqlCommand(sql, connection);
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        string insert = "insert into activities values(@id, @act, @tm, getdate());";
                        com = new SqlCommand(insert, connection);
                        com.Parameters.Add(new SqlParameter("@id", uid));
                        com.Parameters.Add(new SqlParameter("@act", "Updated a sponser."));
                        com.Parameters.Add(new SqlParameter("@tm", DateTime.Now.ToString("HH:mm:ss")));
                        com.ExecuteNonQuery();
                        Hide();
                        Parent.Hide();
                        MessageBox.Show("Sponcer Successfully Updated!! Don't forget to refresh the grid.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update sponcer try again later.");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        internal static string uid;

        private void Sponcer_Load(object sender, EventArgs e)
        {
            Dashboard.uid=uid;
        }
    }
}
