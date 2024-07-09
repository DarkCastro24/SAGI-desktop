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
using WindowsFormsApplication1.Controlador.Constructor_CRUD;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Vista.CRUD
{
    public partial class frm_ventaTerr : Form
    {
        public frm_ventaTerr()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_terreno kk = new buscar_terreno();
                kk.ShowDialog();
                if (kk != null)
                {
                    txtID.Text = Convert.ToString(Constructor_apartamento.id_apar);
                    txtApar.Text = Constructor_apartamento.descripcion2;
                    txtPrecio.Text = Convert.ToString(Constructor_apartamento.precio2);
                    /*Operacion matemática*/

                    double comision = Convert.ToDouble((Constructor_apartamento.precio2 * 5) / 100);
                    double impuesto = Convert.ToDouble((Constructor_apartamento.precio2 * 13) / 100);
                    double total = comision + impuesto + Constructor_apartamento.precio2;
                    txtTotal.Text = Convert.ToString(total);

                }
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingresar();
            facturacion_terreno.ConseguirImagenesApar();
            txtIDdetalle.Text = Convert.ToString(constructor_factura.Id);
        }
        public void Ingresar()
        {
            //try
            //{
                if (txtApar.Text.Trim() == "" || txtPrecio.Text.Trim() == "" || txtImpuesto.Text.Trim() == "" || txtTotal.Text.Trim() == "" || txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    constructor_factura che = new constructor_factura();
                    che.Id_apar = Convert.ToInt16(txtID.Text);
                    che.iva = Convert.ToDouble(txtImpuesto.Text);
                    che.subtotal = Convert.ToDouble(txtPrecio.Text);
                    che.comision = Convert.ToDouble(txtComision.Text);
                    int datos = facturacion_terreno.IngresarDet(che);
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("El detalle de factura no pudo ser ingresado");
            //}
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                buscar_cliente kk = new buscar_cliente();
                kk.ShowDialog();
                if (kk != null)
                {
                    txtIDCliente.Text = Convert.ToString(constructor_factura.id_cliente);
                    txtCliente.Text = constructor_factura.cliente;

                }
            }
            catch (Exception)
            {

            }
        }

        private void frm_ventaTerr_Load(object sender, EventArgs e)
        {
            try
            {
                if (facturacion_apar.ObtenerEstadoFactura() != null)
                {
                    cmbEstado.DataSource = facturacion_apar.ObtenerEstadoFactura();
                    cmbEstado.DisplayMember = "estado_factura";
                    cmbEstado.ValueMember = "id_estado";
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            IngresarFactura();
            ActuCliente();
            Limpiar();
            dgvFactura.DataSource = facturacion_terreno.mostrar();
        }

        public void ActuCliente()
        {
            if (txtIDCliente.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Constructor_apartamento che = new Constructor_apartamento();
                che.id_cliente = Convert.ToInt32(txtIDCliente.Text);
                facturacion_terreno.ActualizaCliente(che);
            }
        }
        public void IngresarFactura()
        {
            try
            {
                if (txtIDdetalle.Text.Trim() == "")
                {
                    MessageBox.Show("No se ha creado ningun detalle", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtCliente.Text.Trim() == "")
                {
                    MessageBox.Show("Complete todos los campos que se le solicitan", "Existen campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    constructor_factura che = new constructor_factura();

                    constructor_factura.total = Convert.ToDouble(txtTotal.Text);
                    che.estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    che.fecha = Convert.ToString(dtpNacimiento.Text);
                    che.detalle = Convert.ToInt16(txtIDdetalle.Text);
                    constructor_factura.total = Convert.ToDouble(txtTotal.Text);
                    int datos = facturacion_terreno.IngresaeFactura(che);
                    dgvFactura.DataSource = facturacion_terreno.mostrar();
                }
            }
            catch (Exception)
            {

            }
        }

        public void Limpiar()
        {
            txtIDdetalle.Clear();
            txtID.Clear();
            txtIDCliente.Clear();
            txtTotal.Clear();
            txtPrecio.Clear();
            txtCliente.Clear();
            txtApar.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro de eliminar factura?", "Mensaje de advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    constructor_factura kk = new constructor_factura();
                    kk.id_factura = Convert.ToInt16(txtIDFact.Text);
                    facturacion_terreno.EliminarFactura(kk);
                    dgvFactura.DataSource = facturacion_terreno.mostrar();
                }
            }
            catch (Exception)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtApar.Clear();
            txtTotal.Clear();
            txtPrecio.Clear();
            txtID.Clear();
            txtCliente.Clear();
            txtIDCliente.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvFactura.Rows[e.RowIndex];
                txtIDFact.Text = Convert.ToString(fila.Cells[0].Value);
            }
            catch (Exception)
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReporteVenta_Terreno kk = new ReporteVenta_Terreno();
            kk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvFactura.DataSource = facturacion_terreno.mostrar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            historialFactura_Terreno kk = new historialFactura_Terreno();
            kk.Show();
        }
    }
}
