using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Libro: Publicacion
    {
		private int _intNumPaginas;

		public int NumPaginas
		{
			get { return _intNumPaginas; }
			set { _intNumPaginas = value; }
		}
		public override string ToString()
		{
			return $"Titulo: {Titulo}\nPrecio: {Precio}\n Cantidad de Paginas: {_intNumPaginas}";
		}

	}
}
