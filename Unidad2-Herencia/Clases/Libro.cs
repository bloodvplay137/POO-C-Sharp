using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Libro: Publicacion
    {
		//atributo  y propiedad
		private int _intNumPaginas;

		public int NumPaginas
		{
			get { return _intNumPaginas; }
			set { _intNumPaginas = value; }
		}
		//sobreescritura del metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"Cantidad de Paginas: {_intNumPaginas}";
		}

	}
}
