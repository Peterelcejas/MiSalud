namespace MiSalud
{
    partial class frmMainPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPacientes));
            toolStrip1 = new ToolStrip();
            btnCitas = new ToolStripButton();
            btnHistorial = new ToolStripButton();
            mnsMenu = new MenuStrip();
            tsmAdmin = new ToolStripMenuItem();
            tsmCitas = new ToolStripMenuItem();
            tsmHistorial = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCitas, btnHistorial });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.MinimumSize = new Size(800, 50);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 50);
            toolStrip1.TabIndex = 6;
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
            // btnHistorial
            // 
            btnHistorial.AutoSize = false;
            btnHistorial.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnHistorial.Image = (Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.ImageTransparentColor = Color.Magenta;
            btnHistorial.Margin = new Padding(8, 0, 8, 0);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(50, 50);
            btnHistorial.Text = "Historial Médico";
            btnHistorial.ToolTipText = "Historial Médico";
            btnHistorial.Click += btnHistorial_Click;
            // 
            // mnsMenu
            // 
            mnsMenu.BackColor = SystemColors.ControlLight;
            mnsMenu.Items.AddRange(new ToolStripItem[] { tsmAdmin });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 5;
            mnsMenu.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            tsmAdmin.DropDownItems.AddRange(new ToolStripItem[] { tsmCitas, tsmHistorial });
            tsmAdmin.Name = "tsmAdmin";
            tsmAdmin.Size = new Size(100, 20);
            tsmAdmin.Text = "&Administración";
            // 
            // tsmCitas
            // 
            tsmCitas.Name = "tsmCitas";
            tsmCitas.Size = new Size(180, 22);
            tsmCitas.Text = "&Citas";
            tsmCitas.Click += tsmCitas_Click;
            // 
            // tsmHistorial
            // 
            tsmHistorial.Name = "tsmHistorial";
            tsmHistorial.Size = new Size(180, 22);
            tsmHistorial.Text = "Historial Médico";
            tsmHistorial.Click += tsmHistorial_Click;
            // 
            // frmMainPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(mnsMenu);
            Name = "frmMainPacientes";
            Text = "frmMainPacientes";
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
        private ToolStripButton btnHistorial;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem tsmAdmin;
        private ToolStripMenuItem tsmCitas;
        private ToolStripMenuItem tsmHistorial;
    }
}