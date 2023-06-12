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
            this.Icon = Properties.Resources.H_T_Misalud_logo;
            btnCitas.Image = Properties.Resources.citas_128;
            btnPacientes.Image = Properties.Resources.paciente_128;
        }

        private void tsmCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirPacientes();
        }

        private void tsmPacientes_Click(object sender, EventArgs e)
        {
            AbrirPacientes();
        }

        private void AbrirPacientes()
        {
            frmPacientesGrid frmPacientesGrid = new frmPacientesGrid();
            frmPacientesGrid.Usuario = this.Usuario;
            frmPacientesGrid.ShowDialog();
        }
        private void AbirCitas()
        {
            try
            {
                frmCitasGrid frmCitasGrid = new frmCitasGrid();
                frmCitasGrid.Usuario = this.Usuario;

                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT M.ID FROM USUARIOS AS S LEFT JOIN MEDICOS AS M ON S.ID = M.ID_USUARIO WHERE S.ID = " + this.Usuario);
                frmCitasGrid.Medico = Convert.ToInt32(tabla.Rows[0]["ID"].ToString());
                frmCitasGrid.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
