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
    public partial class frmMedicosGrid : Form
    {
        public frmMedicosGrid()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.medico_32;
        }

        private void frmMedicosGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicos.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Se va a eliminar el medico ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (dgvMedicos.SelectedCells.Count > 0)
                        {
                            int fila = dgvMedicos.SelectedCells[0].RowIndex;
                            DataTable tablaCitas = VarGlobal.EjecutaConsulta("SELECT * FROM CITAS LEFT JOIN MEDICOS ON CITAS.ID_MEDICO = MEDICOS.ID WHERE MEDICOS.ID = " + dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());

                            if (tablaCitas.Rows.Count > 0)
                            {
                                MessageBox.Show("No se puede eliminar tiene citas asociadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                VarGlobal.EjecutaSentencia("DELETE FROM MEDICOS WHERE ID = " + dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());
                                CargarGrid();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            frmGestionarMedicos frmGestionarMedicos = new frmGestionarMedicos();
            frmGestionarMedicos.Actualiza = false;
            frmGestionarMedicos.ShowDialog();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedCells.Count > 0)
            {
                int fila = dgvMedicos.SelectedCells[0].RowIndex;
                frmGestionarMedicos frmGestionarMedicos = new frmGestionarMedicos();
                frmGestionarMedicos.Actualiza = true;
                frmGestionarMedicos.Medico = Convert.ToInt32(dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());
                frmGestionarMedicos.ShowDialog();
                CargarGrid();
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMedicos.Columns["btnCitas"].Index && e.RowIndex >= 0)
            {
                int fila = dgvMedicos.SelectedCells[0].RowIndex;
                frmCitasGrid frmCitasGrid = new frmCitasGrid();
                frmCitasGrid.Medico = Convert.ToInt32(dgvMedicos.Rows[fila].Cells["ID"].Value.ToString());
                frmCitasGrid.ShowDialog();
            }
        }
        private void CargarGrid()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM MEDICOS");
                dgvMedicos.DataSource = tabla;

                foreach (DataGridViewRow fila in dgvMedicos.Rows)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)fila.Cells["btnCitas"];

                    buttonCell.Value = "Citas";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedicos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow fila in dgvMedicos.Rows)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)fila.Cells["btnCitas"];

                buttonCell.Value = "Citas";
            }
        }
    }
}
