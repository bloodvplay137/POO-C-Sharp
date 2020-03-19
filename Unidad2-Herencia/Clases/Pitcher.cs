using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Pitcher: DePosicion
    {
		// constructor
		public Pitcher(int intNum, string strNombre, int intErrores, int intPonches) : base(intNum,strNombre,intErrores)
		{
			_intPonches = intPonches;
		}
		// atributos y propiedades 
		private int _intPonches;

		public int Ponches
		{
			get { return _intPonches; }
			set { _intPonches = value; }
		}
		// sobreescritura del metodo ToString
		public override string ToString()
		{
			return base.ToString() + $"\n{_intPonches}";
		}

	}
}
