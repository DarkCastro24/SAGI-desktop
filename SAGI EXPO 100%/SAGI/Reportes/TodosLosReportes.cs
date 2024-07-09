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
using WindowsFormsApplication1.Graficas;

namespace WindowsFormsApplication1.Reportes
{
    public partial class TodosLosReportes : Form
    {
        public TodosLosReportes()
        {
            InitializeComponent();
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
                if (control is ReporteIngresoCasas)
                {

                }
                else if (control is Expediente_Clientes)
                {

                }
                else if (control is ReporteIngresoApartamentos)
                {

                }
                else if (control is ReporteIngresoTerrenos)
                {

                }
            }
        }

        private void btnIngresoApar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<ReporteIngresoApartamentos>();
        }

        private void btnIngresoCasa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<ReporteIngresoCasas>();
        }

        private void btnIngresoTerreno_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<ReporteIngresoTerrenos>();
        }

       
        private void btnExpEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<ReporteEmpleados>();
        }

        private void TodosLosReportes_Load(object sender, EventArgs e)
        {
            FuncionesGrafica.ConseguirImagenEmpresa();
            txtLogo.Text = Constructor_Usuarios.imagenEmpresa;

            try
            {
                TextoaImagenLogo(txtLogo.Text);
            }
            catch (Exception)
            {

            }
        }

        public Image TextoaImagenLogo(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbLogo.Image = Image.FromStream(ms);
            return image;

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1229, 614);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Expediente_Clientes>();
        }
    }
}
