using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou ctrl+c");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou ctrl+v");
        }

        private void Exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio2 form2 = new FrmExercicio2();
            form2.MdiParent = this;
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio3 form3 = new FrmExercicio3();
            form3.MdiParent = this;
            form3.WindowState = FormWindowState.Maximized;
            form3.Show();
        }

        private void Exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio4 form4 = new FrmExercicio4();
            form4.MdiParent = this;
            form4.WindowState = FormWindowState.Maximized;
            form4.Show();
        }

        private void Exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio5 form5 = new FrmExercicio5();
            form5.MdiParent = this;
            form5.WindowState = FormWindowState.Maximized;
            form5.Show();
        }
    }
}
