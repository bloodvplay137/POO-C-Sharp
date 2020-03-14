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
    public partial class frm3_1 : Form
    {
        Libro libro;
        CD cd;
        public frm3_1()
        {
            InitializeComponent();
        }

        private void rdbLibro_CheckedChanged(object sender, EventArgs e)
        {
            txtTiempo.Enabled = false;
            txtNumPaginas.Enabled = true;
        }

        private void rdbCD_CheckedChanged(object sender, EventArgs e)
        {
            txtNumPaginas.Enabled = false;
            txtTiempo.Enabled = true;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string strTitulo = txtTitulo.Text;
            double dblPrecio = double.Parse(txtPrecio.Text);
            if (radioChecked())
            {
                libro = new Libro();
                libro.Titulo = strTitulo;
                libro.Precio = dblPrecio;
                libro.NumPaginas = int.Parse(txtNumPaginas.Text);
            }
            else
            {
                cd = new CD();
                cd.Titulo = strTitulo;
                cd.Precio = dblPrecio;
                cd.TiempoRep = double.Parse(txtTiempo.Text);
            }
            clear();
        }
        bool radioChecked()
        {
            if (rdbLibro.Checked)
            { return true;}
            else { return false; }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (radioChecked())
            {
                MessageBox.Show(libro.ToString());
            }
            else 
            {
                MessageBox.Show(cd.ToString());
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clear()
        {
            foreach (Control text in gpbDatos.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = "";
                }
            }
        }
    }
}
