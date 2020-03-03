using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2._1.Clases
{
    class Fecha
    {
		DateTime date = DateTime.Now;
		
		//Atributos 
		int dia, mes, anio;
		// Constructores 
		public Fecha()
		{
			dia = date.Day;
			mes = date.Month;
			anio = date.Year;
		}
		public Fecha(int dia, int mes, int anio)
		{
			this.dia = dia;
			this.mes = mes;
			this.anio = anio;
		}
		// Metodos
		public void ModificarFecha(int dia,int mes, int anio)
		{
			this.dia = dia;
			this.mes = mes;
			this.anio = anio;
		}
		public string ConsultarFecha()
		{
			string mesLetras="";
			switch(mes)
			{
				case 1: mesLetras = "enero"; break;
				case 2: mesLetras = "febrero"; break;
				case 3: mesLetras = "marzo"; break;
				case 4: mesLetras = "abril"; break;
				case 5: mesLetras = "mayo"; break;
				case 6: mesLetras = "junio"; break;
				case 7: mesLetras = "julio"; break;
				case 8: mesLetras = "agosto"; break;
				case 9: mesLetras = "septiembre"; break;
				case 10: mesLetras = "octubre"; break;
				case 11: mesLetras = "noviembre"; break;
				case 12: mesLetras = "diciembre"; break;
			}
			return $"La fecha de este objeto es: {dia}/{mesLetras}/{anio}";
		}
		
	}
}
