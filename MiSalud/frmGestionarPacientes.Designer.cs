namespace MiSalud
{
    partial class frmGestionarPacientes
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
            lblFechaNac = new Label();
            btnVer = new Button();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtCiudad = new TextBox();
            txtDireccion = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            txtContrasegna = new TextBox();
            txtUsuario = new TextBox();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblCiudad = new Label();
            lblDireccion = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            lblContrasegna = new Label();
            lblNombreUsu = new Label();
            btnAceptar = new Button();
            dtpNacimiento = new DateTimePicker();
            chkCertificados = new CheckBox();
            SuspendLayout();
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(22, 183);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(185, 30);
            lblFechaNac.TabIndex = 76;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Location = new Point(637, 65);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(44, 30);
            btnVer.TabIndex = 75;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Location = new Point(254, 339);
            txtEmail.MinimumSize = new Size(300, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(427, 30);
            txtEmail.TabIndex = 74;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(224, 224, 224);
            txtTelefono.Location = new Point(254, 300);
            txtTelefono.MaxLength = 9;
            txtTelefono.MinimumSize = new Size(300, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(427, 30);
            txtTelefono.TabIndex = 73;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtCiudad
            // 
            txtCiudad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCiudad.BackColor = Color.FromArgb(224, 224, 224);
            txtCiudad.Location = new Point(254, 261);
            txtCiudad.MinimumSize = new Size(300, 30);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(427, 30);
            txtCiudad.TabIndex = 72;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.BackColor = Color.FromArgb(224, 224, 224);
            txtDireccion.Location = new Point(254, 222);
            txtDireccion.MinimumSize = new Size(300, 30);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(427, 30);
            txtDireccion.TabIndex = 71;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellidos.BackColor = Color.FromArgb(224, 224, 224);
            txtApellidos.Location = new Point(254, 144);
            txtApellidos.MinimumSize = new Size(300, 30);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(427, 30);
            txtApellidos.TabIndex = 70;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(224, 224, 224);
            txtNombre.Location = new Point(254, 104);
            txtNombre.MinimumSize = new Size(300, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(427, 30);
            txtNombre.TabIndex = 69;
            // 
            // txtContrasegna
            // 
            txtContrasegna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasegna.BackColor = Color.FromArgb(224, 224, 224);
            txtContrasegna.Location = new Point(254, 65);
            txtContrasegna.MinimumSize = new Size(300, 30);
            txtContrasegna.Name = "txtContrasegna";
            txtContrasegna.Size = new Size(377, 30);
            txtContrasegna.TabIndex = 68;
            txtContrasegna.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(224, 224, 224);
            txtUsuario.Location = new Point(254, 26);
            txtUsuario.MinimumSize = new Size(300, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(427, 30);
            txtUsuario.TabIndex = 67;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(22, 339);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 30);
            lblEmail.TabIndex = 66;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(22, 300);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 30);
            lblTelefono.TabIndex = 65;
            lblTelefono.Text = "Telefono:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.Location = new Point(22, 261);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(83, 30);
            lblCiudad.TabIndex = 64;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(22, 222);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(105, 30);
            lblDireccion.TabIndex = 63;
            lblDireccion.Text = "Dirección:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidos.Location = new Point(22, 144);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(103, 30);
            lblApellidos.TabIndex = 62;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(22, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 61;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(725, 421);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 60;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblContrasegna
            // 
            lblContrasegna.AutoSize = true;
            lblContrasegna.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasegna.Location = new Point(22, 65);
            lblContrasegna.Name = "lblContrasegna";
            lblContrasegna.Size = new Size(123, 30);
            lblContrasegna.TabIndex = 59;
            lblContrasegna.Text = "Contraseña:";
            // 
            // lblNombreUsu
            // 
            lblNombreUsu.AutoSize = true;
            lblNombreUsu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsu.Location = new Point(22, 26);
            lblNombreUsu.Name = "lblNombreUsu";
            lblNombreUsu.Size = new Size(88, 30);
            lblNombreUsu.TabIndex = 58;
            lblNombreUsu.Text = "Usuario:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(224, 224, 224);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(599, 421);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 57;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(254, 183);
            dtpNacimiento.MinimumSize = new Size(427, 30);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.ShowUpDown = true;
            dtpNacimiento.Size = new Size(427, 30);
            dtpNacimiento.TabIndex = 77;
            dtpNacimiento.Value = new DateTime(2023, 6, 5, 17, 6, 44, 0);
            // 
            // chkCertificados
            // 
            chkCertificados.AutoSize = true;
            chkCertificados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkCertificados.Location = new Point(254, 375);
            chkCertificados.MinimumSize = new Size(427, 30);
            chkCertificados.Name = "chkCertificados";
            chkCertificados.Size = new Size(427, 34);
            chkCertificados.TabIndex = 78;
            chkCertificados.Text = "Certificados";
            chkCertificados.UseVisualStyleBackColor = true;
            // 
            // frmGestionarPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 484);
            Controls.Add(chkCertificados);
            Controls.Add(dtpNacimiento);
            Controls.Add(lblFechaNac);
            Controls.Add(btnVer);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtContrasegna);
            Controls.Add(txtUsuario);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblCiudad);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(lblContrasegna);
            Controls.Add(lblNombreUsu);
            Controls.Add(btnAceptar);
            Name = "frmGestionarPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionarPacientes";
            FormClosing += frmGestionarPacientes_FormClosing;
            Load += frmGestionarPacientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFechaNac;
        private Button btnVer;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtCiudad;
        private TextBox txtDireccion;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtContrasegna;
        private TextBox txtUsuario;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblCiudad;
        private Label lblDireccion;
        private Label lblApellidos;
        private Label lblNombre;
        private Button btnCancelar;
        private Label lblContrasegna;
        private Label lblNombreUsu;
        private Button btnAceptar;
        private DateTimePicker dtpNacimiento;
        private CheckBox chkCertificados;
    }
}