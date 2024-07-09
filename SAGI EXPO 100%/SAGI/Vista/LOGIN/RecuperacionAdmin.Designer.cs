namespace WindowsFormsApplication1
{
    partial class frmRecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.BtnPemitir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.BtnCambiarContraseña = new System.Windows.Forms.Button();
            this.txtUsuarioRecuperar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegresar = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.NuevaContraseña = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pbHide2 = new System.Windows.Forms.PictureBox();
            this.pbShow2 = new System.Windows.Forms.PictureBox();
            this.txtContraseñaEncriptada = new System.Windows.Forms.TextBox();
            this.grpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.grpUsuario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 8);
            this.panel1.TabIndex = 2;
            // 
            // grpAdmin
            // 
            this.grpAdmin.BackColor = System.Drawing.Color.White;
            this.grpAdmin.Controls.Add(this.panel3);
            this.grpAdmin.Controls.Add(this.picHide);
            this.grpAdmin.Controls.Add(this.picShow);
            this.grpAdmin.Controls.Add(this.txtClaveAdmin);
            this.grpAdmin.Controls.Add(this.txtUsuarioRecuperar);
            this.grpAdmin.Controls.Add(this.BtnPemitir);
            this.grpAdmin.Controls.Add(this.label3);
            this.grpAdmin.Controls.Add(this.panel4);
            this.grpAdmin.Controls.Add(this.panel2);
            this.grpAdmin.Controls.Add(this.label2);
            this.grpAdmin.Controls.Add(this.label1);
            this.grpAdmin.Controls.Add(this.txtUsuarioAdmin);
            this.grpAdmin.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmin.Location = new System.Drawing.Point(9, 52);
            this.grpAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.grpAdmin.Size = new System.Drawing.Size(333, 285);
            this.grpAdmin.TabIndex = 4;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Uso de administrador";
            this.grpAdmin.Enter += new System.EventHandler(this.grpAdmin_Enter);
            // 
            // picHide
            // 
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(297, 107);
            this.picHide.Margin = new System.Windows.Forms.Padding(2);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(22, 24);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 18;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // picShow
            // 
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(297, 107);
            this.picShow.Margin = new System.Windows.Forms.Padding(2);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(22, 24);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 17;
            this.picShow.TabStop = false;
            this.picShow.Visible = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveAdmin.Location = new System.Drawing.Point(164, 119);
            this.txtClaveAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveAdmin.MaxLength = 10;
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.ShortcutsEnabled = false;
            this.txtClaveAdmin.Size = new System.Drawing.Size(120, 13);
            this.txtClaveAdmin.TabIndex = 2;
            this.txtClaveAdmin.UseSystemPasswordChar = true;
            this.txtClaveAdmin.TextChanged += new System.EventHandler(this.txtClaveAdmin_TextChanged);
            this.txtClaveAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveAdmin_KeyPress);
            // 
            // BtnPemitir
            // 
            this.BtnPemitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.BtnPemitir.FlatAppearance.BorderSize = 0;
            this.BtnPemitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPemitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPemitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPemitir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPemitir.ForeColor = System.Drawing.Color.White;
            this.BtnPemitir.Location = new System.Drawing.Point(21, 228);
            this.BtnPemitir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPemitir.Name = "BtnPemitir";
            this.BtnPemitir.Size = new System.Drawing.Size(298, 26);
            this.BtnPemitir.TabIndex = 4;
            this.BtnPemitir.Text = "PERMITIR RECUPERACION";
            this.BtnPemitir.UseVisualStyleBackColor = false;
            this.BtnPemitir.Click += new System.EventHandler(this.BtnPemitir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(162, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 2);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(162, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 2);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario Administrador";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(164, 58);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioAdmin.MaxLength = 25;
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.ShortcutsEnabled = false;
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(120, 13);
            this.txtUsuarioAdmin.TabIndex = 1;
            this.txtUsuarioAdmin.TextChanged += new System.EventHandler(this.txtUsuarioAdmin_TextChanged);
            this.txtUsuarioAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioAdmin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario a recuperar";
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.pbHide2);
            this.grpUsuario.Controls.Add(this.pbShow2);
            this.grpUsuario.Controls.Add(this.ConfirmarContraseña);
            this.grpUsuario.Controls.Add(this.panel6);
            this.grpUsuario.Controls.Add(this.label5);
            this.grpUsuario.Controls.Add(this.NuevaContraseña);
            this.grpUsuario.Controls.Add(this.BtnCambiarContraseña);
            this.grpUsuario.Controls.Add(this.panel5);
            this.grpUsuario.Controls.Add(this.label4);
            this.grpUsuario.Enabled = false;
            this.grpUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuario.Location = new System.Drawing.Point(352, 52);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Size = new System.Drawing.Size(350, 285);
            this.grpUsuario.TabIndex = 5;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Nuevas credenciales";
            this.grpUsuario.Enter += new System.EventHandler(this.grpUsuario_Enter);
            // 
            // BtnCambiarContraseña
            // 
            this.BtnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.BtnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.BtnCambiarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnCambiarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarContraseña.Location = new System.Drawing.Point(26, 228);
            this.BtnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCambiarContraseña.Name = "BtnCambiarContraseña";
            this.BtnCambiarContraseña.Size = new System.Drawing.Size(292, 26);
            this.BtnCambiarContraseña.TabIndex = 7;
            this.BtnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            this.BtnCambiarContraseña.UseVisualStyleBackColor = false;
            this.BtnCambiarContraseña.Click += new System.EventHandler(this.BtnCambiarContraseña_Click);
            // 
            // txtUsuarioRecuperar
            // 
            this.txtUsuarioRecuperar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioRecuperar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRecuperar.Location = new System.Drawing.Point(162, 175);
            this.txtUsuarioRecuperar.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioRecuperar.MaxLength = 25;
            this.txtUsuarioRecuperar.Name = "txtUsuarioRecuperar";
            this.txtUsuarioRecuperar.ShortcutsEnabled = false;
            this.txtUsuarioRecuperar.Size = new System.Drawing.Size(120, 13);
            this.txtUsuarioRecuperar.TabIndex = 3;
            this.txtUsuarioRecuperar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioRecuperar_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 339);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(712, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 24);
            this.btnRegresar.Text = "Regresar al login";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.txtContraseñaEncriptada);
            this.panel7.Controls.Add(this.txtEncriptado);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.btnCerrar);
            this.panel7.Controls.Add(this.btnMinimizar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(712, 28);
            this.panel7.TabIndex = 7;
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Location = new System.Drawing.Point(300, 5);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(42, 20);
            this.txtEncriptado.TabIndex = 21;
            this.txtEncriptado.Visible = false;
            this.txtEncriptado.TextChanged += new System.EventHandler(this.txtEncriptado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Recuperación de Contraseña | Administrador";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(686, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(659, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(162, 188);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 2);
            this.panel3.TabIndex = 7;
            // 
            // NuevaContraseña
            // 
            this.NuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NuevaContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContraseña.Location = new System.Drawing.Point(183, 76);
            this.NuevaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.NuevaContraseña.MaxLength = 10;
            this.NuevaContraseña.Name = "NuevaContraseña";
            this.NuevaContraseña.ShortcutsEnabled = false;
            this.NuevaContraseña.Size = new System.Drawing.Size(120, 13);
            this.NuevaContraseña.TabIndex = 5;
            this.NuevaContraseña.UseSystemPasswordChar = true;
            this.NuevaContraseña.TextChanged += new System.EventHandler(this.NuevaContraseña_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(181, 89);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 2);
            this.panel5.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nueva Contraseña";
            // 
            // ConfirmarContraseña
            // 
            this.ConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmarContraseña.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContraseña.Location = new System.Drawing.Point(183, 149);
            this.ConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmarContraseña.MaxLength = 10;
            this.ConfirmarContraseña.Name = "ConfirmarContraseña";
            this.ConfirmarContraseña.ShortcutsEnabled = false;
            this.ConfirmarContraseña.Size = new System.Drawing.Size(120, 13);
            this.ConfirmarContraseña.TabIndex = 6;
            this.ConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(181, 162);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 2);
            this.panel6.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // pbHide2
            // 
            this.pbHide2.Image = ((System.Drawing.Image)(resources.GetObject("pbHide2.Image")));
            this.pbHide2.Location = new System.Drawing.Point(312, 67);
            this.pbHide2.Margin = new System.Windows.Forms.Padding(2);
            this.pbHide2.Name = "pbHide2";
            this.pbHide2.Size = new System.Drawing.Size(22, 24);
            this.pbHide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHide2.TabIndex = 20;
            this.pbHide2.TabStop = false;
            this.pbHide2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbShow2
            // 
            this.pbShow2.Image = ((System.Drawing.Image)(resources.GetObject("pbShow2.Image")));
            this.pbShow2.Location = new System.Drawing.Point(312, 68);
            this.pbShow2.Margin = new System.Windows.Forms.Padding(2);
            this.pbShow2.Name = "pbShow2";
            this.pbShow2.Size = new System.Drawing.Size(22, 24);
            this.pbShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShow2.TabIndex = 19;
            this.pbShow2.TabStop = false;
            this.pbShow2.Visible = false;
            this.pbShow2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtContraseñaEncriptada
            // 
            this.txtContraseñaEncriptada.Location = new System.Drawing.Point(352, 5);
            this.txtContraseñaEncriptada.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseñaEncriptada.Name = "txtContraseñaEncriptada";
            this.txtContraseñaEncriptada.Size = new System.Drawing.Size(42, 20);
            this.txtContraseñaEncriptada.TabIndex = 22;
            this.txtContraseñaEncriptada.Visible = false;
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 366);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.frmRecuperarContraseña_Load);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegresar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TextBox txtUsuarioRecuperar;
        private System.Windows.Forms.Button BtnPemitir;
        private System.Windows.Forms.Button BtnCambiarContraseña;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbHide2;
        private System.Windows.Forms.PictureBox pbShow2;
        private System.Windows.Forms.TextBox ConfirmarContraseña;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NuevaContraseña;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseñaEncriptada;
    }
}