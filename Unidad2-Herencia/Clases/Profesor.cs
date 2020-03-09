using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia
{
    class Profesor : Persona
    {
		private double sueldo;

		public double Sueldo
		{
			get { return sueldo; }
			set { sueldo = value; }
		}
		public string Ensenar()
		{
			return "ensenando";
		}
	}
}
