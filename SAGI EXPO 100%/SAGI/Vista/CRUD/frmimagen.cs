using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frmimagen : Form
    {
        public frmimagen()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenImagen1.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = OpenImagen1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbimagen.Image = Image.FromFile(OpenImagen1.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbimagen.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded = Convert.ToBase64String(aByte);
                    txtimagen1.Text = enconded;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminar2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenImagen2.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = OpenImagen2.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbimagen2.Image = Image.FromFile(OpenImagen2.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbimagen2.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded2 = Convert.ToBase64String(aByte);
                    txtimagen2.Text = enconded2;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminar3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenImagen3.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = OpenImagen3.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbimagen3.Image = Image.FromFile(OpenImagen3.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbimagen3.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded3 = Convert.ToBase64String(aByte);
                    txtimagen3.Text = enconded3;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminar4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenImagen4.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivo de Imagen (.png) |*.png| Archivo de Imagen (.jpeg) |*.jpge| Todos los Archivos|*.*";
                DialogResult resultado = OpenImagen4.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbimagen4.Image = Image.FromFile(OpenImagen4.FileName);
                    MemoryStream ms = new MemoryStream();
                    pbimagen4.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    string enconded4 = Convert.ToBase64String(aByte);
                    txtimagen4.Text = enconded4;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la imagen", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmimagen_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnExaminar, "Seleccionar la imagen que se va a ingresar");
            toolTip2.SetToolTip(btnExaminar2, "Seleccionar la imagen que se va a ingresar");
            toolTip3.SetToolTip(btnExaminar3, "Seleccionar la imagen que se va a ingresar");
            toolTip4.SetToolTip(btnExaminar4, "Seleccionar la imagen que se va a ingresar");

            if (ConstructorGaleria.id_apartamento != 0)
            {
                lblInmueble.Text = "Ingrese 4 imagenes del Apartamento";
            }
            else if (ConstructorGaleria.id_terreno != 0)
            {
                lblInmueble.Text = "Ingrese 4 imagenes del Terreno";
            }
            else if (ConstructorGaleria.id_casa != 0)
            {
                lblInmueble.Text = "Ingrese 4 imagenes de la Casa";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtimagen1.Text.Trim() == "" || txtimagen2.Text.Trim() == "" || txtimagen3.Text.Trim() == "" || txtimagen4.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese 4 imagenes para poder continuar");
            }
            else
            {
                ConstructorGaleria.imagen1 = txtimagen1.Text;
                ConstructorGaleria.imagen2 = txtimagen2.Text;
                ConstructorGaleria.imagen3 = txtimagen3.Text;
                ConstructorGaleria.imagen4 = txtimagen4.Text;

                try
                {
                    if (ConstructorGaleria.id_apartamento != 0)
                    {
                        //Ingresar imagen para terreno
                        int retorno = funcionesBusquedaFiltrada.IngresarImagenApar();
                        if (retorno <= 1)
                        {
                            MessageBox.Show("Las imagenes fueron ingresadas a la base de datos", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("CHEPIADA");
                        }
                    }
                    else if (ConstructorGaleria.id_terreno != 0)
                    {
                        //Ingresar imagen para apartamento
                        int retorno = funcionesBusquedaFiltrada.IngresarImagenTerreno();
                        if (retorno <= 1)
                        {
                            MessageBox.Show("Las imagenes fueron ingresadas a la base de datos", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("CHEPIADA");
                        }
                    }
                    else if (ConstructorGaleria.id_casa != 0)
                    {
                        //Ingresar imagen para casa
                        int retorno = funcionesBusquedaFiltrada.IngresarImagenCasa();
                        if (retorno <= 1)
                        {
                            MessageBox.Show("Las imagenes fueron ingresadas a la base de datos", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("CHEPIADA");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ingresar la imagen");
                }
            }

        }

        private void toolStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ConstructorGaleria.Actualizar_Agregar == "Validar")
            {
                if (MessageBox.Show("Esta seguro que desea salir", "Quiere salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            else
            {
                if (MessageBox.Show("Si sale cierra la ventana perdera todo el proceso de insercion de datos que lleva hasta este momento", "Seguro que desea salir de la aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (lblInmueble.Text == "Apartamento")
                    {
                        funcionesBusquedaFiltrada.EliminarProgresoApar();
                        this.Hide();
                    }

                    else if (lblInmueble.Text == "Terreno")
                    {
                        funcionesBusquedaFiltrada.EliminarProgresoTerreno();
                        this.Hide();
                    }
                    else if (lblInmueble.Text == "Casa")
                    {
                        funcionesBusquedaFiltrada.EliminarProgresoCasa();
                        this.Hide();
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
