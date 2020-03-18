using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Camioneta:Vehiculo
    {
		// constructor
		public Camioneta(string strNS, string strMarca, int intAnio, double dblPrecio, double dblCapacidadCarga, int intCantidadEjes) : base(strNS, strMarca, intAnio, dblPrecio)
		{
			_intCantidadEjes = intCantidadEjes;
		}
		// atributos y propiedades
		private double _dblCapacidadCarga;

		public double CapacidadCarga
		{
			get { return _dblCapacidadCarga; }
			set { _dblCapacidadCarga = value; }
		}
		private int _intCantidadEjes;

		public int CantidadEjes
		{
			get { return _intCantidadEjes; }
			set { _intCantidadEjes = value; }
		}
		// sobreescritura metodo ToString
		public override string ToString()
		{
			return base.ToString()+ $"\nCapacidad de Carga: {_dblCapacidadCarga}\nCantidad de Ejes: {_intCantidadEjes}";
		}


	}
}
