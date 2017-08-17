using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccl.View.Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cliente1.Visible = true;
            colmado1.Visible = false;
            
           
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            colmado1.Visible = true;
            cliente1.Visible = false;
            colmado1.Location = cliente1.Location;
        }

        private void colmado1_Load(object sender, EventArgs e)
        {

        }
    }
}
