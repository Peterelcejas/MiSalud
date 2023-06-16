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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAdministrador));
            mnsMenu = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmMedicos = new ToolStripMenuItem();
            tsmPacientes = new ToolStripMenuItem();
            tsmMedicamentos = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnMedicos = new ToolStripButton();
            btnPacientes = new ToolStripButton();
            btnMedicamentos = new ToolStripButton();
            mnsMenu.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMedicos, btnPacientes, btnMedicamentos });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.MinimumSize = new Size(800, 50);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 50);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMedicos
            // 
            btnMedicos.AutoSize = false;
            btnMedicos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMedicos.Image = (Image)resources.GetObject("btnMedicos.Image");
            btnMedicos.ImageTransparentColor = Color.Magenta;
            btnMedicos.Margin = new Padding(8, 0, 8, 0);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(50, 50);
            btnMedicos.Text = "Médicos";
            btnMedicos.ToolTipText = "Medicos";
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.AutoSize = false;
            btnPacientes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPacientes.Image = (Image)resources.GetObject("btnPacientes.Image");
            btnPacientes.ImageTransparentColor = Color.Magenta;
            btnPacientes.Margin = new Padding(8, 0, 8, 0);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(50, 50);
            btnPacientes.Text = "Pacientes";
            btnPacientes.ToolTipText = "Pacientes";
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.AutoSize = false;
            btnMedicamentos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMedicamentos.Image = (Image)resources.GetObject("btnMedicamentos.Image");
            btnMedicamentos.ImageTransparentColor = Color.Magenta;
            btnMedicamentos.Margin = new Padding(8, 0, 8, 0);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(50, 50);
            btnMedicamentos.Text = "Medicamentos";
            btnMedicamentos.ToolTipText = "Medicamentos";
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // frmMainAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            Name = "frmMainAdministrador";
            Text = "H.T.MiSalud";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMenu;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmMedicos;
        private ToolStripMenuItem tsmPacientes;
        private ToolStripMenuItem tsmMedicamentos;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMedicos;
        private ToolStripButton btnPacientes;
        private ToolStripButton btnMedicamentos;
    }
}