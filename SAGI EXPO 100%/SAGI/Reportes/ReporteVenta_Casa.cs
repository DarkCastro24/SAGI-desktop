using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Reportes;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteVenta_Casa : Form
    {
        public ReporteVenta_Casa()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Casa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura_Casa.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSetFactura_Casa.DataTable);
            this.reportViewer1.RefreshReport();
        }
    }
}
