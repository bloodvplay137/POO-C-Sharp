using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Empleado
    {
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
		private double _dblSueldo;

		public double Sueldo
		{
			get { return _dblSueldo; }
			set { _dblSueldo = value; }
		}
	}
}
