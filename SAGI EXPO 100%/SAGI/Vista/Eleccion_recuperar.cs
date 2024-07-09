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

namespace WindowsFormsApplication1
{
    public partial class Eleccion_recuperar : Form
    {
        public Eleccion_recuperar()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void Eleccion_recuperar_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRecuperarContraseña Recu = new frmRecuperarContraseña();
            Recu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recuperación_correo kk = new Recuperación_correo();
            kk.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
