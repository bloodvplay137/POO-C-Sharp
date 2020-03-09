using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad1
{
    public partial class Form1 : Form
    {
        Item item1, item2, item3;
        
        int series, peliculas;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsbElenco.Items.Add(txtArtista.Text);
            txtArtista.Clear();
            txtArtista.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (itemChecked())
            {
                case 1: MessageBox.Show(item1.Mostrar());break;
                case 2: MessageBox.Show(item2.Mostrar()); break;
                case 3: MessageBox.Show(item3.Mostrar()); break;
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Series: {series} Peliculas: {peliculas}");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string director = txtDirector.Text;
            string escritor = txtEscritor.Text;
            string lenguaje = txtLenguaje.Text;
            int tipo;
            if (radioButton1.Checked == true)
            {
                tipo = 1;
                series++;
            }
            else
            {
                tipo = 2;
                peliculas++;
            }
            string genero = "\n";
            
            if(checkBox1.Checked == true)
            {
                genero = genero + " " + checkBox1.Text+ "\n";
            }
            if (checkBox2.Checked == true)
            {
                genero = genero + " " + checkBox1.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                genero = genero + " " + checkBox1.Text + "\n";
            }

            foreach (CheckBox check in gpbGenero.Controls)
            {
                if (check.Checked == true)
                {
                    genero += $"{check.Text}\n";
                    //genero = genero + " " + check.Text + "\n";
                }   
            }
            DateTime fecha = DateTime.Now;
            int elenco = lsbElenco.Items.Count;

            int item = itemChecked();
            switch (item)
            {
                case 1:
                    {
                        item1 = new Item(elenco);
                        item1.Nombre = nombre;
                        item1.Director = director;
                        item1.Escritor = escritor;
                        item1.Lenguaje = lenguaje;
                        item1.Genero = genero;
                        item1.Tipo = tipo;
                        for (int x = 0; x < elenco; x++)
                        {
                            item1[x] = lsbElenco.Items[x].ToString();
                        }
                    }
                    break;
                case 2:
                    {
                        item2 = new Item(elenco);
                        item2.Nombre = nombre;
                        item2.Director = director;
                        item2.Escritor = escritor;
                        item2.Lenguaje = lenguaje;
                        item2.Genero = genero;
                        item2.Tipo = tipo;
                        
                        for (int x = 0; x < elenco; x++)
                        {
                            item1[x] = lsbElenco.Items[x].ToString();
                        }
                    }
                    break;
                case 3:
                    {
                        item3 = new Item(elenco);
                        item3.Nombre = nombre;
                        item3.Director = director;
                        item3.Escritor = escritor;
                        item3.Lenguaje = lenguaje;
                        item3.Genero = genero;
                        item3.Tipo = tipo;
                        for (int x = 0; x < elenco; x++)
                        {
                            item3[x] = lsbElenco.Items[x].ToString();
                        }
                    }
                    break;
            }
        }

        int itemChecked()
        {
            if (rdbItem1.Checked == true)
            {
                return 1;
            }
            if (rdbItem2.Checked) { 
                return 2; 
            }
            if (rdbItem3.Checked)
            {
                return 3;
            }
            return 0;
        }
    }
}
