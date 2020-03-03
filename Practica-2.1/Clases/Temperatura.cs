using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1.Clases
{
    class Temperatura
    {
		//Atributo y Propiedad
		private double gCentigrados;

		public double GCentigrados
		{
			get { return gCentigrados; }
			set { gCentigrados = value; }
		}
		// Constructor
		public Temperatura(double gCentigrados) {
			this.gCentigrados = gCentigrados;
		}
		// Metodo
		public double ConvertirAFarenheit()
		{
			return (9 * gCentigrados / 5) + 32;
		}

	}
}
