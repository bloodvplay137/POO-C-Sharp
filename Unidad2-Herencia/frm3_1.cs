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
        // Variable que cuenta los elementos del listbox
        int mesCD = 1, mesLibro = 1;

        public frm3_1()
        {
            InitializeComponent();
        }

        private void rdbLibro_CheckedChanged(object sender, EventArgs e)
        {
            txtTiempo.Enabled = false;
            txtNumPaginas.Enabled = true;
            lsbVentasLibro.Visible = true;
            lsbVentasCD.Visible = false;
        }

        private void rdbCD_CheckedChanged(object sender, EventArgs e)
        {
            txtNumPaginas.Enabled = false;
            txtTiempo.Enabled = true;
            lsbVentasCD.Visible = true;
            lsbVentasLibro.Visible = false;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // validamos  en que mes estamos y en base a eso mostramos el texto en el boton 
            agregarMes();
        }

        private void frm3_1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            if (rdbLibro.Checked)
            {
                switch (mesLibro)
                {
                    case 1: btnAgregar.Text = "Enero"; break;
                    case 2: btnAgregar.Text = "Febrero"; break;
                    case 3: btnAgregar.Text = "Marzo"; break;
                    default: btnAgregar.Enabled = false; break;
                }
            }
            else
            {
                switch (mesCD)
                {
                    case 1: btnAgregar.Text = "Enero"; break;
                    case 2: btnAgregar.Text = "Febrero"; break;
                    case 3: btnAgregar.Text = "Marzo"; break;
                    default: btnAgregar.Enabled = false; break;
                }
            }
            
        }
        void agregarMes()
        {
            
            if (rdbLibro.Checked)
            {
                // agregamos el vaor del textbox al arreglo
                libro[mesLibro-1] = double.Parse(txtVentas.Text);
                //agregamos el valor del textbox al listbox
                lsbVentasLibro.Items.Add(txtVentas.Text);
                mesLibro++;
            }
            else
            {
                // agregamos el vaor del textbox al arreglo
                cd[mesCD-1] = double.Parse(txtVentas.Text);
                //agregamos el valor del textbox al listbox
                lsbVentasCD.Items.Add(txtVentas.Text);
            }
            //limpiamos el textbox y nos posicionamos de nuevo en el con el curso.
            txtVentas.Clear();
            txtVentas.Focus();
            // aumentar contador
            mesCD++;
        }
    }
}
