using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_3_4
{
    public partial class frmCalcularTiempo : Form
    {
        //Objeto
        Rectangulo pared = new Rectangulo();

        public frmCalcularTiempo()
        {
            InitializeComponent();
        }

        private void frmCalcularTiempo_Load(object sender, EventArgs e)
        {

        }
        double CalcularTiempo()
        {
            /*
             * 1m**2 = 10 min
             * area = ?
             * aplicar regla de 3 simple...
             */
            return pared.CalcularArea() * 10;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El area de su pared es de: {pared.CalcularArea()}m^2 y el tiempo que le llevara pintar su pared es de: {CalcularTiempo()} minutos","Area",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (txtLargo.Text == "" || txtAncho.Text == "")
            {
                MessageBox.Show("Favor de capturar ambos datos.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                pared.Largo = double.Parse(txtLargo.Text);
                lblLargo.Text = $"Largo Actual: {pared.Largo}";
                txtLargo.Clear();
                pared.Ancho = double.Parse(txtAncho.Text);
                lblAncho.Text = $"Ancho Actual: {pared.Ancho}";
                txtAncho.Clear();
            }
        }
    }
}
