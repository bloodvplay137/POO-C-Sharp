using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class EmpleadoSinHorasExtras: Empleado
    {
        public override double CalcularSalario()
        {
            return base.CalcularSalario();
        }
    }
}
