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
    public partial class frmCitasGrid : Form
    {
        public int Medico { get; internal set; }

        public frmCitasGrid()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.citas_32;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se va a eliminar la cita ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvMedicos.SelectedCells.Count > 0)
                    {
                        int fila = dgvMedicos.SelectedCells[0].RowIndex;
                        VarGlobal.EjecutaSentencia("DELETE FROM CITAS WHERE ID = " + dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());
                        CargarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedCells.Count > 0)
            {
                int fila = dgvMedicos.SelectedCells[0].RowIndex;
                frmGestionarCitas frmGestionarCitas = new frmGestionarCitas();
                frmGestionarCitas.Cita = Convert.ToInt32(dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());
                frmGestionarCitas.Medico = Convert.ToInt32(dgvMedicos.Rows[fila].Cells["IDM"].Value.ToString());
                frmGestionarCitas.ShowDialog();
                CargarGrid();
            }
        }

        private void CitasGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT C.ID, C.ID_MEDICO AS IDM, CONCAT(C.FECHA || ' ' || C.HORA || 'H') AS FECHA, M.NOMBRE AS MEDICO, P.NOMBRE AS PACIENTE, C.MOTIVO_CONSULTA FROM citas AS C " +
                    "LEFT JOIN MEDICOS AS M ON C.ID_MEDICO = M.ID LEFT JOIN PACIENTES AS P ON C.ID_PACIENTE = P.ID WHERE C.ID_MEDICO = " + this.Medico);
                dgvMedicos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
