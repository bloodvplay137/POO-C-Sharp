using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia
{
    class Estudiante: Persona
    {
		private int calificacion;

		public int Calificacion
		{
			get { return calificacion; }
			set { calificacion = value; }
		}
		public string Estudiar()
		{
			return "Estudiando";
		}

	}
}
