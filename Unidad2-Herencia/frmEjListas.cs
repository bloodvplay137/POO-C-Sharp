using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_Herencia.Clases;

namespace Unidad2_Herencia
{
    public partial class frmEjListas : Form
    {
        Empleado empleado;
        List<Empleado> empresa = new List<Empleado>();
        public frmEjListas()
        {
            InitializeComponent();
        }

        private void frmEjListas_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Nombre","Nombre");
            dataGridView1.Columns.Add("Sueldo", "Sueldo");
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creacion del objeto
            empleado = new Empleado();
            //Asignando los valores por medio de sus propiedades
            empleado.Num = int.Parse(txtNum.Text);
            empleado.Nombre = txtNombre.Text;
            empleado.Sueldo = double.Parse(txtSueldo.Text);
            //Agregando objeto a la lista
            empresa.Add(empleado);
            //Agregando los valores al datagridview
            dataGridView1.Rows.Add();
        }
    }
}
