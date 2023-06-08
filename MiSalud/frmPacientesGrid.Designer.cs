namespace MiSalud
{
    partial class frmPacientesGrid
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
            dgvPacientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ID_USUARIO = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDOS = new DataGridViewTextBoxColumn();
            FECHA_NACIMIENTO = new DataGridViewTextBoxColumn();
            DIRECCION = new DataGridViewTextBoxColumn();
            CIUDAD = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            CERTIFICADO_VACUNACION = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(224, 224, 224);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(660, 400);
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
            btnModificar.Location = new Point(138, 400);
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
            btnEliminar.Location = new Point(264, 400);
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
            btnAnyadir.Location = new Point(12, 400);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(120, 38);
            btnAnyadir.TabIndex = 20;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = false;
            btnAnyadir.Click += btnAnyadir_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { ID, ID_USUARIO, NOMBRE, APELLIDOS, FECHA_NACIMIENTO, DIRECCION, CIUDAD, TELEFONO, EMAIL, CERTIFICADO_VACUNACION });
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(12, 42);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowTemplate.Height = 25;
            dgvPacientes.Size = new Size(768, 345);
            dgvPacientes.TabIndex = 19;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // ID_USUARIO
            // 
            ID_USUARIO.DataPropertyName = "ID_USUARIO";
            ID_USUARIO.HeaderText = "Id_usuario";
            ID_USUARIO.Name = "ID_USUARIO";
            ID_USUARIO.ReadOnly = true;
            ID_USUARIO.Visible = false;
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NOMBRE";
            NOMBRE.FillWeight = 100.41378F;
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // APELLIDOS
            // 
            APELLIDOS.DataPropertyName = "APELLIDOS";
            APELLIDOS.FillWeight = 93.7834244F;
            APELLIDOS.HeaderText = "Apellidos";
            APELLIDOS.Name = "APELLIDOS";
            APELLIDOS.ReadOnly = true;
            // 
            // FECHA_NACIMIENTO
            // 
            FECHA_NACIMIENTO.DataPropertyName = "FECHA_NACIMIENTO";
            FECHA_NACIMIENTO.FillWeight = 87.01844F;
            FECHA_NACIMIENTO.HeaderText = "Fecha Nacimiento";
            FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO";
            FECHA_NACIMIENTO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            DIRECCION.DataPropertyName = "DIRECCION";
            DIRECCION.FillWeight = 118.848778F;
            DIRECCION.HeaderText = "Dirección";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.ReadOnly = true;
            // 
            // CIUDAD
            // 
            CIUDAD.DataPropertyName = "CIUDAD";
            CIUDAD.FillWeight = 111.225067F;
            CIUDAD.HeaderText = "Ciudad";
            CIUDAD.Name = "CIUDAD";
            CIUDAD.ReadOnly = true;
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "TELEFONO";
            TELEFONO.FillWeight = 103.237709F;
            TELEFONO.HeaderText = "Nº Teléfono";
            TELEFONO.Name = "TELEFONO";
            TELEFONO.ReadOnly = true;
            // 
            // EMAIL
            // 
            EMAIL.DataPropertyName = "EMAIL";
            EMAIL.FillWeight = 95.1951752F;
            EMAIL.HeaderText = "Email";
            EMAIL.Name = "EMAIL";
            EMAIL.ReadOnly = true;
            // 
            // CERTIFICADO_VACUNACION
            // 
            CERTIFICADO_VACUNACION.DataPropertyName = "CERTIFICADO_VACUNACION";
            CERTIFICADO_VACUNACION.FillWeight = 90.27755F;
            CERTIFICADO_VACUNACION.HeaderText = "Certificado";
            CERTIFICADO_VACUNACION.Name = "CERTIFICADO_VACUNACION";
            CERTIFICADO_VACUNACION.ReadOnly = true;
            CERTIFICADO_VACUNACION.TrueValue = "";
            // 
            // frmPacientesGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnyadir);
            Controls.Add(dgvPacientes);
            Name = "frmPacientesGrid";
            Text = "Pacientes";
            Load += frmPacientesGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAnyadir;
        private DataGridView dgvPacientes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ID_USUARIO;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDOS;
        private DataGridViewTextBoxColumn FECHA_NACIMIENTO;
        private DataGridViewTextBoxColumn DIRECCION;
        private DataGridViewTextBoxColumn CIUDAD;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewCheckBoxColumn CERTIFICADO_VACUNACION;
    }
}