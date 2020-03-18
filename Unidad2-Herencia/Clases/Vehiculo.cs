using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    abstract class Vehiculo
    {
		//constructor
		public Vehiculo(string strNS, string strMarca, int intAnio, double dblPrecio)
		{
			_strNS = strNS;
			_strMarca = strMarca;
			_intAnio = intAnio;
			_dblPrecio = dblPrecio;
		}
		//atributos y propiedades
		private string _strNS;

		public string NS
		{
			get { return _strNS; }
			set { _strNS = value; }
		}
		private string _strMarca;

		public string Marca
		{
			get { return _strMarca; }
			set { _strMarca = value; }
		}
		private int _intAnio;

		public int Anio
		{
			get { return _intAnio; }
			set { _intAnio = value; }
		}
		private double _dblPrecio;

		public double Precio
		{
			get { return _dblPrecio; }
			set { _dblPrecio = value; }
		}
		// sobreescritura del metodo  ToString()
		public override string ToString()
		{
			return $"Numero de Serie: {_strNS} \nMarca: {_strMarca} \nAño: {_intAnio} \nPrecio: {_dblPrecio}";
		}

	}
}
