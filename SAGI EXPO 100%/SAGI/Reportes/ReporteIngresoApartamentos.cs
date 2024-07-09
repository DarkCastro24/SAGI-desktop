using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo.Funciones_CRUD;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteIngresoApartamentos : Form
    {
        public ReporteIngresoApartamentos()
        {
            InitializeComponent();
        }

        void CargarReporte()
        {
            this.DataTableTableAdapter.IngresoApartamentos(this.DataSetIngresoApartamentos.DataTable);
            this.reportViewer1.RefreshReport();
        }
        private void ReporteIngresoApartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetIngresoApartamentos.DataTable' Puede moverla o quitarla según sea necesario.
            CargarReporte();
            try
            {
                cmbDepartamentos.DataSource = Municipio.ObtenerDepartamentos();
                cmbDepartamentos.DisplayMember = "departamento";
                cmbDepartamentos.ValueMember = "id_departamento";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.DataTableTableAdapter.ConsultaParametrizadaApartamento(this.DataSetIngresoApartamentos.DataTable, Convert.ToInt16(cmbDepartamentos.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
