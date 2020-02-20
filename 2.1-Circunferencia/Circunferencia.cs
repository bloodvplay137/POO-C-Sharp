using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Circunferencia
{
    class Circunferencia
    {
        public Circunferencia(double r)
        {
            radio = r;
        }
        // atributo
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        // metodos
        public double CalcularArea()
        {
            return Math.PI * (Math.Pow(radio, 2));
            /*
            double area;
            area = Math.PI * (Math.Pow(radio, 2));
            return area;

            double area = Math.PI * (Math.Pow(radio, 2));
            */
        }
        public double CalcularPerimetro()
        {
            return 2 * (Math.PI * radio);

            /*double perimetro;
            perimetro = 2 * (Math.PI * radio);
            return perimetro;

            double perimetro = 2 * (Math.PI * radio);
            return perimetro;*/
        }
        /*public void ModificarRadio(double r)
        {
            radio = r;
        }
        public double ConsultarRadio()
        {
            return radio;
        }*/
    }
}
