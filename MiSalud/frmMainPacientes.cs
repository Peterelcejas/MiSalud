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
    public partial class frmMainPacientes : Form
    {
        public frmMainPacientes()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.H_T_Misalud_logo;
            btnCitas.Image = Properties.Resources.citas_128;
            btnHistorial.Image = Properties.Resources.historial_128;
        }

        public int Usuario { get; internal set; }
        public int IdUsuario { get; internal set; }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirHistorial();
        }

        private void tsmCitas_Click(object sender, EventArgs e)
        {
            AbirCitas();
        }

        private void tsmHistorial_Click(object sender, EventArgs e)
        {
            AbrirHistorial();
        }

        private void AbirCitas()
        {
            try
            {
                frmCitasGrid frmCitasGrid = new frmCitasGrid();
                frmCitasGrid.Usuario = this.Usuario;

                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT P.ID FROM USUARIOS AS S LEFT JOIN PACIENTES AS P ON S.ID = P.ID_USUARIO WHERE S.ID = " + this.IdUsuario);
                frmCitasGrid.Paciente = Convert.ToInt32(tabla.Rows[0]["ID"].ToString());
                frmCitasGrid.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirHistorial()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT P.ID FROM USUARIOS AS S LEFT JOIN PACIENTES AS P ON S.ID = P.ID_USUARIO WHERE S.ID = " + this.IdUsuario); 
                
                frmGridHistoriales frmGridHistoriales = new frmGridHistoriales();
                frmGridHistoriales.Usuario = this.Usuario;
                frmGridHistoriales.Paciente = Convert.ToInt32(tabla.Rows[0]["ID"].ToString());
                frmGridHistoriales.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
