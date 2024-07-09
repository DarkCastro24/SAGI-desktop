namespace WindowsFormsApplication1.Vista
{
    partial class FrmPreguntasSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreguntasSeguridad));
            this.grpContraseña = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpPregunta3 = new System.Windows.Forms.GroupBox();
            this.cmbPregunta3 = new System.Windows.Forms.ComboBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreguntas = new System.Windows.Forms.Button();
            this.Pregunta3 = new System.Windows.Forms.RichTextBox();
            this.grpPregunta2 = new System.Windows.Forms.GroupBox();
            this.cmbPregunta2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CodigoSeguridad = new System.Windows.Forms.MaskedTextBox();
            this.Pregunta2 = new System.Windows.Forms.RichTextBox();
            this.grpPregunta1 = new System.Windows.Forms.GroupBox();
            this.cmbPregunta1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Pregunta1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.txtEncriptado = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegresar = new System.Windows.Forms.ToolStripButton();
            this.txtEncriptado2 = new System.Windows.Forms.TextBox();
            this.txtEncriptado3 = new System.Windows.Forms.TextBox();
            this.txtEncriptado4 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.grpContraseña.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.grpPregunta3.SuspendLayout();
            this.grpPregunta2.SuspendLayout();
            this.grpPregunta1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContraseña
            // 
            this.grpContraseña.Controls.Add(this.label4);
            this.grpContraseña.Controls.Add(this.label1);
            this.grpContraseña.Controls.Add(this.txtConfirmarContraseña);
            this.grpContraseña.Controls.Add(this.btnCambiarContraseña);
            this.grpContraseña.Controls.Add(this.txtContraseña);
            this.grpContraseña.Enabled = false;
            this.grpContraseña.Location = new System.Drawing.Point(438, 57);
            this.grpContraseña.Name = "grpContraseña";
            this.grpContraseña.Size = new System.Drawing.Size(366, 197);
            this.grpContraseña.TabIndex = 39;
            this.grpContraseña.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Confirmar\r\nContraseña\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nueva \r\nContraseña\r\n";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BackColor = System.Drawing.Color.White;
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(124, 94);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContraseña.MaxLength = 10;
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.ShortcutsEnabled = false;
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(205, 14);
            this.txtConfirmarContraseña.TabIndex = 8;
            this.txtConfirmarContraseña.UseSystemPasswordChar = true;
            this.txtConfirmarContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCambiarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(29, 140);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(309, 32);
            this.btnCambiarContraseña.TabIndex = 11;
            this.btnCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(124, 36);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.MaxLength = 9;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(205, 14);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.label3);
            this.grpUsuario.Controls.Add(this.btnValidar);
            this.grpUsuario.Controls.Add(this.txtUsuario);
            this.grpUsuario.Location = new System.Drawing.Point(37, 57);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(369, 197);
            this.grpUsuario.TabIndex = 37;
            this.grpUsuario.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 48);
            this.label3.TabIndex = 39;
            this.label3.Text = "Usuario a \r\nRecuperar\r\n\r\n";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(34, 140);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(304, 32);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "VALIDAR USUARIO";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(115, 72);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 25;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(207, 14);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // grpPregunta3
            // 
            this.grpPregunta3.Controls.Add(this.cmbPregunta3);
            this.grpPregunta3.Controls.Add(this.btnCodigo);
            this.grpPregunta3.Controls.Add(this.panel6);
            this.grpPregunta3.Controls.Add(this.label6);
            this.grpPregunta3.Controls.Add(this.btnPreguntas);
            this.grpPregunta3.Controls.Add(this.Pregunta3);
            this.grpPregunta3.Enabled = false;
            this.grpPregunta3.Location = new System.Drawing.Point(567, 282);
            this.grpPregunta3.Name = "grpPregunta3";
            this.grpPregunta3.Size = new System.Drawing.Size(235, 240);
            this.grpPregunta3.TabIndex = 38;
            this.grpPregunta3.TabStop = false;
            this.grpPregunta3.Text = "Pregunta 3";
            // 
            // cmbPregunta3
            // 
            this.cmbPregunta3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta3.FormattingEnabled = true;
            this.cmbPregunta3.Location = new System.Drawing.Point(17, 38);
            this.cmbPregunta3.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPregunta3.Name = "cmbPregunta3";
            this.cmbPregunta3.Size = new System.Drawing.Size(196, 21);
            this.cmbPregunta3.TabIndex = 7;
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.White;
            this.btnCodigo.Location = new System.Drawing.Point(17, 195);
            this.btnCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(89, 40);
            this.btnCodigo.TabIndex = 8;
            this.btnCodigo.Text = "VALIDAR POR CODIGO";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.panel6.Location = new System.Drawing.Point(2, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(232, 10);
            this.panel6.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Elija una opcion para validar";
            this.label6.Visible = false;
            // 
            // btnPreguntas
            // 
            this.btnPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.btnPreguntas.FlatAppearance.BorderSize = 0;
            this.btnPreguntas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnPreguntas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreguntas.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreguntas.ForeColor = System.Drawing.Color.White;
            this.btnPreguntas.Location = new System.Drawing.Point(126, 195);
            this.btnPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreguntas.Name = "btnPreguntas";
            this.btnPreguntas.Size = new System.Drawing.Size(89, 40);
            this.btnPreguntas.TabIndex = 6;
            this.btnPreguntas.Text = "VALIDAR POR PREGUNTAS";
            this.btnPreguntas.UseVisualStyleBackColor = false;
            this.btnPreguntas.Click += new System.EventHandler(this.btnPreguntas_Click);
            // 
            // Pregunta3
            // 
            this.Pregunta3.Location = new System.Drawing.Point(17, 80);
            this.Pregunta3.MaxLength = 30;
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.ShortcutsEnabled = false;
            this.Pregunta3.Size = new System.Drawing.Size(198, 47);
            this.Pregunta3.TabIndex = 5;
            this.Pregunta3.Text = "";
            this.Pregunta3.TextChanged += new System.EventHandler(this.Pregunta3_TextChanged);
            this.Pregunta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pregunta3_KeyPress);
            // 
            // grpPregunta2
            // 
            this.grpPregunta2.Controls.Add(this.cmbPregunta2);
            this.grpPregunta2.Controls.Add(this.panel5);
            this.grpPregunta2.Controls.Add(this.CodigoSeguridad);
            this.grpPregunta2.Controls.Add(this.Pregunta2);
            this.grpPregunta2.Enabled = false;
            this.grpPregunta2.Location = new System.Drawing.Point(302, 282);
            this.grpPregunta2.Name = "grpPregunta2";
            this.grpPregunta2.Size = new System.Drawing.Size(231, 240);
            this.grpPregunta2.TabIndex = 36;
            this.grpPregunta2.TabStop = false;
            this.grpPregunta2.Text = "Pregunta 2";
            // 
            // cmbPregunta2
            // 
            this.cmbPregunta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta2.FormattingEnabled = true;
            this.cmbPregunta2.Location = new System.Drawing.Point(27, 38);
            this.cmbPregunta2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPregunta2.Name = "cmbPregunta2";
            this.cmbPregunta2.Size = new System.Drawing.Size(178, 21);
            this.cmbPregunta2.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.panel5.Location = new System.Drawing.Point(0, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 10);
            this.panel5.TabIndex = 36;
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.Location = new System.Drawing.Point(27, 186);
            this.CodigoSeguridad.Mask = "00000000";
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.ShortcutsEnabled = false;
            this.CodigoSeguridad.Size = new System.Drawing.Size(173, 20);
            this.CodigoSeguridad.TabIndex = 7;
            this.CodigoSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoSeguridad_KeyPress);
            // 
            // Pregunta2
            // 
            this.Pregunta2.Location = new System.Drawing.Point(27, 80);
            this.Pregunta2.MaxLength = 30;
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.ShortcutsEnabled = false;
            this.Pregunta2.Size = new System.Drawing.Size(178, 47);
            this.Pregunta2.TabIndex = 4;
            this.Pregunta2.Text = "";
            this.Pregunta2.TextChanged += new System.EventHandler(this.Pregunta2_TextChanged);
            this.Pregunta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pregunta2_KeyPress);
            // 
            // grpPregunta1
            // 
            this.grpPregunta1.Controls.Add(this.cmbPregunta1);
            this.grpPregunta1.Controls.Add(this.panel4);
            this.grpPregunta1.Controls.Add(this.label5);
            this.grpPregunta1.Controls.Add(this.Pregunta1);
            this.grpPregunta1.Enabled = false;
            this.grpPregunta1.Location = new System.Drawing.Point(37, 282);
            this.grpPregunta1.Name = "grpPregunta1";
            this.grpPregunta1.Size = new System.Drawing.Size(235, 240);
            this.grpPregunta1.TabIndex = 35;
            this.grpPregunta1.TabStop = false;
            this.grpPregunta1.Text = "Pregunta 1";
            // 
            // cmbPregunta1
            // 
            this.cmbPregunta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPregunta1.FormattingEnabled = true;
            this.cmbPregunta1.Location = new System.Drawing.Point(22, 38);
            this.cmbPregunta1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPregunta1.Name = "cmbPregunta1";
            this.cmbPregunta1.Size = new System.Drawing.Size(196, 21);
            this.cmbPregunta1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(119)))));
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 10);
            this.panel4.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ingrese su codigo de respaldo";
            // 
            // Pregunta1
            // 
            this.Pregunta1.Location = new System.Drawing.Point(22, 80);
            this.Pregunta1.MaxLength = 30;
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.ShortcutsEnabled = false;
            this.Pregunta1.Size = new System.Drawing.Size(196, 47);
            this.Pregunta1.TabIndex = 3;
            this.Pregunta1.Text = "";
            this.Pregunta1.TextChanged += new System.EventHandler(this.Pregunta1_TextChanged);
            this.Pregunta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pregunta1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 34);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Recuperacion de usuario por preguntas de seguridad || Ingrese los datos que se le" +
    " solicitan";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(802, 5);
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
            this.btnMinimizar.Location = new System.Drawing.Point(776, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtEncriptado
            // 
            this.txtEncriptado.Location = new System.Drawing.Point(572, 38);
            this.txtEncriptado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado.Name = "txtEncriptado";
            this.txtEncriptado.Size = new System.Drawing.Size(246, 20);
            this.txtEncriptado.TabIndex = 42;
            this.txtEncriptado.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 570);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(829, 27);
            this.toolStrip1.TabIndex = 43;
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
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // txtEncriptado2
            // 
            this.txtEncriptado2.Location = new System.Drawing.Point(46, 541);
            this.txtEncriptado2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado2.Name = "txtEncriptado2";
            this.txtEncriptado2.Size = new System.Drawing.Size(209, 20);
            this.txtEncriptado2.TabIndex = 44;
            this.txtEncriptado2.Visible = false;
            this.txtEncriptado2.TextChanged += new System.EventHandler(this.txtEncriptado2_TextChanged);
            // 
            // txtEncriptado3
            // 
            this.txtEncriptado3.Location = new System.Drawing.Point(302, 541);
            this.txtEncriptado3.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado3.Name = "txtEncriptado3";
            this.txtEncriptado3.Size = new System.Drawing.Size(224, 20);
            this.txtEncriptado3.TabIndex = 45;
            this.txtEncriptado3.Visible = false;
            this.txtEncriptado3.TextChanged += new System.EventHandler(this.txtEncriptado3_TextChanged);
            // 
            // txtEncriptado4
            // 
            this.txtEncriptado4.Location = new System.Drawing.Point(567, 541);
            this.txtEncriptado4.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncriptado4.Name = "txtEncriptado4";
            this.txtEncriptado4.Size = new System.Drawing.Size(210, 20);
            this.txtEncriptado4.TabIndex = 46;
            this.txtEncriptado4.Visible = false;
            this.txtEncriptado4.TextChanged += new System.EventHandler(this.txtEncriptado4_TextChanged);
            // 
            // FrmPreguntasSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 597);
            this.Controls.Add(this.txtEncriptado4);
            this.Controls.Add(this.txtEncriptado3);
            this.Controls.Add(this.txtEncriptado2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtEncriptado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpContraseña);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.grpPregunta3);
            this.Controls.Add(this.grpPregunta2);
            this.Controls.Add(this.grpPregunta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPreguntasSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreguntasSeguridad";
            this.Load += new System.EventHandler(this.FrmPreguntasSeguridad_Load);
            this.grpContraseña.ResumeLayout(false);
            this.grpContraseña.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpPregunta3.ResumeLayout(false);
            this.grpPregunta3.PerformLayout();
            this.grpPregunta2.ResumeLayout(false);
            this.grpPregunta2.PerformLayout();
            this.grpPregunta1.ResumeLayout(false);
            this.grpPregunta1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContraseña;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpPregunta3;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPreguntas;
        private System.Windows.Forms.RichTextBox Pregunta3;
        private System.Windows.Forms.GroupBox grpPregunta2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox CodigoSeguridad;
        private System.Windows.Forms.GroupBox grpPregunta1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TextBox txtEncriptado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPregunta3;
        private System.Windows.Forms.ComboBox cmbPregunta2;
        private System.Windows.Forms.RichTextBox Pregunta2;
        private System.Windows.Forms.ComboBox cmbPregunta1;
        private System.Windows.Forms.RichTextBox Pregunta1;
        private System.Windows.Forms.TextBox txtEncriptado2;
        private System.Windows.Forms.TextBox txtEncriptado3;
        private System.Windows.Forms.TextBox txtEncriptado4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}