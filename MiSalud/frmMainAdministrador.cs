using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSalud
{
    public partial class frmMainAdministrador : Form
    {
        public frmMainAdministrador()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.H_T_Misalud_logo;
            btnMedicos.Image = Properties.Resources.medico_72;
            btnPacientes.Image = Properties.Resources.paciente_72;
            btnMedicamentos.Image = Properties.Resources.medicamentos_72;
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbirMedicos();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbirPacientes();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            AbirMedicamentos();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbirMedicos();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbirPacientes();
        }

        private void gestiónDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbirMedicamentos();
        }

        private void AbirMedicos()
        {
            frmMedicosGrid frmMedicosGrid = new frmMedicosGrid();
            frmMedicosGrid.ShowDialog();
        }

        private void AbirPacientes()
        {
            frmPacientesGrid frmPacientesGrid = new frmPacientesGrid();
            frmPacientesGrid.ShowDialog();
        }

        private void AbirMedicamentos()
        {
            frmMedicamentosGrid frmMedicamentosGrid = new frmMedicamentosGrid();
            frmMedicamentosGrid.ShowDialog();
        }
    }
}
