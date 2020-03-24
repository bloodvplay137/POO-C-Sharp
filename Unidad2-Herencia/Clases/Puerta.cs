using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Puerta
    {
		private int tipo;

		public int Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}
		public override string ToString()
		{
			return $"Tipo: {tipo}";
		}

	}
}
