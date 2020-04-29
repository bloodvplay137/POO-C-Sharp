using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	abstract class Empleado
	{
		private int horastrabajadas;

		public int HorasTrabajadas
		{
			get { return horastrabajadas; }
			set { horastrabajadas = value; }
		}

		private double sueldoporhora;

		public double SueldoPorHora
		{
			get { return sueldoporhora; }
			set { sueldoporhora = value; }
		}

		public virtual double CalcularSalario() {
			return HorasTrabajadas * SueldoPorHora;
		}

	}
}
