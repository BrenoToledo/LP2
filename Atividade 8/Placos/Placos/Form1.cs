using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 objEx1 = new frmExercicio1();
            objEx1.MdiParent= this;
            objEx1.WindowState= FormWindowState.Maximized;
            objEx1.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objEx2 = new frmExercicio2();
            objEx2.MdiParent = this;
            objEx2.WindowState = FormWindowState.Maximized;
            objEx2.Show();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objEx3 = new frmExercicio3();
            objEx3.MdiParent = this;
            objEx3.WindowState = FormWindowState.Maximized;
            objEx3.Show();
        }

        private void ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objEx4 = new frmExercicio4();
            objEx4.MdiParent = this;
            objEx4.WindowState = FormWindowState.Maximized;
            objEx4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
