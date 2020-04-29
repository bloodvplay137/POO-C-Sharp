using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Ej4_2 : Form
    {
        EmpleadoSinHorasExtras eshe;
        EmpleadoConHorasDobles echd;
        EmpleadoConHorasTriples echt;
        public Ej4_2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horasTrabajadas = int.Parse(txtHoras.Text);
            double sueldoPorHora = double.Parse(txtSueldo.Text);
            if (horasTrabajadas < 41)
            {
                eshe = new EmpleadoSinHorasExtras();
                eshe.HorasTrabajadas = horasTrabajadas;
                eshe.SueldoPorHora = sueldoPorHora;
                MessageBox.Show($"Horas trabajadas:    {eshe.HorasTrabajadas} \nSueldo por hora: ${eshe.SueldoPorHora} \nSalario: ${eshe.CalcularSalario()}", "Empleado sin horas extras");

            }
            else if (horasTrabajadas < 46)
            {
                echd = new EmpleadoConHorasDobles();
                echd.HorasTrabajadas = horasTrabajadas;
                echd.SueldoPorHora = sueldoPorHora;
                MessageBox.Show($"Horas trabajadas:  {echd.HorasTrabajadas} \nSueldo por hora: ${echd.SueldoPorHora} \nHoras extras: {echd.HorasTrabajadas - 40} \nSalario: ${echd.CalcularSalario()}", "Empleado con horas dobles");
            }
            else
            {
                echt = new EmpleadoConHorasTriples();
                echt.HorasTrabajadas = horasTrabajadas;
                echt.SueldoPorHora = sueldoPorHora;
                MessageBox.Show($"Horas trabajadas:  {echt.HorasTrabajadas} \nSueldo por hora: ${echt.SueldoPorHora} \nHoras extras: {echt.HorasTrabajadas - 40} \nSalario: ${echt.CalcularSalario()}", "Empleado con horas triples");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
