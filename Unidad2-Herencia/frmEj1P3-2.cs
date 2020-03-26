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
    public partial class frmEj1P3_2 : Form
    {
        Empresa empresa;
        DataGridViewRow currentRow;
        public frmEj1P3_2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEj1P3_2_Load(object sender, EventArgs e)
        {
            
            empresa = new Empresa();
            empresa.RFC = "AX243";
            empresa.RazonSocial = "Empresa Test";
            empresa.Gerente = "Gerente Test";
            
            
            Departamento departamento;
            departamento = new Departamento();
            departamento.Numero = 1;
            departamento.Nombre = "RH";
            departamento.Jefe = "Jefe 1";
            empresa.insertar(departamento);
            Departamento departamento1;
            departamento1 = new Departamento();
            departamento1.Numero = 2;
            departamento1.Nombre = "Sistemas";
            departamento1.Jefe = "Jefe 2";
            empresa.insertar(departamento1);
            mostrarDeptos();
            


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            empresa = new Empresa();
            empresa.RFC = txtRfc.Text;
            empresa.RazonSocial = txtRazon.Text;
            empresa.Gerente = txtGerente.Text;
            foreach (Control t in gpbTodo.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
            btnCrear.Enabled = false;
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Departamento dpto = new Departamento();
            dpto.Numero = int.Parse(txtNumero.Text);
            dpto.Nombre = txtNombre.Text;
            dpto.Jefe = txtJefe.Text;
            empresa.insertar(dpto);
            mostrarDeptos();
        }
        void mostrarDeptos(){
            dataGridView1.Rows.Clear();
            foreach (Departamento dpto in empresa)
            {
                dataGridView1.Rows.Add(dpto.Numero, dpto.Nombre, dpto.Jefe);
            }
            foreach (Control t in gpbParte.Controls)
            {
                if (t is TextBox)
                {
                    t.ResetText();
                }
            }
            txtNumero.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            currentRow = dataGridView1.CurrentRow;


            if (currentRow == null)
            {
                MessageBox.Show("Seleccione un renglón del dataGridView");
                return;
            }
            else 
            {
                empresa.eliminarDepartamento(currentRow.Index);
                mostrarDeptos();
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsE_Click(object sender, EventArgs e)
        {
            currentRow = dataGridView1.CurrentRow;
            //Creo mi empleado y le doy valores
            Empleado empleado = new Empleado();
            empleado.Num = int.Parse(txtNumE.Text);
            empleado.Nombre = txtNomE.Text;
            empleado.Sueldo = double.Parse(txtSueldoE.Text);
            // inserto mi empleado en mi lista de empleados
            Departamento currentDep = new Departamento();
            foreach (Departamento departamento in empresa)
            {
                if (currentRow.Cells[0].Value.ToString() == departamento.Numero.ToString())
                {
                    currentDep = departamento;
                    break;
                }
            }
            //revisar.
            currentDep.insertarEmpleado(empleado);
            // Mostrar los emleados del departamento correspondiente en nuestro datagridview de empleados.
            MostrarEmpleados(currentDep);
        }
        void MostrarEmpleados(Departamento currentDep)
        {
            // limpio mi datagridview de empleados
            dgEmpleados.Rows.Clear();

            foreach (Empleado empleado in currentDep)
            {
                dgEmpleados.Rows.Add(empleado.Num, empleado.Nombre, empleado.Sueldo);
            }
            foreach (Control t in gpbEmpleado.Controls)
            {
                if (t is TextBox)
                {
                    t.ResetText();
                }
            }
            txtNumE.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            currentRow = dataGridView1.CurrentRow;
            foreach (Departamento departamentoActual in empresa)
            {
                int RenglonNumero = int.Parse(currentRow.Cells[0].Value.ToString());
                if (RenglonNumero == departamentoActual.Numero)
                {
                    MostrarEmpleados(departamentoActual);
                    break;
                }
            }
        }

        private void btnEliE_Click(object sender, EventArgs e)
        {
            DataGridViewRow EmpleadoActual = dgEmpleados.CurrentRow;
            foreach (Departamento departamentoActual in empresa)
            {
                int RenglonNumero = int.Parse(currentRow.Cells[0].Value.ToString());
                if (RenglonNumero == departamentoActual.Numero)
                {
                    departamentoActual.eliminarEmpleado(EmpleadoActual.Index);
                    MostrarEmpleados(departamentoActual);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  tarea
            Departamento destruirDepartamento()
            {
                Departamento dep = new Departamento();
                currentRow = dataGridView1.CurrentRow;
                foreach (Departamento departamentoActual in empresa)
                {
                    int RenglonNumero = int.Parse(currentRow.Cells[0].Value.ToString());
                    if (RenglonNumero == departamentoActual.Numero)
                    {
                        dep = departamentoActual;
                    }
                }
                return dep;   
            }
            Departamento destruir = new Departamento();
            destruir = destruirDepartamento(); 
            destruir = null;
            mostrarDeptos();
        }
    }
}
