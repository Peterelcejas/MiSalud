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
    public partial class frmGridHistoriales : Form
    {
        public frmGridHistoriales()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.historial_32;
        }

        public int Paciente { get; internal set; }
        public int Usuario { get; internal set; }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vas a borrar el medicamento de este paciente ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvHistorial.SelectedCells.Count > 0)
                {
                    int fila = dgvHistorial.SelectedCells[0].RowIndex;
                    VarGlobal.EjecutaSentencia("DELETE FROM HISTORIAL_MEDICAMENTOS WHERE ID = " + dgvHistorial.Rows[fila].Cells["ID"].Value.ToString());
                    CargarGrid();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.SelectedCells.Count > 0)
            {
                int fila = dgvHistorial.SelectedCells[0].RowIndex;
                fmrGestionarHistoriales fmrGestionarHistoriales = new fmrGestionarHistoriales();
                fmrGestionarHistoriales.Actualiza = true;
                fmrGestionarHistoriales.Historial = Convert.ToInt32(dgvHistorial.Rows[fila].Cells["ID"].Value.ToString());
                fmrGestionarHistoriales.ShowDialog();
                CargarGrid();
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            fmrGestionarHistoriales fmrGestionarHistoriales = new fmrGestionarHistoriales();
            fmrGestionarHistoriales.Actualiza = false;
            fmrGestionarHistoriales.Paciente = this.Paciente;
            fmrGestionarHistoriales.ShowDialog();
            CargarGrid();
        }

        private void frmGridHistoriales_Load(object sender, EventArgs e)
        {
            CargarGrid();
            if (this.Usuario == 1)
            {
                btnEliminar.Visible = false;
            }
            if (this.Usuario == 2)
            {
                btnEliminar.Visible = btnModificar.Visible = false;
                btnAnyadir.Text = "Consultar";
            }
        }
        private void CargarGrid()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT HM.ID, PACIENTES.ID AS IDP, PACIENTES.NOMBRE AS NOMBREP, MEDICAMENTOS.NOMBRE AS NOMBREM, HM.FECHA_INICIO AS FECHAI, HM.FECHA_FIN AS FECHAF " +
                    "FROM HISTORIAL_MEDICAMENTOS AS HM LEFT JOIN PACIENTES ON HM.ID_PACIENTE = PACIENTES.ID LEFT JOIN MEDICAMENTOS ON HM.ID_MEDICAMENTO = MEDICAMENTOS.ID " +
                    "WHERE PACIENTES.ID = " + this.Paciente);
                dgvHistorial.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
