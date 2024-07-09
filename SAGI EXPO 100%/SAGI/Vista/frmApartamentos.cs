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

namespace WindowsFormsApplication1.Interfaces
{
    public partial class frmApartamentos : Form
    {
        public frmApartamentos()
        {
            InitializeComponent();
            dgvUsuarios.DataSource = funciones_apartamento.Mostrar();
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardarBien.Enabled = true;
            btnSuprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtID.Text = Convert.ToString(fila.Cells[0].Value);
                cmbEstado.Text = Convert.ToString(fila.Cells[1].Value);
                cmbDepartameto.Text = Convert.ToString(fila.Cells[2].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells[3].Value);
                txtDescripcion.Text = Convert.ToString(fila.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(fila.Cells[5].Value);
                txtMunicipio.Text = Convert.ToString(fila.Cells[6].Value);
                txtPiso.Text = Convert.ToString(fila.Cells[7].Value);
                txtCuartos.Text = Convert.ToString(fila.Cells[8].Value);
                txtBaños.Text = Convert.ToString(fila.Cells[9].Value);
                txtArea.Text = Convert.ToString(fila.Cells[10].Value);
                txtEdificio.Text = Convert.ToString(fila.Cells[11].Value);
                btnGuardarBien.Enabled = false;
                btnEditar.Enabled = true;
                btnSuprimir.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ComboBox()
        {

            try
            {
                if (funciones_apartamento.ObtenerEstadoApar() != null)
                {
                    cmbEstado.DataSource = funciones_apartamento.ObtenerEstadoApar();
                    cmbEstado.DisplayMember = "estado_apar";
                    cmbEstado.ValueMember = "id_estadoApar";
                }

                if (funciones_apartamento.ObtenerDepartamento() != null)
                {
                    cmbDepartameto.DataSource = funciones_apartamento.ObtenerDepartamento();
                    cmbDepartameto.DisplayMember = "departamento_apar";
                    cmbDepartameto.ValueMember = "id_departamentoApar";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmApartamentos_Load(object sender, EventArgs e)
        {
            ComboBox();
        }
    }
}
