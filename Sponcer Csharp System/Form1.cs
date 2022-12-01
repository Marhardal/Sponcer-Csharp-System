﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sponcer_Csharp_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Home");
            headinglbl.Text = "Sponcer System\\Home";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\home_60px.png");
            Image.Image = img;
        }

        private void Sponcerbtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Sponcer");
            headinglbl.Text = "Sponcer System\\Sponcer";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\parenting_50px.png");
            Image.Image = img;
        }

        private void Schoolbtn_Click(object sender, EventArgs e)
        {
            Studentdgv.SetPage("Schools");
            headinglbl.Text = "Sponcer System\\Schools";
            Image img = System.Drawing.Image.FromFile(Application.StartupPath + @"\Icons\school_house_60px.png");
            Image.Image = img;
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

        }

        private void Sponcerpribtn_Click(object sender, EventArgs e)
        {

        }
    }
}
