using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Reportes
{
    public partial class ReporteVenta_Terreno : Form
    {
        public ReporteVenta_Terreno()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Terreno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFactura_Terreno.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSetFactura_Terreno.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
