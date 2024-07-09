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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmGaleria : Form
    {
        public frmGaleria()
        {
            InitializeComponent();
        }

        private void frmGaleria_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnimagen1, "Ver imagen 1");
            toolTip2.SetToolTip(btnimagen2, "Ver imagen 2");
            toolTip3.SetToolTip(btnimagen3, "Ver imagen 3");
            toolTip4.SetToolTip(btnimagen4, "Ver imagen 4");
            txtimagen.Text = ConstructorGaleria.imagen1;
            TextoaImagen(txtimagen.Text);
            txtimagen2.Text = ConstructorGaleria.imagen2;
            TextoaImagen2(txtimagen2.Text);
            txtimagen3.Text = ConstructorGaleria.imagen3;
            TextoaImagen3(txtimagen3.Text);
            txtimagen4.Text = ConstructorGaleria.imagen4;                      
            TextoaImagen4(txtimagen4.Text);
            pbimagen1.Visible = true;
            pbimagen2.Visible = false;
            pbimagen3.Visible = false;
            pbimagen4.Visible = false;
        }

        public Image TextoaImagen(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbimagen1.Image = Image.FromStream(ms);
            return image;

        }

        public Image TextoaImagen2(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbimagen2.Image = Image.FromStream(ms);
            return image;

        }


        public Image TextoaImagen3(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbimagen3.Image = Image.FromStream(ms);
            return image;

        }


        public Image TextoaImagen4(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
            imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            pbimagen4.Image = Image.FromStream(ms);
            return image;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void panel2_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnimagen1_Click(object sender, EventArgs e)
        {
            pbimagen1.Visible = true;
            pbimagen2.Visible = false;
            pbimagen3.Visible = false;
            pbimagen4.Visible = false;
        }

        private void btnimagen2_Click_1(object sender, EventArgs e)
        {
            pbimagen1.Visible = false;
            pbimagen2.Visible = true;
            pbimagen3.Visible = false;
            pbimagen4.Visible = false;
        }

        private void btnimagen3_Click_1(object sender, EventArgs e)
        {
            pbimagen1.Visible = false;
            pbimagen2.Visible = false;
            pbimagen3.Visible = true;
            pbimagen4.Visible = false;
        }

        private void btnimagen4_Click_1(object sender, EventArgs e)
        {
            pbimagen1.Visible = false;
            pbimagen2.Visible = false;
            pbimagen3.Visible = false;
            pbimagen4.Visible = true;
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNormal_Click_1(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(839, 637);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnNormal.Visible = true;
            btnMaximizar.Visible = false;
        }
    }
}
