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
    public partial class buscar_terreno : Form
    {
        public buscar_terreno()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        funciones_terreno che = new funciones_terreno();
        private void buscar_terreno_Load(object sender, EventArgs e)
        {
            dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarTerrenos();
            this.dgvFactura.Columns[0].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFactura_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filas = dgvFactura.Rows[e.RowIndex];
                Constructor_apartamento.id_apar = Convert.ToInt32(filas.Cells[0].Value);
                Constructor_apartamento.descripcion2 = Convert.ToString(filas.Cells[4].Value);
                Constructor_apartamento.precio2 = Convert.ToInt32(filas.Cells[6].Value);
            }
            catch (Exception)
            {
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
                ConstructorTerrenos che = new ConstructorTerrenos();
                che.Precio = Convert.ToInt32(txtprecio.Text);
                dgvFactura.DataSource = funciones_terreno.BusquedaPrecio(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarTerrenos();
            }
        }

        private void txttamaño_TextChanged(object sender, EventArgs e)
        {
            if (txttamaño.Text != "")
            {
                ConstructorTerrenos che = new ConstructorTerrenos();
                che.Extension = Convert.ToInt32(txttamaño.Text);
                dgvFactura.DataSource = funciones_terreno.BusquedaArea(che);
            }
            else
            {
                dgvFactura.DataSource = funcionesBusquedaFiltrada.MostrarTerrenos();
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

        private void dgvFactura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
