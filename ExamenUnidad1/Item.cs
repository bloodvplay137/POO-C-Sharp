using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad1
{
    class Item
    {
		private string  _strNombre;

		public string  Nombre
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private int _intTipo;

		public int Tipo
		{
			get { return _intTipo;; }
			set { _intTipo = value; }
		}
		private string _strDirector;

		public string Director
		{
			get { return _strDirector; }
			set { _strDirector = value; }
		}
		private string _strEscritor;

		public string Escritor
		{
			get { return _strEscritor; }
			set { _strEscritor = value; }
		}
		private string _strLenguaje;

		public string Lenguaje
		{
			get { return _strLenguaje; }
			set { _strLenguaje = value; }
		}
		private string _strGenero;

		public string Genero
		{
			get { return _strGenero; }
			set { _strGenero = value; }
		}
		private DateTime _dtmFecha;

		public DateTime Fecha
		{
			get { return _dtmFecha; }
			set { _dtmFecha = value; }
		}

		private string[] arrElenco;
		public string this[int Celda]
		{
			get { return arrElenco[Celda]; }
			set { arrElenco[Celda] = value; }
		}
		//Crear Arreglo desde constructor
		public Item(int intElenco)
		{
			arrElenco = new string[intElenco];
		}
		public string Mostrar()
		{
			string elenco="Elenco: \n";
			string tipo;
			if (Tipo == 1)
			{
				tipo = "Serie";
			}
			else
			{
				tipo = "Pelicula";
			}
			foreach (string artista in arrElenco)
			{
				elenco += $"{artista}\n";
				//elenco = elenco + " " + artista + "\n";
			}
			return $"{tipo} \nNombre: {Nombre} \nDiirector: {Director} \nEscritor(es): {Escritor} \nLenguaje Orginal: {Lenguaje} \nGenero(s): {Genero}\n{elenco}\nFecha de publicacion: {Fecha}";
		}
		
	}
}
