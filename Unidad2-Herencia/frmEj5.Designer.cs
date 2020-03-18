namespace Unidad2_Herencia
{
    partial class frmEj5
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbCompacto = new System.Windows.Forms.RadioButton();
            this.rdbCamioneta = new System.Windows.Forms.RadioButton();
            this.rdbDeLujo = new System.Windows.Forms.RadioButton();
            this.rdbVagoneta = new System.Windows.Forms.RadioButton();
            this.gpbDatosEspecificos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantEjes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCapCarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantPasajeros = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpbDatos.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            this.gpbDatosEspecificos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.txtPrecio);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.txtAnio);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.txtMarca);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Controls.Add(this.txtNS);
            this.gpbDatos.Location = new System.Drawing.Point(32, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(273, 161);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos generales del vehiculo";
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(145, 30);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(100, 22);
            this.txtNS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca: ";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(145, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año: ";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(145, 88);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 22);
            this.txtAnio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(145, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbVagoneta);
            this.gpbTipo.Controls.Add(this.rdbDeLujo);
            this.gpbTipo.Controls.Add(this.rdbCamioneta);
            this.gpbTipo.Controls.Add(this.rdbCompacto);
            this.gpbTipo.Location = new System.Drawing.Point(32, 179);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(273, 100);
            this.gpbTipo.TabIndex = 1;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo de vehiculo";
            // 
            // rdbCompacto
            // 
            this.rdbCompacto.AutoSize = true;
            this.rdbCompacto.Location = new System.Drawing.Point(25, 32);
            this.rdbCompacto.Name = "rdbCompacto";
            this.rdbCompacto.Size = new System.Drawing.Size(123, 21);
            this.rdbCompacto.TabIndex = 0;
            this.rdbCompacto.TabStop = true;
            this.rdbCompacto.Text = "Auto compacto";
            this.rdbCompacto.UseVisualStyleBackColor = true;
            this.rdbCompacto.CheckedChanged += new System.EventHandler(this.rdbCompacto_CheckedChanged);
            // 
            // rdbCamioneta
            // 
            this.rdbCamioneta.AutoSize = true;
            this.rdbCamioneta.Location = new System.Drawing.Point(25, 59);
            this.rdbCamioneta.Name = "rdbCamioneta";
            this.rdbCamioneta.Size = new System.Drawing.Size(96, 21);
            this.rdbCamioneta.TabIndex = 1;
            this.rdbCamioneta.TabStop = true;
            this.rdbCamioneta.Text = "Camioneta";
            this.rdbCamioneta.UseVisualStyleBackColor = true;
            this.rdbCamioneta.CheckedChanged += new System.EventHandler(this.rdbCamioneta_CheckedChanged);
            // 
            // rdbDeLujo
            // 
            this.rdbDeLujo.AutoSize = true;
            this.rdbDeLujo.Location = new System.Drawing.Point(156, 32);
            this.rdbDeLujo.Name = "rdbDeLujo";
            this.rdbDeLujo.Size = new System.Drawing.Size(104, 21);
            this.rdbDeLujo.TabIndex = 2;
            this.rdbDeLujo.TabStop = true;
            this.rdbDeLujo.Text = "Auto de lujo";
            this.rdbDeLujo.UseVisualStyleBackColor = true;
            this.rdbDeLujo.CheckedChanged += new System.EventHandler(this.rdbDeLujo_CheckedChanged);
            // 
            // rdbVagoneta
            // 
            this.rdbVagoneta.AutoSize = true;
            this.rdbVagoneta.Location = new System.Drawing.Point(156, 59);
            this.rdbVagoneta.Name = "rdbVagoneta";
            this.rdbVagoneta.Size = new System.Drawing.Size(90, 21);
            this.rdbVagoneta.TabIndex = 3;
            this.rdbVagoneta.TabStop = true;
            this.rdbVagoneta.Text = "Vagoneta";
            this.rdbVagoneta.UseVisualStyleBackColor = true;
            this.rdbVagoneta.CheckedChanged += new System.EventHandler(this.rdbVagoneta_CheckedChanged);
            // 
            // gpbDatosEspecificos
            // 
            this.gpbDatosEspecificos.Controls.Add(this.label6);
            this.gpbDatosEspecificos.Controls.Add(this.txtCantEjes);
            this.gpbDatosEspecificos.Controls.Add(this.label7);
            this.gpbDatosEspecificos.Controls.Add(this.txtCapCarga);
            this.gpbDatosEspecificos.Controls.Add(this.label8);
            this.gpbDatosEspecificos.Controls.Add(this.txtCantPasajeros);
            this.gpbDatosEspecificos.Location = new System.Drawing.Point(322, 12);
            this.gpbDatosEspecificos.Name = "gpbDatosEspecificos";
            this.gpbDatosEspecificos.Size = new System.Drawing.Size(273, 161);
            this.gpbDatosEspecificos.TabIndex = 9;
            this.gpbDatosEspecificos.TabStop = false;
            this.gpbDatosEspecificos.Text = "Datos especificos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad de Ejes: ";
            // 
            // txtCantEjes
            // 
            this.txtCantEjes.Location = new System.Drawing.Point(145, 115);
            this.txtCantEjes.Name = "txtCantEjes";
            this.txtCantEjes.Size = new System.Drawing.Size(100, 22);
            this.txtCantEjes.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Capacidad de Carga:";
            // 
            // txtCapCarga
            // 
            this.txtCapCarga.Location = new System.Drawing.Point(177, 74);
            this.txtCapCarga.Name = "txtCapCarga";
            this.txtCapCarga.Size = new System.Drawing.Size(68, 22);
            this.txtCapCarga.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad de Pasajeros:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCantPasajeros
            // 
            this.txtCantPasajeros.Location = new System.Drawing.Point(177, 30);
            this.txtCantPasajeros.Name = "txtCantPasajeros";
            this.txtCantPasajeros.Size = new System.Drawing.Size(68, 22);
            this.txtCantPasajeros.TabIndex = 1;
            this.txtCantPasajeros.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(367, 206);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 53);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear Vehiculo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(467, 206);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 53);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar Vehiculo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmEj5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 297);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gpbDatosEspecificos);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmEj5";
            this.Text = "frmEj5";
            this.Load += new System.EventHandler(this.frmEj5_Load);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.gpbDatosEspecificos.ResumeLayout(false);
            this.gpbDatosEspecificos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbVagoneta;
        private System.Windows.Forms.RadioButton rdbDeLujo;
        private System.Windows.Forms.RadioButton rdbCamioneta;
        private System.Windows.Forms.RadioButton rdbCompacto;
        private System.Windows.Forms.GroupBox gpbDatosEspecificos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantEjes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCapCarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantPasajeros;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
    }
}