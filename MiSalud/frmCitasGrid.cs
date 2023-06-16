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
        public int Usuario { get; internal set; }
        public int Paciente { get; internal set; }

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
                    if (dgvCitas.SelectedCells.Count > 0)
                    {
                        int fila = dgvCitas.SelectedCells[0].RowIndex;
                        VarGlobal.EjecutaSentencia("DELETE FROM CITAS WHERE ID = " + dgvCitas.Rows[fila].Cells["ID"].Value.ToString());
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
            if (dgvCitas.SelectedCells.Count > 0)
            {
                int fila = dgvCitas.SelectedCells[0].RowIndex;
                frmGestionarCitas frmGestionarCitas = new frmGestionarCitas();
                frmGestionarCitas.Cita = Convert.ToInt32(dgvCitas.Rows[fila].Cells["ID"].Value.ToString());
                frmGestionarCitas.Medico = this.Medico;
                frmGestionarCitas.Usuario = this.Usuario;
                frmGestionarCitas.Actualiza = true;
                frmGestionarCitas.ShowDialog();
                CargarGrid();
            }
        }

        private void CitasGrid_Load(object sender, EventArgs e)
        {
            CargarGrid();
            if (this.Usuario == 1) { btnModificar.Text = "Consultar"; }
            if (this.Usuario != 2)
            {
                btnAnyadir.Visible = false;
                btnEliminar.Location = btnModificar.Location;
                btnModificar.Location = btnAnyadir.Location;
            }
        }

        private void CargarGrid()
        {
            try
            {
                if (this.Usuario == 0)
                {
                    DataTable tabla = VarGlobal.EjecutaConsulta("SELECT C.ID, C.ID_MEDICO AS IDM, CONCAT(C.FECHA || ' ' || C.HORA || 'H') AS FECHA, M.NOMBRE AS MEDICO, P.NOMBRE AS PACIENTE, C.MOTIVO_CONSULTA FROM citas AS C " +
                        "LEFT JOIN MEDICOS AS M ON C.ID_MEDICO = M.ID LEFT JOIN PACIENTES AS P ON C.ID_PACIENTE = P.ID WHERE C.ID_MEDICO = " + this.Medico + " AND C.FECHA > current_date");
                    dgvCitas.DataSource = tabla;
                }
                if (this.Usuario == 1)
                {
                    DataTable tabla = VarGlobal.EjecutaConsulta("SELECT C.ID, C.ID_MEDICO AS IDM, CONCAT(C.FECHA || ' ' || C.HORA || 'H') AS FECHA, M.NOMBRE AS MEDICO, P.NOMBRE AS PACIENTE, C.MOTIVO_CONSULTA FROM citas AS C " +
                        "LEFT JOIN MEDICOS AS M ON C.ID_MEDICO = M.ID LEFT JOIN PACIENTES AS P ON C.ID_PACIENTE = P.ID WHERE C.ID_MEDICO = " + this.Medico);
                    dgvCitas.DataSource = tabla;
                }
                if (this.Usuario == 2)
                {
                    DataTable tabla = VarGlobal.EjecutaConsulta("SELECT C.ID, C.ID_MEDICO AS IDM, CONCAT(C.FECHA || ' ' || C.HORA || 'H') AS FECHA, M.NOMBRE AS MEDICO, P.NOMBRE AS PACIENTE, C.MOTIVO_CONSULTA FROM citas AS C " +
                        "LEFT JOIN MEDICOS AS M ON C.ID_MEDICO = M.ID LEFT JOIN PACIENTES AS P ON C.ID_PACIENTE = P.ID WHERE C.ID_PACIENTE = " + this.Paciente);
                    dgvCitas.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            frmGestionarCitas frmGestionarCitas = new frmGestionarCitas();
            frmGestionarCitas.Paciente = this.Paciente;
            frmGestionarCitas.Usuario = this.Usuario;
            frmGestionarCitas.Actualiza = false;
            frmGestionarCitas.ShowDialog();
            CargarGrid();
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (this.Usuario == 2)
            {
                if (dgvCitas.SelectedCells.Count > 0)
                {
                    DateTime fecha = Convert.ToDateTime(dgvCitas.SelectedRows[0].Cells["FECHA"].Value);
                    if (fecha < DateTime.Now)
                    {
                        btnModificar.Enabled = false;
                    }
                }

            }*/
        }
    }
}
