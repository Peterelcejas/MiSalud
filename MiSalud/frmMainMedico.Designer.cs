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
            btnPacientes = new ToolStripButton();
            mnsMenu = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmCitas = new ToolStripMenuItem();
            tsmPacientes = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCitas, btnPacientes });
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
            btnCitas.Text = "Citas";
            btnCitas.ToolTipText = "Citas";
            btnCitas.Click += btnCitas_Click;
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
            tsmAdmin.DropDownItems.AddRange(new ToolStripItem[] { tsmCitas, tsmPacientes });
            tsmAdmin.Name = "tsmAdmin";
            tsmAdmin.Size = new Size(100, 20);
            tsmAdmin.Text = "&Administración";
            // 
            // tsmCitas
            // 
            tsmCitas.Name = "tsmCitas";
            tsmCitas.Size = new Size(124, 22);
            tsmCitas.Text = "&Citas";
            tsmCitas.Click += tsmCitas_Click;
            // 
            // tsmPacientes
            // 
            tsmPacientes.Name = "tsmPacientes";
            tsmPacientes.Size = new Size(124, 22);
            tsmPacientes.Text = "&Pacientes";
            tsmPacientes.Click += tsmPacientes_Click;
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
            Text = "Médico";
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
        private ToolStripButton btnPacientes;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmCitas;
        private ToolStripMenuItem tsmPacientes;
    }
}