using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_3_4
{
    class Rectangulo
    {
        //atributos privados
        private double ancho,largo;
        
        //metodos
        public double CalcularArea()
        {
            // area rectangulo = b x h
            return ancho * largo;
        }    
        //mutators
        public void ModificarLargo(double largo)
        {
            this.largo = largo;
        }
        public void ModificarAncho(double ancho)
        {
            this.ancho = ancho;
        }
        //accesors
        public double ConsultarLargo()
        {
            return largo;
        }
        public double ConsultarAncho()
        {
            return ancho;
        }
    }
}
