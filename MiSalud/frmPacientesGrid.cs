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
    public partial class frmPacientesGrid : Form
    {
        public int Usuario { get; internal set; }

        public frmPacientesGrid()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.paciente_32;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se va a eliminar el paciente ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvPacientes.SelectedCells.Count > 0)
                    {
                        int fila = dgvPacientes.SelectedCells[0].RowIndex;
                        DataTable tablaCitas = VarGlobal.EjecutaConsulta("SELECT * FROM CITAS LEFT JOIN PACIENTES ON CITAS.ID_PACIENTE = PACIENTES.ID WHERE PACIENTES.ID = " + dgvPacientes.Rows[fila].Cells["ID"].Value.ToString());

                        if (tablaCitas.Rows.Count > 0)
                        {
                            MessageBox.Show("No se puede eliminar tiene citas asociadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            VarGlobal.EjecutaSentencia("DELETE FROM PACIENTES WHERE ID = " + dgvPacientes.Rows[fila].Cells["ID"].Value.ToString());
                            CargarGrid();
                        }
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
            if (dgvPacientes.SelectedCells.Count > 0)
            {
                int fila = dgvPacientes.SelectedCells[0].RowIndex;
                frmGestionarPacientes frmGestionarPacientes = new frmGestionarPacientes();
                frmGestionarPacientes.Actualiza = true;
                frmGestionarPacientes.Paciente = Convert.ToInt32(dgvPacientes.Rows[fila].Cells["ID"].Value.ToString());
                frmGestionarPacientes.ShowDialog();
                CargarGrid();
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            frmGestionarPacientes frmGestionarPacientes = new frmGestionarPacientes();
            frmGestionarPacientes.Actualiza = false;
            frmGestionarPacientes.ShowDialog();
            CargarGrid();
        }

        private void frmPacientesGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPacientes.Columns["btnHistorial"].Index && e.RowIndex >= 0)
            {
                int fila = dgvPacientes.SelectedCells[0].RowIndex;
                frmGridHistoriales frmGridHistoriales = new frmGridHistoriales();
                frmGridHistoriales.Paciente = Convert.ToInt32(dgvPacientes.Rows[fila].Cells["ID"].Value.ToString());
                frmGridHistoriales.ShowDialog();
            }
        }
        private void CargarGrid()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM PACIENTES");
                dgvPacientes.DataSource = tabla;

                foreach (DataGridViewRow fila in dgvPacientes.Rows)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)fila.Cells["btnHistorial"];

                    buttonCell.Value = "Historial";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
