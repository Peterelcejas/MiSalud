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
    public partial class frmMedicamentosGrid : Form
    {
        public frmMedicamentosGrid()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.medicamentos_32;
        }

        private void frmMedicamentosGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            frmGestionarMedicamentos frmGestionarMedicamentos = new frmGestionarMedicamentos();
            frmGestionarMedicamentos.Actualiza = false;
            frmGestionarMedicamentos.ShowDialog();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedCells.Count > 0)
            {
                int fila = dgvMedicamentos.SelectedCells[0].RowIndex;
                frmGestionarMedicamentos frmGestionarMedicamentos = new frmGestionarMedicamentos();
                frmGestionarMedicamentos.Actualiza = true;
                frmGestionarMedicamentos.Medicamento = Convert.ToInt32(dgvMedicamentos.Rows[fila].Cells["ID"].Value.ToString());
                frmGestionarMedicamentos.ShowDialog();
                CargarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se va a eliminar el medicamento ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int fila = dgvMedicamentos.SelectedCells[0].RowIndex;
                    VarGlobal.EjecutaSentencia("DELETE FROM MEDICAMENTOS WHERE ID = " + dgvMedicamentos.Rows[fila].Cells["ID"].Value.ToString());
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrid()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM MEDICAMENTOS");
                dgvMedicamentos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
