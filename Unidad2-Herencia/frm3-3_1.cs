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
    public partial class frm3_3_1 : Form
    {
        //List<Automovil> listaAutomoviles;
        Automovil auto;
        Motor motor;
        Puerta puerta;
        Llanta llanta;
        

        public frm3_3_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm3_3_1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            auto = new Automovil();
            auto.Marca = txtMarca.Text;
            auto.Modelo = txtModelo.Text;
            auto.Anio = int.Parse(txtAnio.Text);
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
           }
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            motor = new Motor();
            motor.NS = txtNS.Text;
            motor.Cilindros = int.Parse(txtCilindros.Text);
            auto.ParteMotor = motor;
            txtMotor.Text = motor.ToString();
            txtMotor.Enabled = false;
            btnMotor.Enabled = false;
        }

        private void btnLlantas_Click(object sender, EventArgs e)
        {
            llanta = new Llanta();
            llanta.Marca = txtMarcaL.Text;
            llanta.Modelo = txtModeloL.Text;
            llanta.Tamanio = int.Parse(txtTamanioL.Text);
            auto.InsertarLlanta(llanta);
            MostrarLlantas();   
        }
        
        void MostrarLlantas()
        {
            lsbLlantas.Items.Clear();
            
            foreach (Llanta llanta in auto.ListaLlantas)
            {
                lsbLlantas.Items.Add(llanta.ToString());
            }
            foreach (Control t in tabPage1.Controls)
            {
                if (t is TextBox)
                {
                    t.ResetText();
                }
            }
            txtMarcaL.Focus();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPuertas_Click(object sender, EventArgs e)
        {
            int suma = 0;
            puerta = new Puerta();
            puerta.Tipo = int.Parse(txtTipoP.Text);
            auto.InsertarPuerta(puerta);
            foreach (Puerta puerta in auto.ListaPuertas)
            {
                suma = suma + puerta.Tipo;
                suma += puerta.Tipo;
            }
            MostrarPuertas();
        }
        void MostrarPuertas()
        {
            // borra todos los elementos del listbox
            lsbPuertas.Items.Clear();
            // itera la lista de puertas dentro de nuestro auto 
            foreach (Puerta puerta in auto.ListaPuertas)
            {
                // inserta cada puerta que esta en la lista de puertas de nuestro objeto auto
                lsbPuertas.Items.Add(puerta.ToString());
            }
            txtTipoP.Clear();
            txtTipoP.Focus();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string res = $"{auto.ToString()}\n";
            res += "Llantas: \n";
            foreach (Llanta llanta in auto.ListaLlantas)
            {
                res += $"{llanta.ToString()}\n";
            }
            res += "Puertas: \n";
            foreach (Puerta puerta in auto.ListaPuertas)
            {
                res += $"{puerta.ToString()}\n";
            }
            MessageBox.Show(res, "Automovil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
