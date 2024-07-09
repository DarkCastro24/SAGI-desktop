using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class buscar_casa : Form
    {
        public buscar_casa()
        {
            InitializeComponent();
            txtprecio.ContextMenu = new ContextMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filas = dgvFactura.Rows[e.RowIndex];
                Constructor_apartamento kk = new Constructor_apartamento();
                Constructor_apartamento.id_apar = Convert.ToInt32(filas.Cells[0].Value);
                Constructor_apartamento.descripcion2 = Convert.ToString(filas.Cells[5].Value);
                Constructor_apartamento.precio2 = Convert.ToInt32(filas.Cells[3].Value);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buscar_casa_Load(object sender, EventArgs e)
        {
            dgvFactura.DataSource = funcionesBusquedaFiltrada.ObtenerCasas();
            this.dgvFactura.Columns[0].Visible = false;
        }

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
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

            if (txtprecio.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.precio = Convert.ToInt32(txtprecio.Text);
                dgvFactura.DataSource = funciones_casa.BusquedaPrecio(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.ObtenerCasas();
            }
        }

        private void txttamaño_TextChanged(object sender, EventArgs e)
        {
            if (txttamaño.Text != "")
            {
                Constructor_casa che = new Constructor_casa();
                che.area_casa = Convert.ToInt32(txttamaño.Text);
                dgvFactura.DataSource = funciones_casa.BusquedaArea(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.ObtenerCasas();
            }
        }

        private void txttamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SolamenteNumerosEnteros(e);
        }
    }
}
