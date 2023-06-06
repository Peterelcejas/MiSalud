namespace MiSalud
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            btnAceptar = new Button();
            lblNombreUsu = new Label();
            lblContrasegna = new Label();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsuario = new TextBox();
            txtContrasegna = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnVer = new Button();
            dtpNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(224, 224, 224);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(609, 424);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblNombreUsu
            // 
            lblNombreUsu.AutoSize = true;
            lblNombreUsu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsu.Location = new Point(32, 29);
            lblNombreUsu.Name = "lblNombreUsu";
            lblNombreUsu.Size = new Size(88, 30);
            lblNombreUsu.TabIndex = 12;
            lblNombreUsu.Text = "Usuario:";
            // 
            // lblContrasegna
            // 
            lblContrasegna.AutoSize = true;
            lblContrasegna.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasegna.Location = new Point(32, 68);
            lblContrasegna.Name = "lblContrasegna";
            lblContrasegna.Size = new Size(123, 30);
            lblContrasegna.TabIndex = 13;
            lblContrasegna.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(735, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 107);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 15;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 147);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 16;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 188);
            label3.Name = "label3";
            label3.Size = new Size(210, 30);
            label3.TabIndex = 17;
            label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 230);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 18;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 270);
            label5.Name = "label5";
            label5.Size = new Size(83, 30);
            label5.TabIndex = 19;
            label5.Text = "Ciudad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 311);
            label6.Name = "label6";
            label6.Size = new Size(97, 30);
            label6.TabIndex = 20;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 353);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 21;
            label7.Text = "Email:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(224, 224, 224);
            txtUsuario.Location = new Point(264, 29);
            txtUsuario.MinimumSize = new Size(300, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(427, 30);
            txtUsuario.TabIndex = 24;
            // 
            // txtContrasegna
            // 
            txtContrasegna.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContrasegna.BackColor = Color.FromArgb(224, 224, 224);
            txtContrasegna.Location = new Point(264, 68);
            txtContrasegna.MinimumSize = new Size(300, 30);
            txtContrasegna.Name = "txtContrasegna";
            txtContrasegna.Size = new Size(377, 30);
            txtContrasegna.TabIndex = 25;
            txtContrasegna.Text = "fdasdfç";
            txtContrasegna.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(224, 224, 224);
            txtNombre.Location = new Point(264, 107);
            txtNombre.MinimumSize = new Size(300, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(427, 30);
            txtNombre.TabIndex = 26;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApellidos.BackColor = Color.FromArgb(224, 224, 224);
            txtApellidos.Location = new Point(264, 147);
            txtApellidos.MinimumSize = new Size(300, 30);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(427, 30);
            txtApellidos.TabIndex = 27;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.BackColor = Color.FromArgb(224, 224, 224);
            txtDireccion.Location = new Point(264, 230);
            txtDireccion.MinimumSize = new Size(300, 30);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(427, 30);
            txtDireccion.TabIndex = 29;
            // 
            // txtCiudad
            // 
            txtCiudad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCiudad.BackColor = Color.FromArgb(224, 224, 224);
            txtCiudad.Location = new Point(264, 270);
            txtCiudad.MinimumSize = new Size(300, 30);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(427, 30);
            txtCiudad.TabIndex = 30;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(224, 224, 224);
            txtTelefono.Location = new Point(264, 311);
            txtTelefono.MaxLength = 9;
            txtTelefono.MinimumSize = new Size(300, 30);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(427, 30);
            txtTelefono.TabIndex = 31;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtEmail.Location = new Point(264, 353);
            txtEmail.MinimumSize = new Size(300, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(427, 30);
            txtEmail.TabIndex = 32;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Location = new Point(647, 68);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(44, 30);
            btnVer.TabIndex = 33;
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(264, 188);
            dtpNacimiento.MinimumSize = new Size(427, 30);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.ShowUpDown = true;
            dtpNacimiento.Size = new Size(427, 30);
            dtpNacimiento.TabIndex = 34;
            dtpNacimiento.Value = new DateTime(2023, 6, 5, 17, 6, 44, 0);
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 484);
            Controls.Add(dtpNacimiento);
            Controls.Add(btnVer);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtContrasegna);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(lblContrasegna);
            Controls.Add(lblNombreUsu);
            Controls.Add(btnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistrar";
            Text = "Nuevo Usuario";
            FormClosing += frmRegistrar_FormClosing;
            Load += frmRegistrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lblkRegistrar;
        private Label lblPreguntaCuenta;
        private Button btnAceptar;
        private Label lblNombreUsu;
        private Label lblContrasegna;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsuario;
        private TextBox txtContrasegna;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnVer;
        private DateTimePicker dtpNacimiento;
    }
}