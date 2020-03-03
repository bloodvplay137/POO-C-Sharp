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
    public partial class frmE6 : Form
    {
        Articulo articulo;
        public frmE6()
        {
            InitializeComponent();
        }

        private void frmE6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clave = int.Parse(txtClave.Text);
            string descripcion = txtDesc.Text;
            double precio = double.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            articulo = new Articulo(clave,descripcion,precio,cantidad);
            LimpiarControles();
            MessageBox.Show($"Articulo credo Correctamente, los datos de su articulo son los siguientes: \n\nCalve: \t\t{articulo.Clave}\nDescripcion: \t{articulo.Descripcion}\nPrecio: \t\t${articulo.Precio}\nCantidad: \t{articulo.Cantidad}","Crear Articulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show($"El iva de su articulo (8%) es de ${articulo.CalcularIVA()}","IVA", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LimpiarControles()
        {
            foreach(TextBox text in gpbArticulo.Controls)
            {
                text.Clear();
            }
            /*txtClave.Clear();
            txtDesc.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();*/
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
