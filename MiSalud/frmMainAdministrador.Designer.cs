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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMedicos = new Button();
            btnPacientes = new Button();
            btnMedicamentos = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            mnsMenu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMedicos);
            flowLayoutPanel1.Controls.Add(btnPacientes);
            flowLayoutPanel1.Controls.Add(btnMedicamentos);
            flowLayoutPanel1.Location = new Point(285, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(415, 393);
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
            btnMedicamentos.Location = new Point(3, 209);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(200, 200);
            btnMedicamentos.TabIndex = 4;
            btnMedicamentos.UseVisualStyleBackColor = false;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // frmMainAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            Name = "frmMainAdministrador";
            Text = "H.T.MiSalud";
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMedicos;
        private Button btnPacientes;
        private Button btnMedicamentos;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}