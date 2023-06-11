namespace MiSalud
{
    partial class frmGestionarCitas
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
            lblHora = new Label();
            lblMedico = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cboMedico = new ComboBox();
            cboHora = new ComboBox();
            mtcFecha = new MonthCalendar();
            lblFecha = new Label();
            txtFechaCita = new TextBox();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(21, 56);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(63, 30);
            lblHora.TabIndex = 63;
            lblHora.Text = "Hora:";
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedico.Location = new Point(21, 12);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(87, 30);
            lblMedico.TabIndex = 62;
            lblMedico.Text = "Medico:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(735, 401);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 61;
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
            btnAceptar.Location = new Point(609, 401);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 60;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(224, 21);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(323, 23);
            cboMedico.TabIndex = 90;
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
            // 
            // cboHora
            // 
            cboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHora.Enabled = false;
            cboHora.FormattingEnabled = true;
            cboHora.Location = new Point(224, 60);
            cboHora.Name = "cboHora";
            cboHora.Size = new Size(55, 23);
            cboHora.TabIndex = 91;
            cboHora.SelectedIndexChanged += cboHora_SelectedIndexChanged;
            // 
            // mtcFecha
            // 
            mtcFecha.Enabled = false;
            mtcFecha.Location = new Point(625, 21);
            mtcFecha.Name = "mtcFecha";
            mtcFecha.TabIndex = 92;
            mtcFecha.DateChanged += mtcFecha_DateChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(21, 101);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(114, 30);
            lblFecha.TabIndex = 93;
            lblFecha.Text = "Fecha Cita:";
            // 
            // txtFechaCita
            // 
            txtFechaCita.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFechaCita.BackColor = Color.FromArgb(224, 224, 224);
            txtFechaCita.Location = new Point(224, 101);
            txtFechaCita.MinimumSize = new Size(300, 30);
            txtFechaCita.Name = "txtFechaCita";
            txtFechaCita.ReadOnly = true;
            txtFechaCita.Size = new Size(323, 30);
            txtFechaCita.TabIndex = 94;
            // 
            // frmGestionarCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 451);
            Controls.Add(txtFechaCita);
            Controls.Add(lblFecha);
            Controls.Add(mtcFecha);
            Controls.Add(cboHora);
            Controls.Add(cboMedico);
            Controls.Add(lblHora);
            Controls.Add(lblMedico);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmGestionarCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cita";
            FormClosing += frmGestionarCitas_FormClosing;
            Load += frmGestionarCitas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHora;
        private Label lblMedico;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cboMedico;
        private ComboBox cboHora;
        private MonthCalendar mtcFecha;
        private Label lblFecha;
        private TextBox txtFechaCita;
    }
}