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
    public partial class frmMainMedico : Form
    {
        public int Usuario { get; internal set; }

        public frmMainMedico()
        {
            InitializeComponent();
        }

        private void tsmCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void tsmCertificados_Click(object sender, EventArgs e)
        {
            AbirCertificados();
        }

        private void tsmMedicamentos_Click(object sender, EventArgs e)
        {
            AbirMedicamentos();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            AbirCertificados();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            AbirMedicamentos();
        }
        private void AbirMedicamentos()
        {
            frmMedicamentosGrid frmMedicamentosGrid = new frmMedicamentosGrid();
            frmMedicamentosGrid.ShowDialog();
        }
        private void AbirCitas()
        {
            try
            {
                frmCitasGrid frmCitasGrid = new frmCitasGrid();
                frmCitasGrid.Usuario = 1;
                frmCitasGrid.Medico = Convert.ToInt32(VarGlobal.EjecutaConsulta("SELECT M.ID FROM USUARIOS AS S LEFT JOIN MEDICOS AS M ON S.ID = M.ID_USUARIO WHERE S.ID = " + this.Usuario));
                frmCitasGrid.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbirCertificados()
        {
        }
    }
}
