namespace MiSalud
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContrasegna = new TextBox();
            btnConsectarse = new Button();
            lblPreguntaCuenta = new Label();
            lblkRegistrar = new LinkLabel();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(224, 224, 224);
            txtUsuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(153, 57);
            txtUsuario.MaximumSize = new Size(282, 100);
            txtUsuario.MinimumSize = new Size(282, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(282, 50);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasegna
            // 
            txtContrasegna.BackColor = Color.FromArgb(224, 224, 224);
            txtContrasegna.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasegna.Location = new Point(153, 113);
            txtContrasegna.MaximumSize = new Size(282, 100);
            txtContrasegna.MinimumSize = new Size(282, 50);
            txtContrasegna.Name = "txtContrasegna";
            txtContrasegna.PlaceholderText = "Contraseña";
            txtContrasegna.Size = new Size(282, 50);
            txtContrasegna.TabIndex = 2;
            txtContrasegna.UseSystemPasswordChar = true;
            // 
            // btnConsectarse
            // 
            btnConsectarse.BackColor = Color.DodgerBlue;
            btnConsectarse.FlatStyle = FlatStyle.Popup;
            btnConsectarse.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsectarse.ForeColor = Color.White;
            btnConsectarse.Location = new Point(153, 169);
            btnConsectarse.Name = "btnConsectarse";
            btnConsectarse.Size = new Size(282, 50);
            btnConsectarse.TabIndex = 3;
            btnConsectarse.Text = "Conectarse";
            btnConsectarse.UseVisualStyleBackColor = false;
            btnConsectarse.Click += btnConsectarse_Click;
            // 
            // lblPreguntaCuenta
            // 
            lblPreguntaCuenta.AutoSize = true;
            lblPreguntaCuenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreguntaCuenta.ForeColor = Color.FromArgb(64, 64, 64);
            lblPreguntaCuenta.Location = new Point(12, 257);
            lblPreguntaCuenta.Name = "lblPreguntaCuenta";
            lblPreguntaCuenta.Size = new Size(162, 20);
            lblPreguntaCuenta.TabIndex = 4;
            lblPreguntaCuenta.Text = "¿No tienes una cuenta?";
            // 
            // lblkRegistrar
            // 
            lblkRegistrar.AutoSize = true;
            lblkRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblkRegistrar.LinkColor = Color.Black;
            lblkRegistrar.Location = new Point(44, 277);
            lblkRegistrar.Name = "lblkRegistrar";
            lblkRegistrar.Size = new Size(88, 20);
            lblkRegistrar.TabIndex = 6;
            lblkRegistrar.TabStop = true;
            lblkRegistrar.Text = "Registrarse";
            lblkRegistrar.LinkClicked += lblkRegistrar_LinkClicked;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(594, 338);
            Controls.Add(lblkRegistrar);
            Controls.Add(lblPreguntaCuenta);
            Controls.Add(btnConsectarse);
            Controls.Add(txtContrasegna);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(610, 377);
            Name = "frmInicio";
            Text = "H.T.MiSalud";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasegna;
        private Button btnConsectarse;
        private Label lblPreguntaCuenta;
        private LinkLabel lblkRegistrar;
    }
}