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
    public partial class frmE8 : Form
    {
        CambioDivisas cambio;
        public frmE8()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            cambio = new CambioDivisas(18.0);
            cambio.Pesos = double.Parse(txtPesos.Text);
            MessageBox.Show( $" Recibo ${cambio.Pesos} Pesos  y entrego ${cambio.ConvertirADolares()} Dolares Americanos","Cambio de Divisas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }
    }
}
