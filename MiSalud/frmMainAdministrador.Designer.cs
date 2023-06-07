namespace MiSalud
{
    partial class frmMainAdministrador
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
            mnsMenu = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmMedicos = new ToolStripMenuItem();
            tsmPacientes = new ToolStripMenuItem();
            tsmMedicamentos = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMedicos = new Button();
            btnPacientes = new Button();
            btnMedicamentos = new Button();
            mnsMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = SystemColors.ControlLight;
            mnsMenu.Items.AddRange(new ToolStripItem[] { tsmAdmin });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 0;
            mnsMenu.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            tsmAdmin.DropDownItems.AddRange(new ToolStripItem[] { tsmMedicos, tsmPacientes, tsmMedicamentos });
            tsmAdmin.Name = "tsmAdmin";
            tsmAdmin.Size = new Size(100, 20);
            tsmAdmin.Text = "&Administración";
            // 
            // tsmMedicos
            // 
            tsmMedicos.Name = "tsmMedicos";
            tsmMedicos.Size = new Size(212, 22);
            tsmMedicos.Text = "&Medicos";
            tsmMedicos.Click += medicosToolStripMenuItem_Click;
            // 
            // tsmPacientes
            // 
            tsmPacientes.Name = "tsmPacientes";
            tsmPacientes.Size = new Size(212, 22);
            tsmPacientes.Text = "&Pacientes";
            tsmPacientes.Click += pacientesToolStripMenuItem_Click;
            // 
            // tsmMedicamentos
            // 
            tsmMedicamentos.Name = "tsmMedicamentos";
            tsmMedicamentos.Size = new Size(212, 22);
            tsmMedicamentos.Text = "Gestión de Medicamentos";
            tsmMedicamentos.Click += gestiónDeMedicamentosToolStripMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMedicos);
            flowLayoutPanel1.Controls.Add(btnPacientes);
            flowLayoutPanel1.Controls.Add(btnMedicamentos);
            flowLayoutPanel1.Location = new Point(0, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 424);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = SystemColors.ControlLight;
            btnMedicos.Location = new Point(3, 3);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(200, 200);
            btnMedicos.TabIndex = 2;
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = SystemColors.ControlLight;
            btnPacientes.Location = new Point(209, 3);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(200, 200);
            btnPacientes.TabIndex = 3;
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.BackColor = SystemColors.ControlLight;
            btnMedicamentos.Location = new Point(415, 3);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(200, 200);
            btnMedicamentos.TabIndex = 4;
            btnMedicamentos.UseVisualStyleBackColor = false;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // frmMainAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            Name = "frmMainAdministrador";
            Text = "H.T.MiSalud";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenu;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmMedicos;
        private ToolStripMenuItem tsmPacientes;
        private ToolStripMenuItem tsmMedicamentos;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMedicos;
        private Button btnPacientes;
        private Button btnMedicamentos;
    }
}