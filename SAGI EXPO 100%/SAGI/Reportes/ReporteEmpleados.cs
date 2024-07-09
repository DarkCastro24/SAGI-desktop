using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Modelo;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEmpleados.DataTable' Puede moverla o quitarla según sea necesario.
            CargarReporte();
            try
            {
                cmbUsuarios.DataSource = funciones_empleado.ObtenerTipoUsuario2();
                cmbUsuarios.DisplayMember = "tipo_usuario";
                cmbUsuarios.ValueMember = "id_tipoUsuario";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.DataTableTableAdapter.BusquedaParametrizadaEmpleados(this.DataSetEmpleados.DataTable, Convert.ToInt16(cmbUsuarios.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        void CargarReporte()
        {
            this.DataTableTableAdapter.DataSetEmpleados(this.DataSetEmpleados.DataTable);
            this.reportViewer1.RefreshReport();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
