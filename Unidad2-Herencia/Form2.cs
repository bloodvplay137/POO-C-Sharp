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
            unCliente = new Cliente();
            unCliente.Nombre = textBox1.Text;
            unCliente.FechaNacimiento = dateTimePicker1.Value;
            bool mayor = unCliente.EsMayorEdad();
            MessageBox.Show($"Mayor de edad = {mayor}");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
