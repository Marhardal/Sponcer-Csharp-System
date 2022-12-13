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
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();
        string gender;
        string id;

        private void Insertbtn_Click(object sender, EventArgs e)
        { 
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    if (fnmtxt.Text != "" & snmtxt.Text != "" & schcmb.selectedIndex != 0 & spcrcmd.selectedIndex != 0 & clacmd.selectedIndex != 0)
                    {
                        connection.Open();
                        string insert = "insert into Student values(@fnm, @snm, @gen, @age, @scid, @spid, @cid, getdate());";
                        com = new SqlCommand(insert, connection);
                        com.Parameters.Add(new SqlParameter("@fnm", fnmtxt.Text));
                        com.Parameters.Add(new SqlParameter("@snm", snmtxt.Text));
                        if (fmlchckd.Checked == true)
                        {
                            gender = fml.Text;
                        }
                        else if (mlchckd.Checked == true)
                        {
                            gender = ml.Text;
                        }
                        com.Parameters.Add(new SqlParameter("@gen", gender));
                        com.Parameters.Add(new SqlParameter("@age", dobtxt.Value));
                        com.Parameters.Add(new SqlParameter("@scid", scid));
                        com.Parameters.Add(new SqlParameter("@spid", spid));
                        com.Parameters.Add(new SqlParameter("@cid", cid));
                        var res = com.ExecuteNonQuery();
                        if (res > 0)
                        {
                            Hide();
                            Parent.Hide();
                            MessageBox.Show("Student Created Successfully!! Please Refresh the grid.");
                        }
                        else
                        {
                            MessageBox.Show("Student Not Created!! Please Try Again Later.");
                        }
                        connection.Close(); 
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string update = "update Student set [First Name]=@fnm, Surname=@snm, Gender=@gen, Age=@age, [School ID]=@scid, [Sponser ID]=@spid, [Class ID]=@cid where ID=@id;";
                    com= new SqlCommand(update, connection);
                    com.Parameters.Add(new SqlParameter("@fnm", fnmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@snm", snmtxt.Text));
                    com.Parameters.Add(new SqlParameter("@gen", gender));
                    com.Parameters.Add(new SqlParameter("@age", dobtxt.Value));
                    com.Parameters.Add(new SqlParameter("@scid", scid));
                    com.Parameters.Add(new SqlParameter("@spid", spid));
                    com.Parameters.Add(new SqlParameter("@cid", cid));
                    com.Parameters.Add(new SqlParameter("@id", id));
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Student Updated Successfully!! Please Refresh the grid.");
                    }
                    else
                    {
                        MessageBox.Show("Student Not Updated!! Please Try Again Later.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void school()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from School";
                    com = new SqlCommand(select, connection);
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        while (sqlData.Read())
                        {
                            schcmb.Items.Add(sqlData[1].ToString());
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

        void lass()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Classes";
                    com = new SqlCommand(select, connection);
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        while (sqlData.Read())
                        {
                            clacmd.Items.Add(sqlData[2].ToString()); 
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

        void sponcer()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Sponser";
                    com = new SqlCommand(select, connection);
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        while (sqlData.Read())
                        {
                            spcrcmd.Items.Add(sqlData[1].ToString()); 
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

        private void Student_Load(object sender, EventArgs e)
        {
            school();
            sponcer();
        }

        string scid;

        private void schcmb_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select ID from School Where Name=@nm";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("@nm", schcmb.selectedValue));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        scid = sqlData[0].ToString();
                        sqlData.Close();
                        select = "Select * from Classes where ID='" + scid + "'";
                        com = new SqlCommand(select, connection);
                        sqlData = com.ExecuteReader();
                        if (sqlData.HasRows)
                        {
                            while (sqlData.Read())
                            {
                                clacmd.Items.Add(sqlData[2].ToString());
                            }
                        }
                        sqlData.Close();
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

        string spid;

        private void spcrcmd_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select ID from Sponser where Name=@nm";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("@nm", spcrcmd.selectedValue));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        spid= sqlData[0].ToString();
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

        string cid;

        private void clacmd_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select ID from Classes Where Class=@nm";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("@nm", clacmd.selectedValue));
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        cid = sqlData[0].ToString();
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

        private void schcmb_Load(object sender, EventArgs e)
        {

        }
    }
}
