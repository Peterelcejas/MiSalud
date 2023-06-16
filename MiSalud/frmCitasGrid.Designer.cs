namespace MiSalud
{
    partial class frmCitasGrid
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSalir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvCitas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IDM = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            MEDICO = new DataGridViewTextBoxColumn();
            PACIENTE = new DataGridViewTextBoxColumn();
            MOTIVO_CONSULTA = new DataGridViewTextBoxColumn();
            btnAnyadir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(224, 224, 224);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(664, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 38);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.BackColor = Color.FromArgb(224, 224, 224);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(142, 385);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 38);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(224, 224, 224);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(267, 385);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 38);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { ID, IDM, FECHA, MEDICO, PACIENTE, MOTIVO_CONSULTA });
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.Location = new Point(16, 27);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowTemplate.Height = 25;
            dgvCitas.Size = new Size(768, 345);
            dgvCitas.TabIndex = 19;
            dgvCitas.SelectionChanged += dgvMedicos_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // IDM
            // 
            IDM.DataPropertyName = "IDM";
            IDM.HeaderText = "IDM";
            IDM.Name = "IDM";
            IDM.ReadOnly = true;
            IDM.Visible = false;
            // 
            // FECHA
            // 
            FECHA.DataPropertyName = "FECHA";
            FECHA.HeaderText = "Fecha Cita";
            FECHA.Name = "FECHA";
            FECHA.ReadOnly = true;
            // 
            // MEDICO
            // 
            MEDICO.DataPropertyName = "MEDICO";
            MEDICO.HeaderText = "Medico";
            MEDICO.Name = "MEDICO";
            MEDICO.ReadOnly = true;
            // 
            // PACIENTE
            // 
            PACIENTE.DataPropertyName = "PACIENTE";
            PACIENTE.HeaderText = "Paciente";
            PACIENTE.Name = "PACIENTE";
            PACIENTE.ReadOnly = true;
            // 
            // MOTIVO_CONSULTA
            // 
            MOTIVO_CONSULTA.DataPropertyName = "MOTIVO_CONSULTA";
            MOTIVO_CONSULTA.HeaderText = "Motivo de Consulta";
            MOTIVO_CONSULTA.Name = "MOTIVO_CONSULTA";
            MOTIVO_CONSULTA.ReadOnly = true;
            // 
            // btnAnyadir
            // 
            btnAnyadir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnyadir.BackColor = Color.FromArgb(224, 224, 224);
            btnAnyadir.FlatStyle = FlatStyle.Flat;
            btnAnyadir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnyadir.ForeColor = Color.Black;
            btnAnyadir.Location = new Point(16, 385);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(120, 38);
            btnAnyadir.TabIndex = 24;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = false;
            btnAnyadir.Click += btnAnyadir_Click;
            // 
            // frmCitasGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnyadir);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvCitas);
            Name = "frmCitasGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += CitasGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvCitas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IDM;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn MEDICO;
        private DataGridViewTextBoxColumn PACIENTE;
        private DataGridViewTextBoxColumn MOTIVO_CONSULTA;
        private Button btnAnyadir;
    }
}