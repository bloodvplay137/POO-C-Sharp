using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_Herencia
{
    public partial class Form1 : Form
    {
        Estudiante estudiante;
        Profesor profesor;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm3_1 frm = new frm3_1();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmEj5 frm = new frmEj5();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEj7 frm = new frmEj7();
            frm.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmEjListas frm = new frmEjListas();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm3_3_1 frm = new frm3_3_1();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmEj1P3_2 frm = new frmEj1P3_2();
            frm.Show();
        }
    }
}
