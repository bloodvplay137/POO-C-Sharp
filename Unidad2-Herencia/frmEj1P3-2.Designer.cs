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
            this.gpbParte = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbTodo.SuspendLayout();
            this.gpbParte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Jefe});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFC: ";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(123, 23);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(100, 22);
            this.txtRfc.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gerente: ";
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(123, 91);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(97, 22);
            this.txtJefe.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jefe:";
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
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(123, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero: ";
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
            // frmEj1P3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
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
    }
}