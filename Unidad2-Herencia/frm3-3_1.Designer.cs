namespace Unidad2_Herencia
{
    partial class frm3_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.btnMotor = new System.Windows.Forms.Button();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsbLlantas = new System.Windows.Forms.ListBox();
            this.btnLlantas = new System.Windows.Forms.Button();
            this.txtTamanioL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModeloL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lsbPuertas = new System.Windows.Forms.ListBox();
            this.btnPuertas = new System.Windows.Forms.Button();
            this.txtTipoP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(106, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(111, 23);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar Auto";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(6, 129);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(94, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear Auto";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(84, 91);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 22);
            this.txtAnio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(84, 63);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(84, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(274, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 188);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMotor);
            this.tabPage1.Controls.Add(this.btnMotor);
            this.tabPage1.Controls.Add(this.txtCilindros);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNS);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Motor";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(25, 94);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(360, 22);
            this.txtMotor.TabIndex = 10;
            // 
            // btnMotor
            // 
            this.btnMotor.Location = new System.Drawing.Point(304, 16);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(81, 23);
            this.btnMotor.TabIndex = 9;
            this.btnMotor.Text = "Insertar";
            this.btnMotor.UseVisualStyleBackColor = true;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // txtCilindros
            // 
            this.txtCilindros.Location = new System.Drawing.Point(115, 46);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.Size = new System.Drawing.Size(100, 22);
            this.txtCilindros.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cilindros:";
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(115, 16);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(100, 22);
            this.txtNS.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num. serie: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsbLlantas);
            this.tabPage2.Controls.Add(this.btnLlantas);
            this.tabPage2.Controls.Add(this.txtTamanioL);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtModeloL);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtMarcaL);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Llantas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsbLlantas
            // 
            this.lsbLlantas.FormattingEnabled = true;
            this.lsbLlantas.ItemHeight = 16;
            this.lsbLlantas.Location = new System.Drawing.Point(20, 80);
            this.lsbLlantas.Name = "lsbLlantas";
            this.lsbLlantas.Size = new System.Drawing.Size(369, 68);
            this.lsbLlantas.TabIndex = 13;
            // 
            // btnLlantas
            // 
            this.btnLlantas.Location = new System.Drawing.Point(220, 47);
            this.btnLlantas.Name = "btnLlantas";
            this.btnLlantas.Size = new System.Drawing.Size(169, 23);
            this.btnLlantas.TabIndex = 10;
            this.btnLlantas.Text = "Insertar";
            this.btnLlantas.UseVisualStyleBackColor = true;
            this.btnLlantas.Click += new System.EventHandler(this.btnLlantas_Click);
            // 
            // txtTamanioL
            // 
            this.txtTamanioL.Location = new System.Drawing.Point(289, 19);
            this.txtTamanioL.Name = "txtTamanioL";
            this.txtTamanioL.Size = new System.Drawing.Size(100, 22);
            this.txtTamanioL.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tamaño: ";
            // 
            // txtModeloL
            // 
            this.txtModeloL.Location = new System.Drawing.Point(89, 47);
            this.txtModeloL.Name = "txtModeloL";
            this.txtModeloL.Size = new System.Drawing.Size(100, 22);
            this.txtModeloL.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Modelo: ";
            // 
            // txtMarcaL
            // 
            this.txtMarcaL.Location = new System.Drawing.Point(89, 16);
            this.txtMarcaL.Name = "txtMarcaL";
            this.txtMarcaL.Size = new System.Drawing.Size(100, 22);
            this.txtMarcaL.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marca: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lsbPuertas);
            this.tabPage3.Controls.Add(this.btnPuertas);
            this.tabPage3.Controls.Add(this.txtTipoP);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(404, 159);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Puertas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsbPuertas
            // 
            this.lsbPuertas.FormattingEnabled = true;
            this.lsbPuertas.ItemHeight = 16;
            this.lsbPuertas.Location = new System.Drawing.Point(18, 47);
            this.lsbPuertas.Name = "lsbPuertas";
            this.lsbPuertas.Size = new System.Drawing.Size(370, 100);
            this.lsbPuertas.TabIndex = 12;
            // 
            // btnPuertas
            // 
            this.btnPuertas.Location = new System.Drawing.Point(193, 16);
            this.btnPuertas.Name = "btnPuertas";
            this.btnPuertas.Size = new System.Drawing.Size(169, 23);
            this.btnPuertas.TabIndex = 11;
            this.btnPuertas.Text = "Insertar";
            this.btnPuertas.UseVisualStyleBackColor = true;
            this.btnPuertas.Click += new System.EventHandler(this.btnPuertas_Click);
            // 
            // txtTipoP
            // 
            this.txtTipoP.Location = new System.Drawing.Point(87, 16);
            this.txtTipoP.Name = "txtTipoP";
            this.txtTipoP.Size = new System.Drawing.Size(100, 22);
            this.txtTipoP.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo: ";
            // 
            // frm3_3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 213);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm3_3_1";
            this.Text = "Administrar Vehiculos";
            this.Load += new System.EventHandler(this.frm3_3_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lsbLlantas;
        private System.Windows.Forms.Button btnLlantas;
        private System.Windows.Forms.TextBox txtTamanioL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModeloL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarcaL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lsbPuertas;
        private System.Windows.Forms.Button btnPuertas;
        private System.Windows.Forms.TextBox txtTipoP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMostrar;
    }
}