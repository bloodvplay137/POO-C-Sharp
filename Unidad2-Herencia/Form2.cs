using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_Herencia.Clases;


namespace Unidad2_Herencia
{
    public partial class Form2 : Form
    {
        Cliente unCliente;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unCliente = new Cliente(1500.56,dateTimePicker1.Value, textBox1.Text);
            
            bool mayor = unCliente.EsMayorEdad();
            MessageBox.Show(unCliente.ToString());
            Console.WriteLine(unCliente);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
