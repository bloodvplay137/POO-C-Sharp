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
    public partial class frmEj7 : Form
    {
        Pitcher pitcher;
        DePosicion dePosicion;
        Bateador bateador;
        public frmEj7()
        {
            InitializeComponent();
        }

        private void frmEj7_Load(object sender, EventArgs e)
        {

        }
        void limpiarTextBoxes()
        {
            foreach (Control txt in gpbDatos.Controls)
            {
                if (txt is TextBox)
                {
                    txt.ResetText();
                }
            }
        }
        void TextBoxesEnabled() 
        {
            if (rdbBateador.Checked)
            {
                txtErrores.Enabled = false;
                txtPonches.Enabled = false;
                txtHits.Enabled = true;
            }
            else if (rdbDePosicion.Checked)
            {
                txtErrores.Enabled = true;
                txtPonches.Enabled = false;
                txtHits.Enabled = false;
            }
            else if (rdbPitcher.Checked)
            {
                txtErrores.Enabled = true;
                txtPonches.Enabled = true;
                txtHits.Enabled = false;
            }
        }

        private void rdbPitcher_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnabled();
        }

        private void rdbDePosicion_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnabled();
        }

        private void rdbBateador_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxesEnabled();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            //variables locales
            int intNum = int.Parse(txtNum.Text);
            string strNombre = txtNombre.Text;
            if (rdbBateador.Checked)
            {
                int intHits = int.Parse(txtHits.Text); 
                bateador = new Bateador(intNum,strNombre,intHits);
            }
            else if (rdbDePosicion.Checked || rdbPitcher.Checked)
            {
                int intErrores = int.Parse(txtErrores.Text);
                if (rdbDePosicion.Checked)
                {
                    dePosicion = new DePosicion(intNum, strNombre, intErrores);
                }
                if (rdbPitcher.Checked)
                {
                    int intPonches = int.Parse(txtPonches.Text);
                    pitcher = new Pitcher(intNum,strNombre,intErrores,intPonches);
                }
                
            }
            limpiarTextBoxes();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rdbBateador.Checked)
            {
                MessageBox.Show(bateador.ToString());
            }
            if (rdbDePosicion.Checked)
            {
                MessageBox.Show(dePosicion.ToString());
            }
            if (rdbPitcher.Checked)
            {
                MessageBox.Show(pitcher.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
