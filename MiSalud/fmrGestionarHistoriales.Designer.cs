namespace MiSalud
{
    partial class fmrGestionarHistoriales
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
            dtpFechaIni = new DateTimePicker();
            lblFechaIni = new Label();
            lblNombreM = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dtpFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            cboMedicamento = new ComboBox();
            SuspendLayout();
            // 
            // dtpFechaIni
            // 
            dtpFechaIni.Format = DateTimePickerFormat.Short;
            dtpFechaIni.Location = new Point(272, 70);
            dtpFechaIni.MinimumSize = new Size(427, 30);
            dtpFechaIni.Name = "dtpFechaIni";
            dtpFechaIni.ShowUpDown = true;
            dtpFechaIni.Size = new Size(427, 30);
            dtpFechaIni.TabIndex = 85;
            dtpFechaIni.Value = new DateTime(2023, 6, 5, 17, 6, 44, 0);
            // 
            // lblFechaIni
            // 
            lblFechaIni.AutoSize = true;
            lblFechaIni.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaIni.Location = new Point(40, 70);
            lblFechaIni.Name = "lblFechaIni";
            lblFechaIni.Size = new Size(128, 30);
            lblFechaIni.TabIndex = 84;
            lblFechaIni.Text = "Fecha Inicio:";
            // 
            // lblNombreM
            // 
            lblNombreM.AutoSize = true;
            lblNombreM.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreM.Location = new Point(40, 25);
            lblNombreM.Name = "lblNombreM";
            lblNombreM.Size = new Size(146, 30);
            lblNombreM.TabIndex = 81;
            lblNombreM.Text = "Medicamento:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(725, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 38);
            btnCancelar.TabIndex = 80;
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
            btnAceptar.Location = new Point(599, 178);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 78;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(272, 116);
            dtpFechaFin.MinimumSize = new Size(427, 30);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.ShowUpDown = true;
            dtpFechaFin.Size = new Size(427, 30);
            dtpFechaFin.TabIndex = 87;
            dtpFechaFin.Value = new DateTime(2023, 6, 5, 17, 6, 44, 0);
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaFin.Location = new Point(40, 116);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(121, 30);
            lblFechaFin.TabIndex = 86;
            lblFechaFin.Text = "Fecha Final:";
            // 
            // cboMedicamento
            // 
            cboMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedicamento.FormattingEnabled = true;
            cboMedicamento.Location = new Point(272, 30);
            cboMedicamento.Name = "cboMedicamento";
            cboMedicamento.Size = new Size(427, 23);
            cboMedicamento.TabIndex = 88;
            // 
            // fmrGestionarHistoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(867, 241);
            Controls.Add(cboMedicamento);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaIni);
            Controls.Add(lblFechaIni);
            Controls.Add(lblNombreM);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "fmrGestionarHistoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Historial";
            FormClosing += fmrGestionarHistoriales_FormClosing;
            Load += fmrGestionarHistoriales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaIni;
        private Label lblFechaIni;
        private Label lblNombreM;
        private Button btnCancelar;
        private Button btnAceptar;
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
        private ComboBox cboMedicamento;
    }
}