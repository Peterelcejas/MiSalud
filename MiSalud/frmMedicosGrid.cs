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
            this.Icon = Properties.Resources.H_T_Misalud_logo;
        }

        private void frmMedicosGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            DataTable tabla = VarGlobal.EjecutaConsulta("SELECT ID, NOMBRE, APELLIDOS, ESPECIALIDAD, CENTRO, CIUDAD, TELEFONO, EMAIL FROM Medicos");
            dgvMedicos.DataSource = tabla;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se borrará los datos introducidos. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvMedicos.SelectedCells.Count > 0)
                {
                    int rowIndex = dgvMedicos.SelectedCells[0].RowIndex; 

                    VarGlobal.EjecutaSentencia("DELETE FROM MEDICOS WHERE ID=" + dgvMedicos.Rows[rowIndex].Cells["ID"].Value.ToString());
                    CargarGrid();
                }
            }
            else
            {
            }
        }
    }
}
