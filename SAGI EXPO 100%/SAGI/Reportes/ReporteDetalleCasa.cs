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
    public partial class ReporteDetalleCasa : Form
    {
        public ReporteDetalleCasa()
        {
            InitializeComponent();
        }

        private void ReporteDetalleCasa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDetalleCasa.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.DetalleCasa(this.DataSetDetalleCasa.DataTable, ConstructorGaleria.ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
