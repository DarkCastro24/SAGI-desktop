using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Vista
{
    public partial class Primer_uso : Form
    {
        public Primer_uso()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AgregarDatos()
        {
            Constructor_empresa agregar = new Constructor_empresa();
            agregar.nombre = txtNombreEmpresa.Text;
            agregar.domicilio = txtDireccion.Text;
            agregar.telefono = txtTelefono.Text;
            int datos = PrimerUso.Empresa(agregar);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();

            Abrir.Filter = "Archivos PNG(* .png) |*.png";
            Abrir.InitialDirectory = "D:";

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                String Dir = Abrir.FileName;
                Bitmap Picture = new Bitmap(Dir);

                Logo.Image = (Image)Picture;
            }
        }

        private void Primer_uso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin kk = new frmLogin();
            kk.Show();        
        }
    }
}
