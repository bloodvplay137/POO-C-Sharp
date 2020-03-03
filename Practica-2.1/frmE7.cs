using Practica_2._1.Clases;
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
    public partial class frmE7 : Form
    {
        Temperatura temperatura;
        public frmE7()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double gCentigrados;
            gCentigrados = double.Parse(txtCentigrados.Text);
            temperatura = new Temperatura(gCentigrados);
            txtCentigrados.Clear();
            double gFarenheit;
            gFarenheit = temperatura.ConvertirAFarenheit();
            MessageBox.Show($"La temperatura en grados farenheit es {gFarenheit}º");
            
        }
    }
}
