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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class historialFactura_Apar : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        public historialFactura_Apar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void historialFactura_Apar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = facturacion_apar.Historial();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            constructor_factura che = new constructor_factura();
            che.fecha = dtpNacimiento.Text;
            dataGridView1.DataSource = facturacion_apar.BusquedaFiltrada(che);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
            }
            catch (Exception)
            {
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro de eliminar factura?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    constructor_factura kk = new constructor_factura();
                    kk.id_factura = Convert.ToInt16(txtID.Text);
                    facturacion_apar.EliminarFactura(kk);
                    dataGridView1.DataSource = facturacion_apar.Historial();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = facturacion_apar.Historial();
        }
    }
}
