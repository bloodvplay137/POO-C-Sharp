using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Motor
    {
		private string ns;

		public string NS
		{
			get { return ns; }
			set { ns = value; }
		}
		private int cilindros;

		public int Cilindros
		{
			get { return cilindros; }
			set { cilindros = value; }
		}
		public override string ToString()
		{
			return $"Numero de serie: {ns} Cilindros: {cilindros}";
		}

	}
}
