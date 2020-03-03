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
    public partial class ejercicio5 : Form
    {
        Fecha fecha1, fecha2;
        
        public ejercicio5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFechaHoy_Click(object sender, EventArgs e)
        {
            fecha1 = new Fecha();
            MessageBox.Show("Fecha creada correctamente.","Fecha",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnFechaUsuario_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtDia.Text == "" || txtMes.Text == "") {
                MessageBox.Show("Favor de Capturar valores enteros en los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            int dia, mes, anio;
            dia = int.Parse(txtDia.Text);
            mes = int.Parse(txtMes.Text);
            anio = int.Parse(txtAnio.Text);
            if (ValidarFecha(dia, mes, anio)==true)
            {
                fecha2 = new Fecha(dia, mes, anio);
                MessageBox.Show("Fecha creada correctamente.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                fecha2 = new Fecha();
                MessageBox.Show("La fecha es incorrecta, por lo tanto se creara con fecha del dia de hoy.", "Fecha", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            
            
        }

        private void btnConsultarFechaHoy_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{fecha1.ConsultarFecha()}","Consultar Fecha",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnConsultarFechaUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{fecha2.ConsultarFecha()}", "Consultar Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ejercicio5_Load(object sender, EventArgs e)
        {
        }
        bool ValidarFecha(int dia, int mes, int anio)
        {
            // para saber si mi mes es par
            bool mesPar;
            if (mes % 2 == 0) mesPar = true;
            else mesPar = false;
            // para saber si es febrero 
            bool febrero;
            if (mes == 2) febrero = true;
            else febrero = false;
            // para saber si mi  mi año es bisiesto
            bool bisiesto;
            if (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }

            // si el año NO es bisiesto y el dia es menor a 0 o mayor a 28, entonces esta mal la fecha
            if (bisiesto && febrero && dia <= 0 && dia > 28)
            {
                return false;
            }
            // si el año es bisiesto y  el dia es mayor a  29, enotnces la fecha esta mal
            if (bisiesto && febrero && dia <= 0 && dia > 29) { 
                return false; 
            }
            // si no es febrero y es mes par y dia es mayor a 30 entonces la fecha esta mal
            if (febrero && mesPar && dia <= 0 && dia > 30)
            {
                return false;
            }
            // si no es febrero y no es mes par y dia mayor a 31
            if (febrero == false && mesPar == false && dia <= 0 && dia > 31) return false;

            // si mes no esta ente 1 y 12 esta mal
            if (mes <= 0 && mes > 12) return false;
            // si año no es menor que 0 esta mal
            if (anio <= 0) return false;

            return true;
        }
    }
}
