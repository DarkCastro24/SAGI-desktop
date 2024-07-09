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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class buscar_cliente : Form
    {
        public buscar_cliente()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

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
            try
            {
                DataGridViewRow filas = dgvFactura.Rows[e.RowIndex];
                constructor_factura kk = new constructor_factura();
                constructor_factura.id_cliente = Convert.ToInt32(filas.Cells[0].Value);
                constructor_factura.cliente = Convert.ToString(filas.Cells[5].Value);
            }
            catch (Exception)
            {
                
            }   
        }

        private void buscar_cliente_Load(object sender, EventArgs e)
        {
            dgvFactura.DataSource = funciones_cliente.Mostrar();
            this.dgvFactura.Columns[0].Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "")
            {
                ConstructorExpedienteCliente che = new ConstructorExpedienteCliente();
                che.telefono = txtTelefono.Text;
                dgvFactura.DataSource = funciones_cliente.BuscarTelefono(che);
            }
            else if (txtTelefono.Text == "")
            {
                dgvFactura.DataSource = funciones_cliente.Mostrar();
            }
        }

        private void txtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDUI.Text != "")
            {
                ConstructorExpedienteCliente che = new ConstructorExpedienteCliente();
                che.dui = txtDUI.Text;
                dgvFactura.DataSource = funciones_cliente.BuscarCliente(che);
            }
            else if (txtDUI.Text == "")
            {
                dgvFactura.DataSource = funciones_cliente.Mostrar();
            }
        }
    }
}
