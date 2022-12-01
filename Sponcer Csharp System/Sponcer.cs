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
    public partial class Sponcer : UserControl
    {
        public Sponcer()
        {
            InitializeComponent();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Parent.Hide();
            MessageBox.Show("Sponcer Successfully Entered!! Don't forget to refresh the grid.");
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Hide();
            Parent.Hide();
            MessageBox.Show("Sponcer Successfully Updated!! Don't forget to refresh the grid.");
        }
    }
}
