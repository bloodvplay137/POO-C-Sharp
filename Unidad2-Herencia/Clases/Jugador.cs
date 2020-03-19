using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    abstract class Jugador
    {
		//constructor
		public Jugador(int intNum, string strNombre)
		{
			_intNum = intNum;
			_strNombre = strNombre;
		}

		//atributos y propiedades
		private int _intNum;

		public int Num
		{
			get { return _intNum; }
			set { _intNum = value; }
		}
		private string _strNombre;

		public string Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}
		//sobreescritura del metodo ToString
		public override string ToString()
		{
			return $"Nombre: {_strNombre}\nNumero: {_intNum}";
		}

	}
}
