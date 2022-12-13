using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                    dt.Dispose();
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
            Profile();
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
                    string sql = "Delete from Sponser Where ID='" + id + "'";
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
                    connection.Close();
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

        internal string id;

        void Profile()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from users where Username=@usnm";
                    com = new SqlCommand(select, connection);
                    com.Parameters.Add(new SqlParameter("usnm", usnmtxt.Text));
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        id = sqlData[0].ToString();
                        usnmlbl.Text = sqlData[1].ToString();
                        passlbl.Text = sqlData[2].ToString();
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

        private void profbtn_Click(object sender, EventArgs e)
        {
            Profile();
            sett.SetPage("Profile");
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            sett.SetPage("About");
        }

        void Users()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from users";
                    com=new SqlCommand(select, connection);
                    SqlDataAdapter sqlData= new SqlDataAdapter(com);
                    DataTable dataTable= new DataTable();
                    sqlData.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        userdgv.DataSource = dataTable;
                    }
                    dataTable.Dispose();
                    sqlData.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void usrcount()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select count(*) from Users";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData=com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        usrcntlbl.Text = sqlData[0].ToString() + "Users have regidtered and use this system.";
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

        private void usrbtn_Click(object sender, EventArgs e)
        {
            Users();
            usrcount();
            sett.SetPage("Users");
        }

        void read()
        {
            try
            {
                string about = "./CompanyInfo.txt";
                if (File.Exists(about))
                {
                    nmtxt.Text = File.ReadLines(about).ElementAtOrDefault(0);
                    loctxt.Text = File.ReadLines(about).ElementAtOrDefault(1);
                    postxt.Text = File.ReadLines(about).ElementAtOrDefault(2);
                    phnotxt.Text = File.ReadLines(about).ElementAtOrDefault(3);
                    imgtxt.Text = File.ReadLines(about).ElementAtOrDefault(4);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void compbtn_Click(object sender, EventArgs e)
        {
            sett.SetPage("Company");
            read();
        }

        private void bakbtn_Click(object sender, EventArgs e)
        {
            sett.SetPage("Backup");
        }

        private void usrinsbtn_Click(object sender, EventArgs e)
        {
            User user= new User();
            user.Insertbtn.BringToFront();
            user.Show();
        }

        void cntspncr()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select count(*) as Sponcers from Sponser;";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        spncrlbl.Text = sqlData[0].ToString() + " sponcers are registered and sponcering many students.";
                    }
                    sqlData.Close();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Failed to count sponcers " + er.Message);
            }
        }

        void cntschl()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select count(*) from school";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        cntschlbl.Text = sqlData[0].ToString() + " schools have students sponced by us.";
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

        int stdnt;
        void cntstdnt()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select count(*) from student";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        cntstdntlbl.Text = sqlData[0].ToString() + " students have been registed.";
                        stdnt = Convert.ToInt32(sqlData[0].ToString());
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

        void piechart()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select top 4 spo.Name, COUNT(stu.ID) as [Total Students] from Student as stu, Sponser as spo where stu.[Sponser ID]=spo.ID GROUP BY spo.Name ";
                    com=new SqlCommand(select, connection);
                    SqlDataAdapter sqlData = new SqlDataAdapter(com);
                    DataSet set = new DataSet();
                    sqlData.Fill(set);
                    chart1.DataSource = set;
                    chart1.Series[0].XValueMember = "Name";
                    chart1.Series[0].YValueMembers = "Total Students";
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    chart1.Titles.Add("Sponcer's with Total students sponcered.");
                    chart1.Series[0].IsValueShownAsLabel = true;
                    sqlData.Dispose();
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cntspncr();
            cntschl();
            cntstdnt();
            cntpri();
            cntcol();
            cntsec();
            timer1.Start();
            User.usnm = usnmtxt.Text;
            nmlbl.Text = File.ReadLines("./Companyinfo.txt").First();
            string path = File.ReadLines("./Companyinfo.txt").ElementAtOrDefault(4);
            Image img = System.Drawing.Image.FromFile(path);
            logo.Image = img;
            Primarybar.Minimum = 0;
            Primarybar.Maximum = stdnt;
            Primarybar.Value = Convert.ToInt32(primary);
            Secondarybar.Minimum = 0;
            Secondarybar.Maximum = stdnt;
            Secondarybar.Value = Convert.ToInt32(secondary);
            Collegebar.Minimum = 0;
            Collegebar.Maximum = stdnt;
            Collegebar.Value = Convert.ToInt32(college);
            primarylbl.Text = "Out of " + stdnt + ", a total of " + primary + " are primary school students.";
            Secondarylbl.Text = "Out of " + stdnt + ", a total of " + secondary + " are secondary school students.";
            Tertiallylbl.Text = "Out of " + stdnt + ", a total of " + college + " are tertially students.";
            piechart();
        }

        string primary;
        string secondary;
        string college;

        void cntpri()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select COUNT(*) from Student as stu, School xul where stu.[School ID]=xul.ID and xul.Faculty='Primary';";
                    com=new SqlCommand(select, connection);
                    SqlDataReader sqlData= com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        primary = sqlData[0].ToString();
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

        void cntsec()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select COUNT(*) from Student as stu, School xul where stu.[School ID]=xul.ID and xul.Faculty='Secondary';";
                    com = new SqlCommand(select, connection);
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        secondary = sqlData[0].ToString();
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

        void cntcol()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "select COUNT(*) from Student as stu, School xul where stu.[School ID]=xul.ID and xul.Faculty='Tertially';";
                    com = new SqlCommand(select, connection);
                    SqlDataReader sqlData = com.ExecuteReader();
                    if (sqlData.HasRows)
                    {
                        sqlData.Read();
                        college = sqlData[0].ToString();
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


        private void usrupdbtn_Click(object sender, EventArgs e)
        {
            User user=new User();
            user.updatebtn.BringToFront();
            user.id = id;
            user.usnmtxt.Text = usnmtxt.Text;
            user.passtxt.Text = passlbl.Text;
            user.Show();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure that you want logout.", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            Users();
            sett.SetPage("users");
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void bakbrowbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder=new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                backuptxt.Text = folder.SelectedPath;
            }
        }

        private void bakupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string database = connection.Database.ToString();
                if (backuptxt.Text == "")
                {
                    MessageBox.Show("Please make sure you select a location to save the backup file.");
                }
                else
                {
                    string name = "BACKUP DATABASE [" + database + "] TO DISK = '" + backuptxt.Text + "\\" + "sponcer_database" + "_" + DateTime.Now.ToString("yyyy-M-dd--HH-mm-ss") + ".bak'";
                    connection.Open();
                    com = new SqlCommand(name, connection);
                    var res = com.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Backup created successfuly.");
                    }
                    else
                    {
                        MessageBox.Show("Backup failed. Please try again later.");
                    }
                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void resbrobtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.AddExtension = true;
                openFile.Filter = "Backup file (*.bak)|*.bak";
                openFile.Title = "Select Backup File to Restore.";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    restxt.Text = openFile.FileName;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void restbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string database = connection.Database.ToString();
                    string alter = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    com = new SqlCommand(alter, connection);
                    com.ExecuteNonQuery();
                    string use = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + restxt.Text + "' WITH REPLACE;";
                    com = new SqlCommand(use, connection);
                    com.ExecuteNonQuery();
                    string alter1 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    com = new SqlCommand(alter1, connection);
                    var res2 = com.ExecuteNonQuery();
                    if (res2 > 0)
                    {
                        MessageBox.Show("Database restored successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Database not restored.");
                    }

                    connection.Close();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string about = "./CompanyInfo.txt";
                if (File.Exists(about))
                {
                    //StreamWriter writer = new StreamWriter(about);
                    string[] lines = new string[5];
                    lines[0] = nmtxt.Text;
                    lines[1] = postxt.Text;
                    lines[2] = loctxt.Text;
                    lines[3] = phnotxt.Text;
                    lines[4] = imgtxt.Text;
                    File.WriteAllLines(about, lines);
                    //writer.Write(lines);
                    //writer.Close();
                    MessageBox.Show("File Exist");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        

        private void slctbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG Files(*.png)|*.png|JPEG Files(*.jpeg)|*.jpeg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgtxt.Text = openFile.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Primarybar.Value = Convert.ToInt32(primary);
                Secondarybar.Value = Convert.ToInt32(secondary);
                Collegebar.Value = Convert.ToInt32(college);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
