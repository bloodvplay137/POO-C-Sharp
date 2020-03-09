using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class CD: Publicacion
    {
		private int _intTiempo;

		public int Tiempo
		{
			get { return _intTiempo; }
			set { _intTiempo = value; }
		}

	}
}
