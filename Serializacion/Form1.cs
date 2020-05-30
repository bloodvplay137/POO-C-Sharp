using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializacion
{
    public partial class Form1 : Form
    {
        ArchivoSecuencialSerializadoBinario<Empleado> miArchivo = new ArchivoSecuencialSerializadoBinario<Empleado>("D:\\Downloads\\Empleados.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado miEmpleado = new Empleado();
            try
            {
                miEmpleado.Numero = int.Parse(txtNumero.Text);
                miEmpleado.Nombre = txtNombre.Text;
                miEmpleado.Sueldo = double.Parse(txtSueldo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                miArchivo.AbrirEnModoEscritura();
                miArchivo.GrabarObjeto(miEmpleado);
                MessageBox.Show("Datos almacenados correctamente !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                miArchivo.Cerrar();
            }
            mostrarDatos();
        }
        public void mostrarDatos() {
            Empleado miEmpleado = new Empleado();
            dgEmpleados.Rows.Clear();
            try
            {
                miArchivo.AbrirEnModoLectura();
                while (!miArchivo.Finarchivo)
                {
                    miEmpleado = miArchivo.LeerObjeto();
                    dgEmpleados.Rows.Add(miEmpleado.Nombre, miEmpleado.Numero, miEmpleado.Sueldo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { miArchivo.Cerrar(); }
            
        
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
