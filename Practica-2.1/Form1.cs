using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ejercicio5 form = new ejercicio5();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmE6 form = new frmE6();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmE7 form = new frmE7();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmE8 form = new frmE8();
            form.Show();
        }
    }
}
