using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class EmpleadoConHorasTriples: Empleado
    {
        public override double CalcularSalario()
        {
            int intHorasExtras = HorasTrabajadas - 40;
            double dblSueldoExtra = intHorasExtras * SueldoPorHora * 3;
            double dblSueldoNormal = 40 * SueldoPorHora;

            return dblSueldoNormal + dblSueldoExtra;
        }
    }
}
