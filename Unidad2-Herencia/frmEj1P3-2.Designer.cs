namespace Unidad2_Herencia
{
    partial class frmEj1P3_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbTodo = new System.Windows.Forms.GroupBox();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbParte = new System.Windows.Forms.GroupBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtSueldoE = new System.Windows.Forms.TextBox();
            this.txtNumE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliE = new System.Windows.Forms.Button();
            this.btnInsE = new System.Windows.Forms.Button();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbTodo.SuspendLayout();
            this.gpbParte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.gpbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTodo
            // 
            this.gpbTodo.Controls.Add(this.txtGerente);
            this.gpbTodo.Controls.Add(this.label3);
            this.gpbTodo.Controls.Add(this.txtRazon);
            this.gpbTodo.Controls.Add(this.label2);
            this.gpbTodo.Controls.Add(this.txtRfc);
            this.gpbTodo.Controls.Add(this.label1);
            this.gpbTodo.Location = new System.Drawing.Point(12, 12);
            this.gpbTodo.Name = "gpbTodo";
            this.gpbTodo.Size = new System.Drawing.Size(238, 124);
            this.gpbTodo.TabIndex = 0;
            this.gpbTodo.TabStop = false;
            this.gpbTodo.Text = "Empresa";
            this.gpbTodo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(123, 83);
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new System.Drawing.Size(100, 22);
            this.txtGerente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gerente: ";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(123, 55);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(100, 22);
            this.txtRazon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(123, 23);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(100, 22);
            this.txtRfc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC: ";
            // 
            // gpbParte
            // 
            this.gpbParte.Controls.Add(this.txtJefe);
            this.gpbParte.Controls.Add(this.txtNumero);
            this.gpbParte.Controls.Add(this.label4);
            this.gpbParte.Controls.Add(this.label6);
            this.gpbParte.Controls.Add(this.txtNombre);
            this.gpbParte.Controls.Add(this.label5);
            this.gpbParte.Location = new System.Drawing.Point(12, 142);
            this.gpbParte.Name = "gpbParte";
            this.gpbParte.Size = new System.Drawing.Size(238, 134);
            this.gpbParte.TabIndex = 0;
            this.gpbParte.TabStop = false;
            this.gpbParte.Text = "Departamento";
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(123, 91);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(97, 22);
            this.txtJefe.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(123, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jefe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(97, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Jefe});
            this.dataGridView1.Location = new System.Drawing.Point(367, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Jefe
            // 
            this.Jefe.HeaderText = "Jefe";
            this.Jefe.MinimumWidth = 6;
            this.Jefe.Name = "Jefe";
            this.Jefe.ReadOnly = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(261, 54);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 48);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Empresa";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(261, 160);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 48);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar Depto";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(261, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 48);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Depto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Sueldo});
            this.dgEmpleados.Location = new System.Drawing.Point(367, 233);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(324, 183);
            this.dgEmpleados.TabIndex = 5;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.MinimumWidth = 6;
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // gpbEmpleado
            // 
            this.gpbEmpleado.Controls.Add(this.txtSueldoE);
            this.gpbEmpleado.Controls.Add(this.txtNumE);
            this.gpbEmpleado.Controls.Add(this.label7);
            this.gpbEmpleado.Controls.Add(this.label8);
            this.gpbEmpleado.Controls.Add(this.txtNomE);
            this.gpbEmpleado.Controls.Add(this.label9);
            this.gpbEmpleado.Location = new System.Drawing.Point(12, 282);
            this.gpbEmpleado.Name = "gpbEmpleado";
            this.gpbEmpleado.Size = new System.Drawing.Size(238, 134);
            this.gpbEmpleado.TabIndex = 12;
            this.gpbEmpleado.TabStop = false;
            this.gpbEmpleado.Text = "Empleado";
            // 
            // txtSueldoE
            // 
            this.txtSueldoE.Location = new System.Drawing.Point(123, 91);
            this.txtSueldoE.Name = "txtSueldoE";
            this.txtSueldoE.Size = new System.Drawing.Size(97, 22);
            this.txtSueldoE.TabIndex = 11;
            // 
            // txtNumE
            // 
            this.txtNumE.Location = new System.Drawing.Point(123, 31);
            this.txtNumE.Name = "txtNumE";
            this.txtNumE.Size = new System.Drawing.Size(97, 22);
            this.txtNumE.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sueldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Numero: ";
            // 
            // txtNomE
            // 
            this.txtNomE.Location = new System.Drawing.Point(123, 63);
            this.txtNomE.Name = "txtNomE";
            this.txtNomE.Size = new System.Drawing.Size(97, 22);
            this.txtNomE.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre: ";
            // 
            // btnEliE
            // 
            this.btnEliE.Location = new System.Drawing.Point(135, 438);
            this.btnEliE.Name = "btnEliE";
            this.btnEliE.Size = new System.Drawing.Size(75, 48);
            this.btnEliE.TabIndex = 14;
            this.btnEliE.Text = "Eliminar Empleado";
            this.btnEliE.UseVisualStyleBackColor = true;
            this.btnEliE.Click += new System.EventHandler(this.btnEliE_Click);
            // 
            // btnInsE
            // 
            this.btnInsE.Location = new System.Drawing.Point(37, 438);
            this.btnInsE.Name = "btnInsE";
            this.btnInsE.Size = new System.Drawing.Size(75, 48);
            this.btnInsE.TabIndex = 13;
            this.btnInsE.Text = "Insertar Empleado";
            this.btnInsE.UseVisualStyleBackColor = true;
            this.btnInsE.Click += new System.EventHandler(this.btnInsE_Click);
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(235, 438);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(75, 48);
            this.btnMostrarEmpleados.TabIndex = 15;
            this.btnMostrarEmpleados.Text = "Mostrar Empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar Departamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEj1P3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarEmpleados);
            this.Controls.Add(this.btnEliE);
            this.Controls.Add(this.btnInsE);
            this.Controls.Add(this.gpbEmpleado);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbParte);
            this.Controls.Add(this.gpbTodo);
            this.Name = "frmEj1P3_2";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEj1P3_2_Load);
            this.gpbTodo.ResumeLayout(false);
            this.gpbTodo.PerformLayout();
            this.gpbParte.ResumeLayout(false);
            this.gpbParte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.gpbEmpleado.ResumeLayout(false);
            this.gpbEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTodo;
        private System.Windows.Forms.TextBox txtGerente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbParte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jefe;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.GroupBox gpbEmpleado;
        private System.Windows.Forms.TextBox txtSueldoE;
        private System.Windows.Forms.TextBox txtNumE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliE;
        private System.Windows.Forms.Button btnInsE;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.Button button1;
    }
}