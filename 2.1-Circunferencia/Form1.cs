using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1_Circunferencia
{
    public partial class Form1 : Form
    {
        Circunferencia rueda = new Circunferencia(10.2);
        Circunferencia moneda = new Circunferencia(1.4);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //rdbRueda.Checked = true;
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            int objeto = RadioChecked();
            if (objeto == 0) {
                MessageBox.Show("Debes seleccionar un objeto");
            } else if (objeto == 1)
            {
                //rueda.ModificarRadio(double.Parse(txtRadio.Text));
                rueda.Radio = double.Parse(txtRadio.Text);
                /*double r;
                r = double.Parse(txtRadio.Text);
                rueda.ModificarRadio(r);*/
                MessageBox.Show($"Radio: {rueda.Radio}", "Radio");
            }
            else
            {
                //moneda.ModificarRadio(double.Parse(txtRadio.Text));
                moneda.Radio = double.Parse(txtRadio.Text);
                MessageBox.Show($"Radio: {moneda.Radio}", "Radio");
            }
            
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double area = 0;
            int Objeto = RadioChecked();
            switch (Objeto)
            {
                case 0: MessageBox.Show("Debes seleccionar un objeto");break;
                case 1: area = Math.Round(rueda.CalcularArea()); break;
                case 2: area = Math.Round(moneda.CalcularArea());break;          
            }
            if(Objeto == 1 || Objeto == 2) MessageBox.Show($"Area: {area.ToString()}", "Area"); 
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            double perimetro = 0;
            int Objeto = RadioChecked();
            switch (Objeto)
            {
                case 0: MessageBox.Show("Debes seleccionar un objeto"); break;
                case 1: perimetro = Math.Round(rueda.CalcularPerimetro()); break;
                case 2: perimetro = Math.Round(moneda.CalcularPerimetro()); break;
            }
            if (Objeto == 1 || Objeto == 2) MessageBox.Show($"Perimetro{perimetro.ToString()}", "Perimetro");
        }
        int RadioChecked()
        {
            /*if (rdbRueda.Checked == false && rdMoneda.Checked == false) return 0;
            else if (rdbRueda.Checked) return 1;
            else return 2;*/
            if (rdbRueda.Checked == false && rdMoneda.Checked == false)
            {
                return 0;
            }
            else if (rdbRueda.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}

