using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    abstract class Publicacion
    {
		private string _strTitulo;

		public string Titulo
		{
			get { return _strTitulo; }
			set { _strTitulo = value; }
		}
		private double _dblPrecio;

		public double Precio
		{
			get { return _dblPrecio; }
			set { _dblPrecio = value; }
		}
		double[] arrVentas = new double[3];
		public double this[int intCelda]{
			get{ return arrVentas[intCelda]; }
			set { arrVentas[intCelda] = value; }
		}
	}
}
