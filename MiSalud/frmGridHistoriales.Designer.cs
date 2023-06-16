namespace MiSalud
{
    partial class frmGridHistoriales
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
            btnAnyadir = new Button();
            dgvHistorial = new DataGridView();
            NOMBREP = new DataGridViewTextBoxColumn();
            IDP = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            NOMBREM = new DataGridViewTextBoxColumn();
            FECHAI = new DataGridViewTextBoxColumn();
            FECHAF = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(224, 224, 224);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(661, 400);
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
            btnModificar.Location = new Point(139, 400);
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
            btnEliminar.Location = new Point(265, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 38);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAnyadir
            // 
            btnAnyadir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnyadir.BackColor = Color.FromArgb(224, 224, 224);
            btnAnyadir.FlatStyle = FlatStyle.Flat;
            btnAnyadir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnyadir.ForeColor = Color.Black;
            btnAnyadir.Location = new Point(13, 400);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(120, 38);
            btnAnyadir.TabIndex = 20;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = false;
            btnAnyadir.Click += btnAnyadir_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { NOMBREP, IDP, ID, NOMBREM, FECHAI, FECHAF });
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.Location = new Point(12, 42);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(768, 345);
            dgvHistorial.TabIndex = 19;
            // 
            // NOMBREP
            // 
            NOMBREP.DataPropertyName = "NOMBREP";
            NOMBREP.HeaderText = "Paciente";
            NOMBREP.Name = "NOMBREP";
            NOMBREP.ReadOnly = true;
            // 
            // IDP
            // 
            IDP.DataPropertyName = "IDP";
            IDP.HeaderText = "IDP";
            IDP.Name = "IDP";
            IDP.ReadOnly = true;
            IDP.Visible = false;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // NOMBREM
            // 
            NOMBREM.DataPropertyName = "NOMBREM";
            NOMBREM.HeaderText = "Medicamento";
            NOMBREM.Name = "NOMBREM";
            NOMBREM.ReadOnly = true;
            // 
            // FECHAI
            // 
            FECHAI.DataPropertyName = "FECHAI";
            FECHAI.HeaderText = "Fecha Inicio";
            FECHAI.Name = "FECHAI";
            FECHAI.ReadOnly = true;
            // 
            // FECHAF
            // 
            FECHAF.DataPropertyName = "FECHAF";
            FECHAF.HeaderText = "Fecha Final";
            FECHAF.Name = "FECHAF";
            FECHAF.ReadOnly = true;
            // 
            // frmGridHistoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnyadir);
            Controls.Add(dgvHistorial);
            Name = "frmGridHistoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historiales";
            Load += frmGridHistoriales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAnyadir;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn NOMBREP;
        private DataGridViewTextBoxColumn IDP;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBREM;
        private DataGridViewTextBoxColumn FECHAI;
        private DataGridViewTextBoxColumn FECHAF;
    }
}