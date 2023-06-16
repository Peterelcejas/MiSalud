namespace MiSalud
{
    partial class frmGestionarMedicamentos
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
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.FromArgb(224, 224, 224);
            txtDescripcion.Location = new Point(256, 61);
            txtDescripcion.MinimumSize = new Size(300, 30);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(427, 30);
            txtDescripcion.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(224, 224, 224);
            txtNombre.Location = new Point(256, 22);
            txtNombre.MaxLength = 9;
            txtNombre.MinimumSize = new Size(300, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(427, 30);
            txtNombre.TabIndex = 58;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(24, 61);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(126, 30);
            lblDescripcion.TabIndex = 57;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(24, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 56;
            lblNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(724, 128);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 55;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(224, 224, 224);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(598, 128);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 54;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmGestionarMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 178);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmGestionarMedicamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Medicamento";
            FormClosing += frmGestionarMedicamentos_FormClosing;
            Load += frmGestionarMedicamentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private Label lblNombre;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}