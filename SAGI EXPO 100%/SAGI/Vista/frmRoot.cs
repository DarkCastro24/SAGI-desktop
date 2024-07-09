using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Vista;


namespace WindowsFormsApplication1
{
    public partial class frmRoot : Form
    {
        public frmRoot()
        {
            InitializeComponent();            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpEmpleados>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<w>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmDetalle>();
        }

        private void btnCorredor_Click(object sender, EventArgs e)
        {

        }

        private void MenuDeslizar_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 236)
            {
                Menu.Width = 44;
                pictureBox1.Visible = false;
                button1.Visible = false;   
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            else
            {
                Menu.Width = 236;
                pictureBox1.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnMaximizar.Visible = false;
        }
        Form currentForm;

        private void AbrirFormEnPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Buscar la coleccion del formulario
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
                else if (control is frmDetalle)
                {

                }
                else
                {

                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpCliente>();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            frmLogin Cerrar = new frmLogin();
            Cerrar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpEmpleados>();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmCita>();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpEmpleados>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpEmpleados>();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<frmExpCliente>();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Tipo_propiedades>();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de cerrar sesión?", "Mensaje de advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                frmLogin Cerrar = new frmLogin();
                Cerrar.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void frmRoot_Load(object sender, EventArgs e)
        {
            btnNormal.Visible = false;
            lblUsuario.Text = constructorLogin.Usuario;
            lblConectado.Text = constructorLogin.nombre;
            if (constructorLogin.nivel == 1)
            {
                button1.Location = new Point(3, 252);
                button4.Location = new Point(3, 311);
                button6.Location = new Point(3, 370);
                button5.Location = new Point(3, 429);
                button7.Location = new Point(3, 488);
                lblNivek.Text = "Root";
            }
            else if (constructorLogin.nivel == 2)
            {
                ocultar();
                button1.Location = new Point(3, 252);
                button1.Visible = true;
                button4.Location = new Point(3, 311);
                button4.Visible = true;
                button6.Location = new Point(3, 370);
                button6.Visible = true;
                lblNivek.Text = "Administrador";
            }
            else
            {
                ocultar();
                button4.Location = new Point(3, 252);
                button4.Visible = true;
                button6.Location = new Point(3, 311);
                button6.Visible = true;
                button5.Location = new Point(3, 370);
                button5.Visible = true;
                button7.Location = new Point(3, 429);
                button7.Visible = true;
                lblNivek.Text = "Corredor";
            }
        }

            public void ocultar()
            {
                button1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel<FrmTipo_Venta>();
        }
    }
}
