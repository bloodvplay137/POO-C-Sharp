using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Departamento
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private string jefe;

		public string Jefe
		{
			get { return jefe; }
			set { jefe = value; }
		}
		List<Empleado> listaEmpleados;
		public Departamento()
		{
			listaEmpleados = new List<Empleado>();
		}
		public void insertarEmpleado(Empleado empleado)
		{
			listaEmpleados.Add(empleado);
		}
		public IEnumerator<Empleado> GetEnumerator()
		{
			return listaEmpleados.GetEnumerator();
		}
		public void eliminarEmpleado(int index)
		{
			listaEmpleados.RemoveAt(index);
			//listaEmpleados.Remove(empleado);

		}
		~Departamento()
		{
			listaEmpleados.Clear();
		}
	}
}
