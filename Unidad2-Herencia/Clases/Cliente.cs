using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
    class Cliente : Personaa
    {
        
        public Cliente(double dblLimiteCredito, DateTime dtmFecha, string strNombre): base(strNombre, dtmFecha)
        {
            _dblLimiteCredito = dblLimiteCredito;
        }

    private double _dblLimiteCredito;

    // Método público para determinar si es mayor de edad
    public bool EsMayorEdad()
        {
            // Variable local
            int intEdad;
            // Invoca el método CalcularEdad() de la clase base
            intEdad = base.CalcularEdad();
            
            if (intEdad >= 18)
                return (true);
            else
                return (false);
        }
        public override string ToString()
        {
            return $"Nombre : {Nombre} \nFecha Nacimiento: {FechaNacimiento} \nLimite Credito: {_dblLimiteCredito}";
        }

    }
}
