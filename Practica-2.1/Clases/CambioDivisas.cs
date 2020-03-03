using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1.Clases
{
    class CambioDivisas
    {
		// Atributos y Propiedades
		private double pesos;

		public double Pesos
		{
			get { return pesos; }
			set { pesos = value; }
		}
		private double tipocambio;

		public double TipoCambio
		{
			get { return tipocambio; }
			set { tipocambio = value; }
		}
		// Constructor
		public CambioDivisas(double tipocambio)
		{
			this.tipocambio = tipocambio;
		}
		//Metodo
		public double ConvertirADolares()
		{
			return Math.Round(pesos / tipocambio,2);
		}

	}
}
