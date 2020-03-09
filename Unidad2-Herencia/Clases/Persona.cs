using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia
{
    class Persona
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public string Asistir()
		{
			return "Asistio";
		}
	}
}
