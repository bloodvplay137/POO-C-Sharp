using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1.Clases
{
    class Articulo
    {
		// Atributos y Propiedades
		private int clave;

		public int Clave
		{
			get { return clave; }
			set { clave = value; }
		}
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}
		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}
		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		
		// Constructor
		public Articulo(int clave, string descripcion, double precio, int cantidad)
		{
			this.clave = clave;
			this.descripcion = descripcion;
			this.precio = precio;
			this.cantidad = cantidad;
		}
		//Metodo
		public double CalcularIVA()
		{
			return precio*cantidad * .08;
		}
	}
}
