using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class CD: Publicacion
    {
		// atributo y propiedad
		private double _dblTiempoRep;

		public double TiempoRep
		{
			get { return _dblTiempoRep; }
			set { _dblTiempoRep = value; }
		}
		//sobreescritura del metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"\nTiempo de Reproduccion: {_dblTiempoRep}";
		}

	}
}
