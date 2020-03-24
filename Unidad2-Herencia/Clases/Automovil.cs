using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Automovil
    {
		private string marca;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}
		private int anio;

		public int Anio
		{
			get { return anio; }
			set { anio = value; }
		}
		private string modelo;

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		List<Llanta> listaLlantas;
		List<Puerta> listaPuertas;

		private Motor motor;
		public Automovil() {
			listaLlantas = new List<Llanta>();
			listaPuertas = new List<Puerta>();
			motor = new Motor();
		}

		public Motor ParteMotor
		{
			get
			{ return motor; }
			set
			{
				if (motor.NS == "")
				{
					motor = value;
				}
			}
				
		}
		public void InsertarPuerta(Puerta puerta)
		{
			listaPuertas.Add(puerta);
		}
		public void InsertarLlanta(Llanta llanta)
		{
			if (listaLlantas.Count() > 4)
			{
				return;
			}
			else
			{
				listaLlantas.Add(llanta);
			}
		}
		public IEnumerable<Puerta> ListaPuertas
		{
			get
			{
				foreach (Puerta puerta in listaPuertas)
				{
					yield return puerta;
				    //yield break;
				}
			}
		}
		public IEnumerable<Llanta> ListaLlantas
		{
			get
			{
				foreach (Llanta llanta in listaLlantas)
				{
					yield return llanta;
				    //yield break;
				}
			}
		}
		public override string ToString()
		{
			if (listaPuertas.Count() < 2)
			{
				return "Error, el auto debe de tener mas de 2 puertas";
			}
			else
			{
				return $"Marca: {marca} \nModelo: {modelo} \nAño: {anio} \nMotor: {motor.ToString()}";
			}
			
		}
	}
}
