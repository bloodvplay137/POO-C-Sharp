using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Llanta
    {
		private string marca;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		private string modelo;

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}
		private int tamanio;

		public int Tamanio
		{
			get { return tamanio; }
			set { tamanio = value; }
		}
		public override string ToString()
		{
			return $"Marca: {marca} Modelo: {modelo} Tamaño: {tamanio}";
		}

	}
}
