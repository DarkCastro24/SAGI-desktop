namespace WindowsFormsApplication1.Reportes
{
    partial class ReporteVenta_Casa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFactura_Casa = new WindowsFormsApplication1.Reportes.DataSetFactura_Casa();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetDetalleTerreno = new WindowsFormsApplication1.Reportes.DataSetDetalleTerreno();
            this.dataSetDetalleTerrenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFacturaCasaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFacturaCasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new WindowsFormsApplication1.Reportes.DataSetFactura_CasaTableAdapters.DataTableTableAdapter();
            this.dataSetFacturaCasaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura_Casa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleTerreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleTerrenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSetFactura_Casa;
            // 
            // DataSetFactura_Casa
            // 
            this.DataSetFactura_Casa.DataSetName = "DataSetFactura_Casa";
            this.DataSetFactura_Casa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetDetalleTerreno
            // 
            this.dataSetDetalleTerreno.DataSetName = "DataSetDetalleTerreno";
            this.dataSetDetalleTerreno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetDetalleTerrenoBindingSource
            // 
            this.dataSetDetalleTerrenoBindingSource.DataSource = this.dataSetDetalleTerreno;
            this.dataSetDetalleTerrenoBindingSource.Position = 0;
            // 
            // dataSetFacturaCasaBindingSource1
            // 
            this.dataSetFacturaCasaBindingSource1.DataSource = this.DataSetFactura_Casa;
            this.dataSetFacturaCasaBindingSource1.Position = 0;
            // 
            // dataSetFacturaCasaBindingSource
            // 
            this.dataSetFacturaCasaBindingSource.DataSource = this.DataSetFactura_Casa;
            this.dataSetFacturaCasaBindingSource.Position = 0;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetFacturaCasaBindingSource2
            // 
            this.dataSetFacturaCasaBindingSource2.DataSource = this.DataSetFactura_Casa;
            this.dataSetFacturaCasaBindingSource2.Position = 0;
            // 
            // ReporteVenta_Casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 612);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVenta_Casa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVenta_Casa";
            this.Load += new System.EventHandler(this.ReporteVenta_Casa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura_Casa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleTerreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleTerrenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaCasaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSetFactura_Casa DataSetFactura_Casa;
        private DataSetFactura_CasaTableAdapters.DataTableTableAdapter DataTableTableAdapter;
        private System.Windows.Forms.BindingSource dataSetFacturaCasaBindingSource;
        private System.Windows.Forms.BindingSource dataSetFacturaCasaBindingSource1;
        private DataSetDetalleTerreno dataSetDetalleTerreno;
        private System.Windows.Forms.BindingSource dataSetDetalleTerrenoBindingSource;
        private System.Windows.Forms.BindingSource dataSetFacturaCasaBindingSource2;
    }
}