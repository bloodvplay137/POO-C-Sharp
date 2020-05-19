using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Practica_5_Eventos
{
    public partial class frm5_4 : Form
    {
        Estudiante unEstudiante = new Estudiante();
        const string CORREO = "juan.ahumada@wakecode.mx";
        const string PASSWORD = "1234567899";
        const string SERVIDOR = "mail.wakecode.mx";
        const int PUERTO = 587;
        public frm5_4()
        {
            InitializeComponent();
        }

        private void frm5_4_Load(object sender, EventArgs e)
        {
            // Suscripción al evento
            unEstudiante.AumentarPago += MetodoGestor;

        }
        // Método gestor ejecutado al modificar el saldo
        public void MetodoGestor(string nombre, string numControl, double cantidad)
        {
            

            MessageBox.Show($"Estimado(a) {nombre} #{numControl}: Se le notifica que el pago de su colegiatura se ha aumentado. Nuevo importe: {cantidad}");
            
            MailMessage miMensaje = new MailMessage();
            miMensaje.Subject = "Aumento su pago";
            miMensaje.To.Add(new MailAddress("juan.ahumada94@gmail.com"));
            miMensaje.From = new MailAddress(CORREO , "Juan Ahumada");
            // Si desea adjuntar algún archivo . . .
            //miMensaje.Attachments.Add(new Attachment("C:\\archivo.pdf"));
            miMensaje.Body = $"Hola {unEstudiante.Nombre} #{unEstudiante.NumControl} te notificamos que tu pago a aumentado. Tu nuevo pago es de: {unEstudiante.Cantidad}";
            CorreoElectronico miCorreoElectronico = new CorreoElectronico(SERVIDOR, PUERTO, CORREO, PASSWORD);
            miCorreoElectronico.Enviar(miMensaje);


        }
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            
            unEstudiante.Nombre = txtNombre.Text;
            unEstudiante.NumControl = txtControl.Text;
            unEstudiante.Cantidad = double.Parse(txtNuevoPago.Text);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
