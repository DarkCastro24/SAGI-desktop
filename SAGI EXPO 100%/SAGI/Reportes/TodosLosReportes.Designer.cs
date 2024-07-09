namespace WindowsFormsApplication1.Reportes
{
    partial class TodosLosReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosLosReportes));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngresoTerreno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngresoCasa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngresoApar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.MenuTop.Controls.Add(this.pictureBox2);
            this.MenuTop.Controls.Add(this.btnMaximizar);
            this.MenuTop.Controls.Add(this.btnCerrar);
            this.MenuTop.Controls.Add(this.btnNormal);
            this.MenuTop.Controls.Add(this.txtLogo);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(4);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1639, 39);
            this.MenuTop.TabIndex = 2;
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1532, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Minimizar";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1567, 6);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 76;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Tag = "Maximizar";
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1601, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 75;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Tag = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1567, 6);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(29, 30);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 77;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 39);
            this.SidebarWrapper.Margin = new System.Windows.Forms.Padding(4);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(396, 717);
            this.SidebarWrapper.TabIndex = 3;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.btnExpEmpleado);
            this.Sidebar.Controls.Add(this.btnIngresoTerreno);
            this.Sidebar.Controls.Add(this.btnIngresoCasa);
            this.Sidebar.Controls.Add(this.btnIngresoApar);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pbLogo);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(98)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 4);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(360, 699);
            this.Sidebar.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "              EXPEDIENTE DE CLIENTES";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 403);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(336, 63);
            this.bunifuFlatButton1.TabIndex = 23;
            this.bunifuFlatButton1.Text = "              EXPEDIENTE DE CLIENTES";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnExpEmpleado
            // 
            this.btnExpEmpleado.Activecolor = System.Drawing.Color.Transparent;
            this.btnExpEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnExpEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpEmpleado.BorderRadius = 0;
            this.btnExpEmpleado.ButtonText = "              EXPEDIENTE DE EMPLEADOS";
            this.btnExpEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnExpEmpleado.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExpEmpleado.Iconimage")));
            this.btnExpEmpleado.Iconimage_right = null;
            this.btnExpEmpleado.Iconimage_right_Selected = null;
            this.btnExpEmpleado.Iconimage_Selected = null;
            this.btnExpEmpleado.IconMarginLeft = 0;
            this.btnExpEmpleado.IconMarginRight = 0;
            this.btnExpEmpleado.IconRightVisible = true;
            this.btnExpEmpleado.IconRightZoom = 0D;
            this.btnExpEmpleado.IconVisible = true;
            this.btnExpEmpleado.IconZoom = 50D;
            this.btnExpEmpleado.IsTab = false;
            this.btnExpEmpleado.Location = new System.Drawing.Point(12, 517);
            this.btnExpEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpEmpleado.Name = "btnExpEmpleado";
            this.btnExpEmpleado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExpEmpleado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExpEmpleado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExpEmpleado.selected = false;
            this.btnExpEmpleado.Size = new System.Drawing.Size(336, 52);
            this.btnExpEmpleado.TabIndex = 21;
            this.btnExpEmpleado.Text = "              EXPEDIENTE DE EMPLEADOS";
            this.btnExpEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpEmpleado.Textcolor = System.Drawing.Color.LightGray;
            this.btnExpEmpleado.TextFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpEmpleado.Click += new System.EventHandler(this.btnExpEmpleado_Click);
            // 
            // btnIngresoTerreno
            // 
            this.btnIngresoTerreno.Activecolor = System.Drawing.Color.Transparent;
            this.btnIngresoTerreno.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresoTerreno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresoTerreno.BorderRadius = 0;
            this.btnIngresoTerreno.ButtonText = "             INGRESO DE TERRENOS";
            this.btnIngresoTerreno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresoTerreno.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresoTerreno.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoTerreno.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresoTerreno.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresoTerreno.Iconimage")));
            this.btnIngresoTerreno.Iconimage_right = null;
            this.btnIngresoTerreno.Iconimage_right_Selected = null;
            this.btnIngresoTerreno.Iconimage_Selected = null;
            this.btnIngresoTerreno.IconMarginLeft = 0;
            this.btnIngresoTerreno.IconMarginRight = 0;
            this.btnIngresoTerreno.IconRightVisible = true;
            this.btnIngresoTerreno.IconRightZoom = 0D;
            this.btnIngresoTerreno.IconVisible = true;
            this.btnIngresoTerreno.IconZoom = 50D;
            this.btnIngresoTerreno.IsTab = false;
            this.btnIngresoTerreno.Location = new System.Drawing.Point(16, 319);
            this.btnIngresoTerreno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresoTerreno.Name = "btnIngresoTerreno";
            this.btnIngresoTerreno.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIngresoTerreno.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIngresoTerreno.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresoTerreno.selected = false;
            this.btnIngresoTerreno.Size = new System.Drawing.Size(336, 52);
            this.btnIngresoTerreno.TabIndex = 19;
            this.btnIngresoTerreno.Text = "             INGRESO DE TERRENOS";
            this.btnIngresoTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoTerreno.Textcolor = System.Drawing.Color.LightGray;
            this.btnIngresoTerreno.TextFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoTerreno.Click += new System.EventHandler(this.btnIngresoTerreno_Click);
            // 
            // btnIngresoCasa
            // 
            this.btnIngresoCasa.Activecolor = System.Drawing.Color.Transparent;
            this.btnIngresoCasa.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresoCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresoCasa.BorderRadius = 0;
            this.btnIngresoCasa.ButtonText = "             INGRESO DE CASAS";
            this.btnIngresoCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresoCasa.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresoCasa.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoCasa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresoCasa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresoCasa.Iconimage")));
            this.btnIngresoCasa.Iconimage_right = null;
            this.btnIngresoCasa.Iconimage_right_Selected = null;
            this.btnIngresoCasa.Iconimage_Selected = null;
            this.btnIngresoCasa.IconMarginLeft = 0;
            this.btnIngresoCasa.IconMarginRight = 0;
            this.btnIngresoCasa.IconRightVisible = true;
            this.btnIngresoCasa.IconRightZoom = 0D;
            this.btnIngresoCasa.IconVisible = true;
            this.btnIngresoCasa.IconZoom = 50D;
            this.btnIngresoCasa.IsTab = false;
            this.btnIngresoCasa.Location = new System.Drawing.Point(16, 225);
            this.btnIngresoCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresoCasa.Name = "btnIngresoCasa";
            this.btnIngresoCasa.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIngresoCasa.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIngresoCasa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresoCasa.selected = false;
            this.btnIngresoCasa.Size = new System.Drawing.Size(336, 52);
            this.btnIngresoCasa.TabIndex = 18;
            this.btnIngresoCasa.Text = "             INGRESO DE CASAS";
            this.btnIngresoCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoCasa.Textcolor = System.Drawing.Color.LightGray;
            this.btnIngresoCasa.TextFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoCasa.Click += new System.EventHandler(this.btnIngresoCasa_Click);
            // 
            // btnIngresoApar
            // 
            this.btnIngresoApar.Activecolor = System.Drawing.Color.Transparent;
            this.btnIngresoApar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresoApar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresoApar.BorderRadius = 0;
            this.btnIngresoApar.ButtonText = "             INGRESO DE APARTAMENTOS";
            this.btnIngresoApar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresoApar.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresoApar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoApar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresoApar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngresoApar.Iconimage")));
            this.btnIngresoApar.Iconimage_right = null;
            this.btnIngresoApar.Iconimage_right_Selected = null;
            this.btnIngresoApar.Iconimage_Selected = null;
            this.btnIngresoApar.IconMarginLeft = 0;
            this.btnIngresoApar.IconMarginRight = 0;
            this.btnIngresoApar.IconRightVisible = true;
            this.btnIngresoApar.IconRightZoom = 0D;
            this.btnIngresoApar.IconVisible = true;
            this.btnIngresoApar.IconZoom = 50D;
            this.btnIngresoApar.IsTab = false;
            this.btnIngresoApar.Location = new System.Drawing.Point(16, 143);
            this.btnIngresoApar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresoApar.Name = "btnIngresoApar";
            this.btnIngresoApar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIngresoApar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIngresoApar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresoApar.selected = false;
            this.btnIngresoApar.Size = new System.Drawing.Size(336, 52);
            this.btnIngresoApar.TabIndex = 17;
            this.btnIngresoApar.Text = "             INGRESO DE APARTAMENTOS";
            this.btnIngresoApar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresoApar.Textcolor = System.Drawing.Color.LightGray;
            this.btnIngresoApar.TextFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoApar.Click += new System.EventHandler(this.btnIngresoApar_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(319, 9);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(28, 22);
            this.txtLogo.TabIndex = 15;
            this.txtLogo.Visible = false;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(12, 110);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(336, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reportes del \r\nSistema \r\n";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 24);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(143, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(396, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1243, 717);
            this.panel3.TabIndex = 4;
            // 
            // TodosLosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 756);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TodosLosReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosLosReportes";
            this.Load += new System.EventHandler(this.TodosLosReportes_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnNormal;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.TextBox txtLogo;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresoTerreno;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresoCasa;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresoApar;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}