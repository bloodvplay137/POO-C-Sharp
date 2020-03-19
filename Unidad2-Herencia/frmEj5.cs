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
    public partial class frmEj5 : Form
    {
        // declaracion de objetos globales
        AutoYVagoneta autoCompacto, autoDeLujo,vagoneta;
        Camioneta camioneta;
        public frmEj5()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        void TextBoxesEnable()
        {
            if (rdbCompacto.Checked || rdbDeLujo.Checked || rdbVagoneta.Checked)
            {
                txtCantPasajeros.Enabled = true;
                txtCapCarga.Enabled = false;
                txtCantEjes.Enabled = false;
            }else
            {
                txtCantPasajeros.Enabled = false;
                txtCapCarga.Enabled = true;
                txtCantEjes.Enabled = true;
            }
        }

        private void frmEj5_Load(object sender, EventArgs e)
        {

        }
        // metodo para limpiar textboxes
        void limpiarTextBoxes() 
        {
            foreach (Control txt in gpbDatos.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                }
            }
            foreach (Control txt in gpbDatosEspecificos.Controls)
            {
                if (txt is TextBox)
                {
                    txt.ResetText();
                }
            }
        }

        private void rdbCompacto_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnable();
        }

        private void rdbDeLujo_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnable();
        }

        private void rdbCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnable();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbCompacto.Checked)
            {
                MessageBox.Show(autoCompacto.ToString());
            }
            if (rdbDeLujo.Checked)
            {
                MessageBox.Show(autoDeLujo.ToString());
            }
            if (rdbVagoneta.Checked)
            {
                MessageBox.Show(vagoneta.ToString());
            }
            if (rdbCamioneta.Checked)
            {
                MessageBox.Show(camioneta.ToString());
            }

        }

        private void rdbVagoneta_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnable();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // varibales locales
            string strNS = txtNS.Text, strMarca = txtMarca.Text;
            int intAnio = int.Parse(txtAnio.Text);
            double dblPrecio = double.Parse(txtPrecio.Text);

            // creacion de objetos
            if (rdbCompacto.Checked || rdbDeLujo.Checked || rdbVagoneta.Checked)
            {
                int intCantPasajero = int.Parse(txtCantPasajeros.Text);
                if (rdbCompacto.Checked)
                {
                    autoCompacto = new AutoYVagoneta(strNS, strMarca, intAnio, dblPrecio, intCantPasajero);
                }
                if (rdbDeLujo.Checked)
                {
                    autoDeLujo = new AutoYVagoneta(strNS, strMarca, intAnio, dblPrecio, intCantPasajero);
                }
                if (rdbVagoneta.Checked)
                {
                    vagoneta = new AutoYVagoneta(strNS, strMarca, intAnio, dblPrecio, intCantPasajero);
                }
            }
            else
            {
               int intCantEjes = int.Parse(txtCantEjes.Text);
               double dblCapCarga = double.Parse(txtCapCarga.Text);
               camioneta = new Camioneta(strNS, strMarca, intAnio, dblPrecio, dblCapCarga, intCantEjes);
            }
            // limpiar textboxes
            limpiarTextBoxes();   
        }
    }
}
