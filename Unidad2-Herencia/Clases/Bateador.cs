using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Bateador: Jugador
    {
		// constructor
		public Bateador(int intNum, string strNombre, int intHits): base(intNum,strNombre)
		{
			_intHits = intHits;
		}
		// atributos y propiedades
		private int _intHits;

		public int Hits
		{
			get { return _intHits; }
			set { _intHits = value; }
		}
		// sobreescritura del metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"\nHits: {_intHits}";
		}

	}
}
