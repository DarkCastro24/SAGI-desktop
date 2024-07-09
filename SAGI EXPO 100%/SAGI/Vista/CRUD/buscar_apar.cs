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
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Vista.CRUD;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class buscar_apar : Form
    {
        public buscar_apar()
        {
            InitializeComponent();
            txtprecio.ContextMenu = new ContextMenu();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        public void ValidacionSoloLetrasyNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void buscar_apar_Load(object sender, EventArgs e)
        {
            dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            this.dgvFactura.Columns[0].Visible = false;
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filas = dgvFactura.Rows[e.RowIndex];
                Constructor_apartamento kk = new Constructor_apartamento();
                Constructor_apartamento.id_apar = Convert.ToInt32(filas.Cells[0].Value);
                Constructor_apartamento.descripcion2 = Convert.ToString(filas.Cells[4].Value);
                Constructor_apartamento.precio2 = Convert.ToInt32(filas.Cells[3].Value);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionSoloLetrasyNumeros(e);
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtprecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

            if (txtArea.Text != "")
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.area = Convert.ToInt32(txtArea.Text);
                dgvFactura.DataSource = funciones_apartamento.BusquedaArea(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            }
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            if (txtprecio.Text != "")
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.precio = Convert.ToInt32(txtprecio.Text);
                dgvFactura.DataSource = funciones_apartamento.BusquedaFiltrada(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarApartamentos();
            }
        }
    }
}
