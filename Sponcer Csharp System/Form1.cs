using System;
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
            Pages.SetPage("Home");
        }

        private void Sponcerbtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Sponcer");
        }

        private void Schoolbtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage("School");
        }

        private void Classbtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Class");
        }

        private void Studentbtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Students");
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Settings");
        }
    }
}
