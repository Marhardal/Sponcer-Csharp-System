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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        SqlCommand com = new SqlCommand();

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Home");
            headinglbl.Text = "Sponcer System\\Home";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\home_60px.png");
            Image.Image = img;
        }

        void sponcer()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string sql = "Select * from Sponser";
                    com = new SqlCommand(sql, connection);
                    SqlDataAdapter sqlData = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Sponcerdgv.DataSource = dt;
                    }
                    sqlData.Dispose();
                    dt.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Sponcerbtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Sponcer");
            headinglbl.Text = "Sponcer System\\Sponcer";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\parenting_50px.png");
            Image.Image = img;
            sponcer();
        }

        void school()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string sql = "Select * from school";
                    com = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Schooldgv.DataSource = dt;
                    }
                    sda.Dispose();
                    dt.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Schoolbtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Schools");
            headinglbl.Text = "Sponcer System\\Schools";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\school_house_60px.png");
            Image.Image = img;
            school();
        }

        void lass()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string sql = "select cls.ID, xul.Name, xul.Faculty, xul.[Postal Address], cls.Class from Classes as cls, School as xul where cls.School_ID=xul.ID";
                    com = new SqlCommand(sql, connection);
                    SqlDataAdapter sqlData= new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Classdgv.DataSource = dt;
                    }
                    sqlData.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void Classbtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Class");
            headinglbl.Text = "Sponcer System\\Class";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\classroom_64px.png");
            Image.Image = img;
            lass();
        }

        void student()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string sql = "select stu.[First Name], stu.Surname, stu.Gender, stu.[Date of Birth], xul.Name as [School Name], spo.Name as [Sponcer Name], cls.Class from Student as stu, Sponser as spo, School as xul, Classes as cls \r\nwhere stu.[School ID]=xul.ID and cls.ID=stu.[Class ID] and spo.ID=stu.[Sponser ID]";
                    com = new SqlCommand(sql, connection);
                    SqlDataAdapter sqlData= new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        studentdgv.DataSource = dt;
                    }
                    sqlData.Dispose();
                    dt.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void Studentbtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Student");
            headinglbl.Text = "Sponcer System\\Students";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\student_male_48px.png");
            Image.Image = img;
            student();
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            Stud.SetPage("Settings");
            headinglbl.Text = "Sponcer System\\Settings";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\settings_48px.png");
            Image.Image = img;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Sponcerdgv.Refresh();
        }

        private void Sponcerpribtn_Click(object sender, EventArgs e)
        {

        }

        private void studentinsbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            Student student = new Student();
            student.Location = new Point(0, 0);
            student.Insertbtn.BringToFront();
            student.bunifuCustomLabel2.Text = "Create Student";
            upsert.Controls.Add(student);
            upsert.Show();
        }

        private void Sponcerinsbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            Sponcer sponcer = new Sponcer();
            sponcer.Location = new Point(0, 170);
            sponcer.Insertbtn.BringToFront();
            sponcer.bunifuCustomLabel2.Text = "Create Sponcer";
            upsert.Controls.Add(sponcer);
            upsert.Show();
        }

        private void Sponcerupdbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            Sponcer sponcer = new Sponcer();
            sponcer.Location = new Point(0, 170);
            sponcer.Updatebtn.BringToFront();
            sponcer.bunifuCustomLabel1.Text = "Update Sponser";
            sponcer.bunifuCustomLabel2.Text = "Update Spocer Name";
            upsert.Controls.Add(sponcer);
            upsert.Show();
        }

        private void Sponcerdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Sponcerdgv.CurrentRow.Cells[0].Value.ToString();
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                    string sql = "Delete from Sponcer Where ID='" + id + "'";
                    com = new SqlCommand(sql, connection);
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Sponcer Deleted!! Please refresh the grid.");
                    }
                    else
                    {
                        MessageBox.Show("Sponcer Not Deleted. Please try again later.");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Schoolrefreshbtn_Click(object sender, EventArgs e)
        {
            school();
            Schooldgv.Refresh();
        }

        private void Schoolinsbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            School school = new School();
            school.Location = new Point(0, 0);
            school.bunifuCustomLabel2.Text = "Create School";
            upsert.Controls.Add(school);
            upsert.Show();
        }

        private void Schoolupdbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            School school = new School();
            school.Location = new Point(Left, Top);
            school.bunifuCustomLabel2.Text = "Update School";
            school.nmtxt.Text = Schooldgv.CurrentRow.Cells[1].Value.ToString();
            school.loctxt.Text = Schooldgv.CurrentRow.Cells[2].Value.ToString();
            school.faccmd.SelectedItem(Schooldgv.CurrentRow.Cells[3].Value.ToString());
            school.posttxt.Text = Schooldgv.CurrentRow.Cells[4].Value.ToString();
            school.typcmd.SelectedItem(Schooldgv.CurrentRow.Cells[5].Value.ToString());
            school.feestxt.Text = Schooldgv.CurrentRow.Cells[6].Value.ToString();
            school.id = Schooldgv.CurrentRow.Cells[0].Value.ToString();
            upsert.Controls.Add(school);
            upsert.Show();
        }

        private void Schooldelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string delete = "Delete from School where ID=@id";
                    com = new SqlCommand(delete, connection);
                    com.Parameters.Add(new SqlParameter("@id", Schooldgv.CurrentRow.Cells[0].Value.ToString()));
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("School Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete school, Please try again later.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Classinsbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            Class lass= new Class();
            lass.Location = new Point(0, 0);
            lass.bunifuCustomLabel2.Text = "Create Class";
            lass.Insertbtn.BringToFront();
            upsert.Controls.Add(lass);
            upsert.Show();
        }

        private void Classupdbtn_Click(object sender, EventArgs e)
        {
            Upsert upsert = new Upsert();
            Class lass = new Class();
            lass.Location = new Point(0, 0);
            lass.bunifuCustomLabel2.Text = "Update Class";
            lass.nmcmd.SelectedItem(Classdgv.CurrentRow.Cells[1].Value.ToString());
            lass.nmtxt.Text = Classdgv.CurrentRow.Cells[4].Value.ToString();
            lass.id = Classdgv.CurrentRow.Cells[0].Value.ToString();
            lass.Updatebtn.BringToFront();
            upsert.Controls.Add(lass);
            upsert.Show();
        }

        private void Classdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                    string delete = "Delete from Classes where ID=@id";
                    com=new SqlCommand(delete, connection);
                    com.Parameters.Add(new SqlParameter("@id", Classdgv.CurrentRow.Cells[0].ToString()));
                    var res = com.ExecuteNonQuery();
                    if (res != 0)
                    {
                        MessageBox.Show("Class Deleted successfully!!");
                    }
                    else
                    {
                        MessageBox.Show("Class not deleted!! Please try again later.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Classrefreshbtn_Click(object sender, EventArgs e)
        {
            lass();
            Classdgv.Refresh();
        }

        private void Studentpribtn_Click(object sender, EventArgs e)
        {

        }

        private void Studentupdbtn_Click(object sender, EventArgs e)
        {

        }

        private void Studentdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                    string delete = "Delete from student where ID=@id";
                    com=new SqlCommand(delete, connection);
                    com.Parameters[0].Value = studentdgv.CurrentRow.Cells[0].Value.ToString();
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Student Deleted successfully!! Please refresh the Grid.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Studentrefreshbtn_Click(object sender, EventArgs e)
        {
            student();
            studentdgv.Refresh();
        }
    }
}
