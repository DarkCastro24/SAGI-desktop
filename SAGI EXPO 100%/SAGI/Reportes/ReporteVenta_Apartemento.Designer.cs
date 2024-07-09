namespace WindowsFormsApplication1.Reportes
{
    partial class ReporteVenta_Apartemento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFactura_Apar = new WindowsFormsApplication1.Reportes.DataSetFactura_Apar();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableTableAdapter = new WindowsFormsApplication1.Reportes.DataSetFactura_AparTableAdapters.DataTableTableAdapter();
            this.dataSetIngresoTerrenos = new WindowsFormsApplication1.Reportes.DataSetIngresoTerrenos();
            this.dataSetIngresoTerrenosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFacturaAparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.info_Apar = new WindowsFormsApplication1.Reportes.Info_Apar();
            this.infoAparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoAparBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura_Apar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresoTerrenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresoTerrenosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaAparBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_Apar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAparBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAparBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.DataSetFactura_Apar;
            // 
            // DataSetFactura_Apar
            // 
            this.DataSetFactura_Apar.DataSetName = "DataSetFactura_Apar";
            this.DataSetFactura_Apar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(959, 753);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetIngresoTerrenos
            // 
            this.dataSetIngresoTerrenos.DataSetName = "DataSetIngresoTerrenos";
            this.dataSetIngresoTerrenos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetIngresoTerrenosBindingSource
            // 
            this.dataSetIngresoTerrenosBindingSource.DataSource = this.dataSetIngresoTerrenos;
            this.dataSetIngresoTerrenosBindingSource.Position = 0;
            // 
            // dataSetFacturaAparBindingSource
            // 
            this.dataSetFacturaAparBindingSource.DataSource = this.DataSetFactura_Apar;
            this.dataSetFacturaAparBindingSource.Position = 0;
            // 
            // info_Apar
            // 
            this.info_Apar.DataSetName = "Info_Apar";
            this.info_Apar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoAparBindingSource
            // 
            this.infoAparBindingSource.DataSource = this.info_Apar;
            this.infoAparBindingSource.Position = 0;
            // 
            // infoAparBindingSource1
            // 
            this.infoAparBindingSource1.DataSource = this.info_Apar;
            this.infoAparBindingSource1.Position = 0;
            // 
            // ReporteVenta_Apartemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 753);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteVenta_Apartemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVenta_Apartemento";
            this.Load += new System.EventHandler(this.ReporteVenta_Apartemento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFactura_Apar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresoTerrenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIngresoTerrenosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFacturaAparBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_Apar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAparBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAparBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private DataSetFactura_Apar DataSetFactura_Apar;
        private DataSetFactura_AparTableAdapters.DataTableTableAdapter DataTableTableAdapter;
        private DataSetIngresoTerrenos dataSetIngresoTerrenos;
        private System.Windows.Forms.BindingSource dataSetIngresoTerrenosBindingSource;
        private System.Windows.Forms.BindingSource dataSetFacturaAparBindingSource;
        private System.Windows.Forms.BindingSource infoAparBindingSource;
        private Info_Apar info_Apar;
        private System.Windows.Forms.BindingSource infoAparBindingSource1;
    }
}