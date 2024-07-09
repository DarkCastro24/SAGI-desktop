namespace WindowsFormsApplication1.Vista.CRUD
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.AbrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEncriptadoClaveValidar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValidarClave = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtEncriptadoComparar = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.pbTodasLasPreguntas = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.EncriptacionContraseña = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Respuesta3 = new System.Windows.Forms.TextBox();
            this.cmbPregunta3 = new System.Windows.Forms.ComboBox();
            this.Respuesta2 = new System.Windows.Forms.TextBox();
            this.cmbPregunta2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Respuesta1 = new System.Windows.Forms.TextBox();
            this.cmbPregunta1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlogo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodasLasPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbrirImagen
            // 
            this.AbrirImagen.FileName = "openFileDialog1";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.toolStrip1);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelDatos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1251, 850);
            this.panelContenedor.TabIndex = 74;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtEncriptadoClaveValidar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtValidarClave);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(43, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 57);
            this.panel1.TabIndex = 215;
            // 
            // txtEncriptadoClaveValidar
            // 
            this.txtEncriptadoClaveValidar.Location = new System.Drawing.Point(221, 16);
            this.txtEncriptadoClaveValidar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEncriptadoClaveValidar.MaxLength = 17;
            this.txtEncriptadoClaveValidar.Name = "txtEncriptadoClaveValidar";
            this.txtEncriptadoClaveValidar.Size = new System.Drawing.Size(40, 22);
            this.txtEncriptadoClaveValidar.TabIndex = 268;
            this.txtEncriptadoClaveValidar.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(967, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "CONFIRME SU CLAVE\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtValidarClave
            // 
            this.txtValidarClave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtValidarClave.Location = new System.Drawing.Point(767, 16);
            this.txtValidarClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValidarClave.MaxLength = 10;
            this.txtValidarClave.Name = "txtValidarClave";
            this.txtValidarClave.ShortcutsEnabled = false;
            this.txtValidarClave.Size = new System.Drawing.Size(172, 22);
            this.txtValidarClave.TabIndex = 1;
            this.txtValidarClave.UseSystemPasswordChar = true;
            this.txtValidarClave.TextChanged += new System.EventHandler(this.txtValidarClave_TextChanged_2);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 16);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.MaxLength = 17;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(95, 22);
            this.txtId.TabIndex = 257;
            this.txtId.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(407, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 29);
            this.label2.TabIndex = 194;
            this.label2.Text = "CONFIGURACION PERSONAL ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(351, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 195;
            this.pictureBox6.TabStop = false;
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.Controls.Add(this.txtEncriptadoComparar);
            this.panelDatos.Controls.Add(this.txtRespuesta3);
            this.panelDatos.Controls.Add(this.txtRespuesta1);
            this.panelDatos.Controls.Add(this.txtRespuesta2);
            this.panelDatos.Controls.Add(this.txtEncriptado);
            this.panelDatos.Controls.Add(this.EncriptacionContraseña);
            this.panelDatos.Controls.Add(this.groupBox1);
            this.panelDatos.Controls.Add(this.groupBox2);
            this.panelDatos.Controls.Add(this.groupBox3);
            this.panelDatos.Location = new System.Drawing.Point(43, 113);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1165, 704);
            this.panelDatos.TabIndex = 216;
            // 
            // txtEncriptadoComparar
            // 
            this.txtEncriptadoComparar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncriptadoComparar.Location = new System.Drawing.Point(591, 94);
            this.txtEncriptadoComparar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEncriptadoComparar.MaxLength = 17;
            this.txtEncriptadoComparar.Name = "txtEncriptadoComparar";
            this.txtEncriptadoComparar.Size = new System.Drawing.Size(28, 22);
            this.txtEncriptadoComparar.TabIndex = 273;
            this.txtEncriptadoComparar.Visible = false;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(591, 473);
            this.txtRespuesta3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta3.MaxLength = 17;
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(28, 22);
            this.txtRespuesta3.TabIndex = 264;
            this.txtRespuesta3.Visible = false;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(591, 366);
            this.txtRespuesta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta1.MaxLength = 17;
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(28, 22);
            this.txtRespuesta1.TabIndex = 260;
            this.txtRespuesta1.Visible = false;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(591, 415);
            this.txtRespuesta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta2.MaxLength = 17;
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(28, 22);
            this.txtRespuesta2.TabIndex = 262;
            this.txtRespuesta2.Visible = false;
            // 
            // pbTodasLasPreguntas
            // 
            this.pbTodasLasPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbTodasLasPreguntas.Image = ((System.Drawing.Image)(resources.GetObject("pbTodasLasPreguntas.Image")));
            this.pbTodasLasPreguntas.Location = new System.Drawing.Point(381, 27);
            this.pbTodasLasPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTodasLasPreguntas.Name = "pbTodasLasPreguntas";
            this.pbTodasLasPreguntas.Size = new System.Drawing.Size(64, 41);
            this.pbTodasLasPreguntas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTodasLasPreguntas.TabIndex = 272;
            this.pbTodasLasPreguntas.TabStop = false;
            this.pbTodasLasPreguntas.Click += new System.EventHandler(this.pbTodasLasPreguntas_Click);
            // 
            // picHide
            // 
            this.picHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHide.Image = ((System.Drawing.Image)(resources.GetObject("picHide.Image")));
            this.picHide.Location = new System.Drawing.Point(467, 21);
            this.picHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(29, 30);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 271;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click_2);
            // 
            // picShow
            // 
            this.picShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(467, 21);
            this.picShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(29, 30);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 270;
            this.picShow.TabStop = false;
            this.picShow.Visible = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click_1);
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncriptado.Location = new System.Drawing.Point(591, 145);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEncriptado.MaxLength = 17;
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(28, 22);
            this.txtEncriptado.TabIndex = 269;
            this.txtEncriptado.Visible = false;
            // 
            // EncriptacionContraseña
            // 
            this.EncriptacionContraseña.Location = new System.Drawing.Point(1209, 42);
            this.EncriptacionContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncriptacionContraseña.MaxLength = 17;
            this.EncriptacionContraseña.Name = "EncriptacionContraseña";
            this.EncriptacionContraseña.Size = new System.Drawing.Size(28, 22);
            this.EncriptacionContraseña.TabIndex = 266;
            this.EncriptacionContraseña.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(24, 596);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(500, 36);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR DATOS PERSONALES\r\n\r\n\r\n";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntas.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntas.ForeColor = System.Drawing.Color.White;
            this.btnPreguntas.Location = new System.Drawing.Point(20, 430);
            this.btnPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(449, 38);
            this.btnPreguntas.TabIndex = 18;
            this.btnPreguntas.Text = "CAMBIAR PREGUNTAS\r\n";
            this.btnPreguntas.UseVisualStyleBackColor = false;
            this.btnPreguntas.Click += new System.EventHandler(this.btnPreguntas_Click_1);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(8, 130);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(463, 38);
            this.btnCambiarContraseña.TabIndex = 11;
            this.btnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click_1);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 23);
            this.label11.TabIndex = 256;
            this.label11.Text = "Nueva Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(186, 79);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarContraseña.MaxLength = 10;
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.ShortcutsEnabled = false;
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(283, 22);
            this.txtConfirmarContraseña.TabIndex = 10;
            this.txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 254;
            this.label10.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(186, 24);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.MaxLength = 10;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(233, 22);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // Respuesta3
            // 
            this.Respuesta3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Respuesta3.Location = new System.Drawing.Point(20, 357);
            this.Respuesta3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Respuesta3.MaxLength = 30;
            this.Respuesta3.Name = "Respuesta3";
            this.Respuesta3.ShortcutsEnabled = false;
            this.Respuesta3.Size = new System.Drawing.Size(447, 22);
            this.Respuesta3.TabIndex = 17;
            this.Respuesta3.TextChanged += new System.EventHandler(this.Respuesta3_TextChanged_1);
            this.Respuesta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Respuesta3_KeyPress);
            // 
            // cmbPregunta3
            // 
            this.cmbPregunta3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta3.FormattingEnabled = true;
            this.cmbPregunta3.Location = new System.Drawing.Point(20, 312);
            this.cmbPregunta3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPregunta3.Name = "cmbPregunta3";
            this.cmbPregunta3.Size = new System.Drawing.Size(447, 24);
            this.cmbPregunta3.TabIndex = 16;
            this.cmbPregunta3.SelectedIndexChanged += new System.EventHandler(this.cmbPregunta3_SelectedIndexChanged);
            // 
            // Respuesta2
            // 
            this.Respuesta2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Respuesta2.Location = new System.Drawing.Point(20, 250);
            this.Respuesta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Respuesta2.MaxLength = 30;
            this.Respuesta2.Name = "Respuesta2";
            this.Respuesta2.ShortcutsEnabled = false;
            this.Respuesta2.Size = new System.Drawing.Size(447, 22);
            this.Respuesta2.TabIndex = 15;
            this.Respuesta2.TextChanged += new System.EventHandler(this.Respuesta2_TextChanged_1);
            this.Respuesta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Respuesta2_KeyPress);
            // 
            // cmbPregunta2
            // 
            this.cmbPregunta2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta2.FormattingEnabled = true;
            this.cmbPregunta2.Location = new System.Drawing.Point(20, 205);
            this.cmbPregunta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPregunta2.Name = "cmbPregunta2";
            this.cmbPregunta2.Size = new System.Drawing.Size(447, 24);
            this.cmbPregunta2.TabIndex = 14;
            this.cmbPregunta2.SelectedIndexChanged += new System.EventHandler(this.cmbPregunta2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(49, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 23);
            this.label7.TabIndex = 247;
            this.label7.Text = "¿Desea cambiar sus preguntas actuales?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Respuesta1
            // 
            this.Respuesta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Respuesta1.Location = new System.Drawing.Point(18, 139);
            this.Respuesta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Respuesta1.MaxLength = 30;
            this.Respuesta1.Name = "Respuesta1";
            this.Respuesta1.ShortcutsEnabled = false;
            this.Respuesta1.Size = new System.Drawing.Size(447, 22);
            this.Respuesta1.TabIndex = 13;
            this.Respuesta1.TextChanged += new System.EventHandler(this.Respuesta1_TextChanged_1);
            this.Respuesta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Respuesta1_KeyPress);
            // 
            // cmbPregunta1
            // 
            this.cmbPregunta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPregunta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta1.FormattingEnabled = true;
            this.cmbPregunta1.Location = new System.Drawing.Point(18, 96);
            this.cmbPregunta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPregunta1.Name = "cmbPregunta1";
            this.cmbPregunta1.Size = new System.Drawing.Size(447, 24);
            this.cmbPregunta1.TabIndex = 12;
            this.cmbPregunta1.SelectedIndexChanged += new System.EventHandler(this.cmbPregunta1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 244;
            this.label5.Text = "Profesion";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(157, 326);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProfesion.MaxLength = 30;
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.ShortcutsEnabled = false;
            this.txtProfesion.Size = new System.Drawing.Size(365, 22);
            this.txtProfesion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 242;
            this.label4.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 241;
            this.label6.Text = "Usuario";
            // 
            // txtlogo
            // 
            this.txtlogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtlogo.Location = new System.Drawing.Point(438, 482);
            this.txtlogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlogo.MaxLength = 45;
            this.txtlogo.Name = "txtlogo";
            this.txtlogo.Size = new System.Drawing.Size(29, 22);
            this.txtlogo.TabIndex = 238;
            this.txtlogo.Visible = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(38, 506);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(97, 38);
            this.btnExaminar.TabIndex = 7;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click_1);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Location = new System.Drawing.Point(234, 399);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(162, 178);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 234;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 69);
            this.label3.TabIndex = 232;
            this.label3.Text = "Imagen de \r\nPerfil\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 230;
            this.label8.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(157, 127);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(365, 70);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(157, 250);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(365, 22);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(157, 43);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(365, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.txtlogo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProfesion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 650);
            this.groupBox1.TabIndex = 274;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtConfirmarContraseña);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnCambiarContraseña);
            this.groupBox2.Controls.Add(this.picHide);
            this.groupBox2.Controls.Add(this.picShow);
            this.groupBox2.Location = new System.Drawing.Point(623, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 182);
            this.groupBox2.TabIndex = 275;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambio de Contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbPregunta1);
            this.groupBox3.Controls.Add(this.Respuesta1);
            this.groupBox3.Controls.Add(this.cmbPregunta2);
            this.groupBox3.Controls.Add(this.pbTodasLasPreguntas);
            this.groupBox3.Controls.Add(this.Respuesta2);
            this.groupBox3.Controls.Add(this.cmbPregunta3);
            this.groupBox3.Controls.Add(this.Respuesta3);
            this.groupBox3.Controls.Add(this.btnPreguntas);
            this.groupBox3.Location = new System.Drawing.Point(626, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 477);
            this.groupBox3.TabIndex = 276;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuración de Preguntas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 823);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1251, 27);
            this.toolStrip1.TabIndex = 217;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(202, 24);
            this.toolStripButton1.Text = "Terminar la configuración";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 850);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConfiguracion";
            this.Text = "frmConfiguracion";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodasLasPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog AbrirImagen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEncriptadoClaveValidar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValidarClave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.PictureBox pbTodasLasPreguntas;
        private System.Windows.Forms.PictureBox picHide;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.TextBox EncriptacionContraseña;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox Respuesta3;
        private System.Windows.Forms.ComboBox cmbPregunta3;
        private System.Windows.Forms.TextBox Respuesta2;
        private System.Windows.Forms.ComboBox cmbPregunta2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Respuesta1;
        private System.Windows.Forms.ComboBox cmbPregunta1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlogo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtEncriptadoComparar;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}