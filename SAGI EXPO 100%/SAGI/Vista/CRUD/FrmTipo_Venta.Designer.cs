namespace WindowsFormsApplication1.Vista
{
    partial class FrmTipo_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipo_Venta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.apar = new System.Windows.Forms.ToolStripButton();
            this.casa = new System.Windows.Forms.ToolStripButton();
            this.terreno = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbEmpresa = new System.Windows.Forms.PictureBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.apar,
            this.casa,
            this.terreno,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 27);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(124, 24);
            this.toolStripButton4.Text = "Cerrar Formulario";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // apar
            // 
            this.apar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.apar.Image = ((System.Drawing.Image)(resources.GetObject("apar.Image")));
            this.apar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apar.Name = "apar";
            this.apar.Size = new System.Drawing.Size(106, 24);
            this.apar.Tag = "Apartamentos";
            this.apar.Text = "Apartamentos";
            this.apar.ToolTipText = "Facturacion de Apartamentos";
            this.apar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // casa
            // 
            this.casa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.casa.Image = ((System.Drawing.Image)(resources.GetObject("casa.Image")));
            this.casa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.casa.Name = "casa";
            this.casa.Size = new System.Drawing.Size(61, 24);
            this.casa.Text = "Casas";
            this.casa.ToolTipText = "Facturacion de Casas";
            this.casa.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // terreno
            // 
            this.terreno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.terreno.Image = ((System.Drawing.Image)(resources.GetObject("terreno.Image")));
            this.terreno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.terreno.Name = "terreno";
            this.terreno.Size = new System.Drawing.Size(76, 24);
            this.terreno.Text = "Terrenos";
            this.terreno.ToolTipText = "Facturacion de Terrenos";
            this.terreno.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 24);
            this.toolStripLabel1.Text = "Seleccione una opcion";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.pbEmpresa);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 27);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(914, 591);
            this.panelContenedor.TabIndex = 69;
            // 
            // pbEmpresa
            // 
            this.pbEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.pbEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpresa.Image")));
            this.pbEmpresa.Location = new System.Drawing.Point(0, 0);
            this.pbEmpresa.Name = "pbEmpresa";
            this.pbEmpresa.Size = new System.Drawing.Size(914, 591);
            this.pbEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEmpresa.TabIndex = 69;
            this.pbEmpresa.TabStop = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 24);
            this.toolStripLabel2.Text = "      Facturar      ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // FrmTipo_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 618);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipo_Venta";
            this.Text = "FrmTipo_Venta";
            this.Load += new System.EventHandler(this.FrmTipo_Venta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton apar;
        private System.Windows.Forms.ToolStripButton casa;
        private System.Windows.Forms.ToolStripButton terreno;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pbEmpresa;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}