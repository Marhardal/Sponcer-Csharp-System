﻿using System;
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
    public partial class School : UserControl
    {
        public School()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmtxt.Text != "" || loctxt.Text != "" || posttxt.Text != "" || faccmd.selectedIndex != 0 || typcmd.selectedIndex != 0 || feestxt.Text != "") 
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        string sql = "Select * from School where Location=@loc and Faculty=@fac and [Postal Address]=@pos and Type=@typ";
                        com=new SqlCommand(sql, connection);
                        com.Parameters.Add(new SqlParameter("@fac", faccmd.selectedValue));
                        com.Parameters.Add(new SqlParameter("@pos", posttxt.Text));
                        com.Parameters.Add(new SqlParameter("@loc", loctxt.Text));
                        com.Parameters.Add(new SqlParameter("@typ", typcmd.selectedValue));
                        SqlDataReader sqlData= com.ExecuteReader();
                        if (sqlData.HasRows)
                        {
                            sqlData.Read();
                            MessageBox.Show("School already exist, Please change the details to continue.");
                            sqlData.Close();
                        }
                        else
                        {
                            string insert = "insert into School values(@nm, @loc, @fac, @pos, @typ, @fee, now())";
                            com =new SqlCommand(insert, connection);
                            com.Parameters.Add(new SqlParameter("@fac", faccmd.selectedValue));
                            com.Parameters.Add(new SqlParameter("@pos", posttxt.Text));
                            com.Parameters.Add(new SqlParameter("@loc", loctxt.Text));
                            com.Parameters.Add(new SqlParameter("@typ", typcmd.selectedValue));
                            com.Parameters.Add(new SqlParameter("nm", nmtxt.Text));
                            com.Parameters.Add(new SqlParameter("@fee", feestxt));
                            var res=com.ExecuteNonQuery();
                            if (res != 0)
                            {
                                Hide();
                                Parent.Hide();
                                MessageBox.Show("School created successfully!! Please Refresh the grid");
                            }
                            else
                            {
                                MessageBox.Show("Failed to create school.");
                            }
                        }
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Fill in all the fields to continue");
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
                    string update = "update School set Name=@nm, Location=@loc, Faculty=@fac, [Postal Address]=@pos, Type=@typ, Fees=@fee Where ID=@id;";
                    com=new SqlCommand(update, connection);
                    com.Parameters.Add(new SqlParameter("@fac", faccmd.selectedValue));
                    com.Parameters.Add(new SqlParameter("@pos", posttxt.Text));
                    com.Parameters.Add(new SqlParameter("@loc", loctxt.Text));
                    com.Parameters.Add(new SqlParameter("@typ", typcmd.selectedValue));
                    com.Parameters.Add(new SqlParameter("nm", nmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@fee", feestxt));
                    com.Parameters.Add(new SqlParameter("id", id));
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Hide();
                        Parent.Hide();
                        MessageBox.Show("School Updated Successfully!! Please Refresh the grid to see the changes");
                    }
                    else
                    {
                        MessageBox.Show("School Not Updated, Please try again later.");
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
