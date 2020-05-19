using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica_5_Eventos
{
    // Delegado
    public delegate void AumentarPagoEventHandler(string strNombre, string numControl, double pago);
    class Estudiante
    {
        // Evento
        public event AumentarPagoEventHandler AumentarPago;
        private string nombre = "";

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string numControl;

        public string NumControl
        {
            get { return numControl; }
            set { numControl = value; }
        }
        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set
            { // Valida la cantidad
                if (value > cantidad)
                {
                    // Incrementa el saldo
                    cantidad = value;
                    // Genera el evento
                    AumentarPago(nombre, numControl, cantidad);
                }
            }
        }
        
    }
}
