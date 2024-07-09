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
    public partial class ReporteIngresoTerrenos : Form
    {
        public ReporteIngresoTerrenos()
        {
            InitializeComponent();
        }

        void MostrarReporte()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetIngresoTerrenos.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.TerrenosIngresados(this.DataSetIngresoTerrenos.DataTable);
            this.reportViewer1.RefreshReport();
        }
        private void ReporteIngresoTerrenos_Load(object sender, EventArgs e)
        {
            MostrarReporte();
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
            this.DataTableTableAdapter.ConsultaParametrizadaTerrenos(this.DataSetIngresoTerrenos.DataTable,Convert.ToInt16(cmbDepartamentos.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
