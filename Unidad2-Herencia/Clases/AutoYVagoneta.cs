using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class AutoYVagoneta: Vehiculo
    {
		// constructor
		public AutoYVagoneta(string strNS, string strMarca, int intAnio, double dblPrecio, int intCantPasajeros) : base(strNS,strMarca,intAnio,dblPrecio)
		{
			_intCantPasajeros = intCantPasajeros;
		}
		// atributos y propiedades
		private int _intCantPasajeros;

		public int CantPasajeros
		{
			get { return _intCantPasajeros; }
			set { _intCantPasajeros = value; }
		}
		// sobreescritura metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"\nCantidad de Pasajeros: {_intCantPasajeros}";
		}

	}
}
