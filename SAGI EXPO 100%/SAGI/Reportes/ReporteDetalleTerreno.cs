using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Controlador.Constructor_CRUD;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteDetalleTerreno : Form
    {
        public ReporteDetalleTerreno()
        {
            InitializeComponent();
        }

        private void ReporteDetalleTerreno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDetalleTerreno.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.DetalleTerreno(this.DataSetDetalleTerreno.DataTable,ConstructorGaleria.ID);
            this.reportViewer1.RefreshReport();
        }
    }
}
