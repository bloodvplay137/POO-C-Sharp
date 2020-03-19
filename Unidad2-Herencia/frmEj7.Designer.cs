namespace Unidad2_Herencia
{
    partial class frmEj7
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
            this.gpbPosicion = new System.Windows.Forms.GroupBox();
            this.rdbPitcher = new System.Windows.Forms.RadioButton();
            this.rdbDePosicion = new System.Windows.Forms.RadioButton();
            this.rdbBateador = new System.Windows.Forms.RadioButton();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPonches = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbPosicion.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPosicion
            // 
            this.gpbPosicion.Controls.Add(this.rdbBateador);
            this.gpbPosicion.Controls.Add(this.rdbDePosicion);
            this.gpbPosicion.Controls.Add(this.rdbPitcher);
            this.gpbPosicion.Location = new System.Drawing.Point(12, 12);
            this.gpbPosicion.Name = "gpbPosicion";
            this.gpbPosicion.Size = new System.Drawing.Size(191, 110);
            this.gpbPosicion.TabIndex = 0;
            this.gpbPosicion.TabStop = false;
            this.gpbPosicion.Text = "Posicion";
            // 
            // rdbPitcher
            // 
            this.rdbPitcher.AutoSize = true;
            this.rdbPitcher.Location = new System.Drawing.Point(20, 21);
            this.rdbPitcher.Name = "rdbPitcher";
            this.rdbPitcher.Size = new System.Drawing.Size(73, 21);
            this.rdbPitcher.TabIndex = 0;
            this.rdbPitcher.TabStop = true;
            this.rdbPitcher.Text = "Pitcher";
            this.rdbPitcher.UseVisualStyleBackColor = true;
            this.rdbPitcher.CheckedChanged += new System.EventHandler(this.rdbPitcher_CheckedChanged);
            // 
            // rdbDePosicion
            // 
            this.rdbDePosicion.AutoSize = true;
            this.rdbDePosicion.Location = new System.Drawing.Point(20, 48);
            this.rdbDePosicion.Name = "rdbDePosicion";
            this.rdbDePosicion.Size = new System.Drawing.Size(158, 21);
            this.rdbDePosicion.TabIndex = 1;
            this.rdbDePosicion.TabStop = true;
            this.rdbDePosicion.Text = "Jugador de Posicion";
            this.rdbDePosicion.UseVisualStyleBackColor = true;
            this.rdbDePosicion.CheckedChanged += new System.EventHandler(this.rdbDePosicion_CheckedChanged);
            // 
            // rdbBateador
            // 
            this.rdbBateador.AutoSize = true;
            this.rdbBateador.Location = new System.Drawing.Point(20, 75);
            this.rdbBateador.Name = "rdbBateador";
            this.rdbBateador.Size = new System.Drawing.Size(87, 21);
            this.rdbBateador.TabIndex = 2;
            this.rdbBateador.TabStop = true;
            this.rdbBateador.Text = "Bateador";
            this.rdbBateador.UseVisualStyleBackColor = true;
            this.rdbBateador.CheckedChanged += new System.EventHandler(this.rdbBateador_CheckedChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(32, 128);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(160, 31);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar Jugador";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(30, 165);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 31);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Jugador";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 31);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtErrores);
            this.gpbDatos.Controls.Add(this.label5);
            this.gpbDatos.Controls.Add(this.txtHits);
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.txtPonches);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.txtNum);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Location = new System.Drawing.Point(227, 12);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(285, 225);
            this.gpbDatos.TabIndex = 4;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. uniforme:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(127, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtPonches
            // 
            this.txtPonches.Location = new System.Drawing.Point(127, 100);
            this.txtPonches.Name = "txtPonches";
            this.txtPonches.Size = new System.Drawing.Size(100, 22);
            this.txtPonches.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ponches: ";
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(127, 139);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(100, 22);
            this.txtHits.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hits: ";
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(127, 176);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(100, 22);
            this.txtErrores.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Errores:";
            // 
            // frmEj7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 258);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.gpbPosicion);
            this.Name = "frmEj7";
            this.Text = "Equipo de Beisbol";
            this.Load += new System.EventHandler(this.frmEj7_Load);
            this.gpbPosicion.ResumeLayout(false);
            this.gpbPosicion.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPosicion;
        private System.Windows.Forms.RadioButton rdbBateador;
        private System.Windows.Forms.RadioButton rdbDePosicion;
        private System.Windows.Forms.RadioButton rdbPitcher;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPonches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
    }
}