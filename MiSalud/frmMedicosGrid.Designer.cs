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
            btnEliminar = new Button();
            btnAceptar = new Button();
            button1 = new Button();
            btnSalir = new Button();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDOS = new DataGridViewTextBoxColumn();
            ESPECIALIDAD = new DataGridViewTextBoxColumn();
            CENTRO = new DataGridViewTextBoxColumn();
            CIUDAD = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicos
            // 
            dgvMedicos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvMedicos.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, APELLIDOS, ESPECIALIDAD, CENTRO, CIUDAD, TELEFONO, EMAIL });
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Location = new Point(12, 42);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.RowTemplate.Height = 25;
            dgvMedicos.Size = new Size(768, 345);
            dgvMedicos.TabIndex = 0;
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
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptar.BackColor = Color.FromArgb(224, 224, 224);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(12, 400);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 38);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Añadir";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(138, 400);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 17;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
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
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NOMBRE";
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDOS
            // 
            APELLIDOS.DataPropertyName = "APELLIDOS";
            APELLIDOS.HeaderText = "Apellidos";
            APELLIDOS.Name = "APELLIDOS";
            // 
            // ESPECIALIDAD
            // 
            ESPECIALIDAD.DataPropertyName = "ESPECIALIDAD";
            ESPECIALIDAD.HeaderText = "Especialidad";
            ESPECIALIDAD.Name = "ESPECIALIDAD";
            // 
            // CENTRO
            // 
            CENTRO.DataPropertyName = "CENTRO";
            CENTRO.HeaderText = "Centro";
            CENTRO.Name = "CENTRO";
            // 
            // CIUDAD
            // 
            CIUDAD.DataPropertyName = "CIUDAD";
            CIUDAD.HeaderText = "Ciudad";
            CIUDAD.Name = "CIUDAD";
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "TELEFONO";
            TELEFONO.HeaderText = "Nº Teléfono";
            TELEFONO.Name = "TELEFONO";
            // 
            // EMAIL
            // 
            EMAIL.DataPropertyName = "EMAIL";
            EMAIL.HeaderText = "Email";
            EMAIL.Name = "EMAIL";
            // 
            // frmMedicosGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvMedicos);
            Name = "frmMedicosGrid";
            Text = "Medicos";
            Load += frmMedicosGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMedicos;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button button1;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDOS;
        private DataGridViewTextBoxColumn ESPECIALIDAD;
        private DataGridViewTextBoxColumn CENTRO;
        private DataGridViewTextBoxColumn CIUDAD;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn EMAIL;
    }
}