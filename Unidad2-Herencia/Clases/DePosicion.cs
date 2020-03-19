using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class DePosicion: Jugador
    {
		// constructor
		public DePosicion(int intNum, string strNombre, int intErrores): base(intNum,strNombre) 
		{
			_intErrores = intErrores;
		}
		// atributos y propiedades
		private int _intErrores;
					
		public int Errores
		{
			get { return _intErrores; }
			set { _intErrores = value; }
		}
		// sobreescritura del metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"\nErrores: {_intErrores}";
		}

	}
}
