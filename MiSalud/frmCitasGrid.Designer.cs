﻿namespace MiSalud
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnSalir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvMedicos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IDM = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            MEDICO = new DataGridViewTextBoxColumn();
            PACIENTE = new DataGridViewTextBoxColumn();
            MOTIVO_CONSULTA = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
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
            btnModificar.Location = new Point(15, 385);
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
            btnEliminar.Location = new Point(141, 385);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 38);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Columns.AddRange(new DataGridViewColumn[] { ID, IDM, FECHA, MEDICO, PACIENTE, MOTIVO_CONSULTA });
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Location = new Point(16, 27);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowTemplate.Height = 25;
            dgvMedicos.Size = new Size(768, 345);
            dgvMedicos.TabIndex = 19;
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
            // frmCitasGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMedicos);
            Name = "frmCitasGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            Load += CitasGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvMedicos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IDM;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn MEDICO;
        private DataGridViewTextBoxColumn PACIENTE;
        private DataGridViewTextBoxColumn MOTIVO_CONSULTA;
    }
}