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
            Studentdgv.SetPage("Home");
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
                    string sql = "Select * from Sponcer";
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
            Studentdgv.SetPage("Sponcer");
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
            Studentdgv.SetPage("Schools");
            headinglbl.Text = "Sponcer System\\Schools";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\school_house_60px.png");
            Image.Image = img;
            school();
        }

        private void Classbtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Class");
            headinglbl.Text = "Sponcer System\\Class";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\classroom_64px.png");
            Image.Image = img;
        }

        private void Studentbtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Student");
            headinglbl.Text = "Sponcer System\\Students";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\student_male_48px.png");
            Image.Image = img;
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Settings");
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
            school.Location = new Point(Left, Top);
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
    }
}
