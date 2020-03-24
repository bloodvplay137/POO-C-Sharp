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
        public frmEj1P3_2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEj1P3_2_Load(object sender, EventArgs e)
        {

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
    }
}
