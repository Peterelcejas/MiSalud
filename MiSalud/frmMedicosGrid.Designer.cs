namespace MiSalud
{
    partial class frmMedicosGrid
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
            dgvMedicos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ID_USUARIO = new DataGridViewTextBoxColumn();
            btnCitas = new DataGridViewButtonColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDOS = new DataGridViewTextBoxColumn();
            ESPECIALIDAD = new DataGridViewTextBoxColumn();
            CENTRO = new DataGridViewTextBoxColumn();
            CIUDAD = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnAnyadir = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
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
            dgvMedicos.Columns.AddRange(new DataGridViewColumn[] { ID, ID_USUARIO, btnCitas, NOMBRE, APELLIDOS, ESPECIALIDAD, CENTRO, CIUDAD, TELEFONO, EMAIL });
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Location = new Point(12, 42);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowTemplate.Height = 25;
            dgvMedicos.Size = new Size(768, 345);
            dgvMedicos.TabIndex = 0;
            dgvMedicos.CellClick += dgvMedicos_CellClick;
            dgvMedicos.ColumnHeaderMouseClick += dgvMedicos_ColumnHeaderMouseClick;
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
            // btnCitas
            // 
            btnCitas.HeaderText = "";
            btnCitas.Name = "btnCitas";
            btnCitas.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NOMBRE";
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // APELLIDOS
            // 
            APELLIDOS.DataPropertyName = "APELLIDOS";
            APELLIDOS.HeaderText = "Apellidos";
            APELLIDOS.Name = "APELLIDOS";
            APELLIDOS.ReadOnly = true;
            // 
            // ESPECIALIDAD
            // 
            ESPECIALIDAD.DataPropertyName = "ESPECIALIDAD";
            ESPECIALIDAD.HeaderText = "Especialidad";
            ESPECIALIDAD.Name = "ESPECIALIDAD";
            ESPECIALIDAD.ReadOnly = true;
            // 
            // CENTRO
            // 
            CENTRO.DataPropertyName = "CENTRO";
            CENTRO.HeaderText = "Centro";
            CENTRO.Name = "CENTRO";
            CENTRO.ReadOnly = true;
            // 
            // CIUDAD
            // 
            CIUDAD.DataPropertyName = "CIUDAD";
            CIUDAD.HeaderText = "Ciudad";
            CIUDAD.Name = "CIUDAD";
            CIUDAD.ReadOnly = true;
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "TELEFONO";
            TELEFONO.HeaderText = "Nº Teléfono";
            TELEFONO.Name = "TELEFONO";
            TELEFONO.ReadOnly = true;
            // 
            // EMAIL
            // 
            EMAIL.DataPropertyName = "EMAIL";
            EMAIL.HeaderText = "Email";
            EMAIL.Name = "EMAIL";
            EMAIL.ReadOnly = true;
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
            btnEliminar.TabIndex = 16;
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
            btnAnyadir.TabIndex = 15;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = false;
            btnAnyadir.Click += btnAnyadir_Click;
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
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnSalir.TabIndex = 18;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMedicosGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAnyadir);
            Controls.Add(dgvMedicos);
            Name = "frmMedicosGrid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Médicos";
            Load += frmMedicosGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMedicos;
        private Button btnEliminar;
        private Button btnAnyadir;
        private Button btnModificar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ID_USUARIO;
        private DataGridViewButtonColumn btnCitas;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDOS;
        private DataGridViewTextBoxColumn ESPECIALIDAD;
        private DataGridViewTextBoxColumn CENTRO;
        private DataGridViewTextBoxColumn CIUDAD;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn EMAIL;
    }
}