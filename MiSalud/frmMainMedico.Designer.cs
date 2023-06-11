namespace MiSalud
{
    partial class frmMainMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMedico));
            toolStrip1 = new ToolStrip();
            btnCitas = new ToolStripButton();
            btnCertificados = new ToolStripButton();
            btnMedicamentos = new ToolStripButton();
            mnsMenu = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmCitas = new ToolStripMenuItem();
            tsmCertificados = new ToolStripMenuItem();
            tsmMedicamentos = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCitas, btnCertificados, btnMedicamentos });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.MinimumSize = new Size(800, 50);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 50);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCitas
            // 
            btnCitas.AutoSize = false;
            btnCitas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCitas.Image = (Image)resources.GetObject("btnCitas.Image");
            btnCitas.ImageTransparentColor = Color.Magenta;
            btnCitas.Margin = new Padding(8, 0, 8, 0);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(50, 50);
            btnCitas.Text = "Medicos";
            btnCitas.ToolTipText = "Medicos";
            btnCitas.Click += btnCitas_Click;
            // 
            // btnCertificados
            // 
            btnCertificados.AutoSize = false;
            btnCertificados.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCertificados.Image = (Image)resources.GetObject("btnCertificados.Image");
            btnCertificados.ImageTransparentColor = Color.Magenta;
            btnCertificados.Margin = new Padding(8, 0, 8, 0);
            btnCertificados.Name = "btnCertificados";
            btnCertificados.Size = new Size(50, 50);
            btnCertificados.Text = "Pacientes";
            btnCertificados.ToolTipText = "Pacientes";
            btnCertificados.Click += btnCertificados_Click;
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
            // mnsMenu
            // 
            mnsMenu.BackColor = SystemColors.ControlLight;
            mnsMenu.Items.AddRange(new ToolStripItem[] { tsmAdmin });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 3;
            mnsMenu.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            tsmAdmin.DropDownItems.AddRange(new ToolStripItem[] { tsmCitas, tsmCertificados, tsmMedicamentos });
            tsmAdmin.Name = "tsmAdmin";
            tsmAdmin.Size = new Size(100, 20);
            tsmAdmin.Text = "&Administración";
            // 
            // tsmCitas
            // 
            tsmCitas.Name = "tsmCitas";
            tsmCitas.Size = new Size(212, 22);
            tsmCitas.Text = "&Citas";
            tsmCitas.Click += tsmCitas_Click;
            // 
            // tsmCertificados
            // 
            tsmCertificados.Name = "tsmCertificados";
            tsmCertificados.Size = new Size(212, 22);
            tsmCertificados.Text = "Gestión de Certidicados";
            tsmCertificados.Click += tsmCertificados_Click;
            // 
            // tsmMedicamentos
            // 
            tsmMedicamentos.Name = "tsmMedicamentos";
            tsmMedicamentos.Size = new Size(212, 22);
            tsmMedicamentos.Text = "Gestión de Medicamentos";
            tsmMedicamentos.Click += tsmMedicamentos_Click;
            // 
            // frmMainMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(mnsMenu);
            Name = "frmMainMedico";
            Text = "frmMainMedico";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCitas;
        private ToolStripButton btnCertificados;
        private ToolStripButton btnMedicamentos;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmCitas;
        private ToolStripMenuItem tsmCertificados;
        private ToolStripMenuItem tsmMedicamentos;
    }
}