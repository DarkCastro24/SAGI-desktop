using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructores;
using WindowsFormsApplication1.Controlador.Constructores_CRUD;
using WindowsFormsApplication1.Interfaces;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmRoot : Form
    {
        public frmRoot()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnConfiguracion, "Configuracion personal de su usuario");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        Form currentForm;
        private void AbrirFormEnPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel3.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panel3.Controls.Remove(currentForm);
                }

                currentForm = formulario;
                panel3.Controls.Add(formulario);
                panel3.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            foreach (var control in panel3.Controls)
            {
                if (control is frmExpCliente)
                {

                }
                else if (control is frmExpEmpleados)
                {

                }
                else if (control is frmExpEmpleados)
                {

                }
            }
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnNormal.Visible = true;
            btnMaximizar.Visible = false;
            ResponsiveManual();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?","¿Seguro que desea salir?",MessageBoxButtons.YesNo,MessageBoxIcon.Information ) == DialogResult.Yes)
            {
                Application.Exit();
            }       
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1280, 720);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
            MostrarSegunNivel();
        }

        public Image TextoaImagenFotoPerfil(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbimagen.Image = Image.FromStream(ms);
            return image;

        }

        void MostrarSegunNivel()
        {
            btnConfiguracion.Location = new Point(185, 132); // normal 13
            pbimagen.Location = new Point(12, 132); // normal 132
            pbimagen.Size = new Size(80, 64); 
            lblUsuario.Location = new Point(103, 142); // normal 142
            lblNivek.Location = new Point(103, 181); // normal 181

            if (Constructor_Login.nivel == 1)
            {
                btnEmpresa.Location = new Point(0, 244);
                btnExpedienteEmpleado.Location = new Point(0, 304);
                btnPropiedades.Location = new Point(0, 364);
                btnExpedienteCliente.Location = new Point(0, 424);
                btnCita.Location = new Point(0, 484);
                btnVenta.Location = new Point(0, 544);
                btnEstadisticas.Location = new Point(0, 604);
                
                lblNivek.Text = "Root";
            }
            else if (Constructor_Login.nivel == 2)
            {
                ocultar();
                btnExpedienteEmpleado.Location = new Point(0, 244);
                btnExpedienteEmpleado.Visible = true;
                btnPropiedades.Location = new Point(0, 314);
                btnPropiedades.Visible = true;
                btnExpedienteCliente.Location = new Point(0, 384);
                btnExpedienteCliente.Visible = true;
                btnCita.Location = new Point(0, 454);
                btnCita.Visible = true;
                btnVenta.Location = new Point(0, 524);
                btnVenta.Visible = true;
                btnEstadisticas.Visible = true;
                btnEstadisticas.Location = new Point(0, 594);
                lblNivek.Text = "Administrador";
            }
            else
            {
                ocultar();
                btnExpedienteCliente.Location = new Point(0, 244);
                btnExpedienteCliente.Visible = true;
                btnPropiedades.Location = new Point(0, 304);
                btnPropiedades.Visible = true;
                btnCita.Location = new Point(0, 364);
                btnCita.Visible = true;
                btnVenta.Location = new Point(0, 424);
                btnVenta.Visible = true;
                lblNivek.Text = "Corredor";
            }
        }

        void ResponsiveManual()
        {
            btnConfiguracion.Location = new Point(190, 152); // normal 137
            pbimagen.Location = new Point(12, 137); // normal 137
            pbimagen.Size = new Size(83, 105);
            lblUsuario.Location = new Point(113, 157); // normal 147
            lblNivek.Location = new Point(113, 196); // normal 186

            if (Constructor_Login.nivel == 1)
            {
               
                btnEmpresa.Location = new Point(0, 244);
                btnExpedienteEmpleado.Location = new Point(0, 304);
                btnPropiedades.Location = new Point(0, 364);
                btnExpedienteCliente.Location = new Point(0, 424);
                btnCita.Location = new Point(0, 484);
                btnVenta.Location = new Point(0, 544);
                btnEstadisticas.Location = new Point(0, 604);

                lblNivek.Text = "Root";
            }
            else if (Constructor_Login.nivel == 2)
            {
                ocultar();
                btnExpedienteEmpleado.Location = new Point(0, 244);
                btnExpedienteEmpleado.Visible = true;
                btnPropiedades.Location = new Point(0, 304);
                btnPropiedades.Visible = true;
                btnExpedienteCliente.Location = new Point(0, 364);
                btnExpedienteCliente.Visible = true;
                btnCita.Location = new Point(0, 424);
                btnCita.Visible = true;
                btnVenta.Location = new Point(0, 484);
                btnVenta.Visible = true;
                btnEstadisticas.Visible = true;
                btnEstadisticas.Location = new Point(0, 544);
                lblNivek.Text = "Administrador";
            }
            else
            {
                ocultar();
                btnExpedienteCliente.Location = new Point(0, 244);
                btnExpedienteCliente.Visible = true;
                btnPropiedades.Location = new Point(0, 304);
                btnPropiedades.Visible = true;
                btnCita.Location = new Point(0, 364);
                btnCita.Visible = true;
                btnVenta.Location = new Point(0, 424);
                btnVenta.Visible = true;
                lblNivek.Text = "Corredor";
            }
        }

        public void ocultar()
        {
            btnEmpresa.Visible = false;
            btnPropiedades.Visible = false;
            btnCita.Visible = false;
            btnExpedienteCliente.Visible = false;
            btnExpedienteEmpleado.Visible = false;
            btnVenta.Visible = false;
            btnEstadisticas.Visible = false;
        }

        private void frmRoot_Load(object sender, EventArgs e)
        {
            if (ConstructorConfiguracion.Validacion == "yes")
            {
                if (MessageBox.Show("Desea configurar los datos de su usuario","Desea continuar",MessageBoxButtons.YesNo,MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    AbrirFormEnPanel<frmConfiguracion>();
                    ConstructorConfiguracion.Validacion = "nel";
                }
                else
                {
                    btnNormal.Visible = false;
                    lblUsuario.Text = Constructor_Login.usuario;
                    lblConectado.Text = Constructor_Login.Nombre_Usuario;
                    txtimagen.Text = Constructor_Login.Imagen_Usuario;
                    txtEmpresa.Text = Constructor_Login.Imagen_Empresa;
                    MostrarSegunNivel();
                    try
                    {
                        TextoaImagenFotoPerfil(txtimagen.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            else
            {
                btnNormal.Visible = false;
                lblUsuario.Text = Constructor_Login.usuario;
                lblConectado.Text = Constructor_Login.Nombre_Usuario;
                txtimagen.Text = Constructor_Login.Imagen_Usuario;
                txtEmpresa.Text = Constructor_Login.Imagen_Empresa;
                MostrarSegunNivel();
                try
                {
                    TextoaImagenFotoPerfil(txtimagen.Text);
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmEmpresa>();
        }

        private void btnExpedienteEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpEmpleados>();
        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Tipo_propiedades>();
        }

        private void btnExpedienteCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpCliente>();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmCita>();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmTipo_Venta>();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesion en el sistema?", "¿Seguro que desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                frmLogin che = new frmLogin();
                che.Show();
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmConfiguracion>();
        }

        private void lblNivek_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmEstadisticas>();
        }
    }    
}
