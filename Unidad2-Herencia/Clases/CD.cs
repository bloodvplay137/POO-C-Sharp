using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class CD: Publicacion
    {
		private double _dblTiempoRep;

		public double TiempoRep
		{
			get { return _dblTiempoRep; }
			set { _dblTiempoRep = value; }
		}
		public override string ToString()
		{
			return $"Titulo: {Titulo}\nPrecio: {Precio}\n{_dblTiempoRep}";
		}

	}
}
