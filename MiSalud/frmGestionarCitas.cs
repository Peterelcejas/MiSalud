using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiSalud
{
    public partial class frmGestionarCitas : Form
    {
        public frmGestionarCitas()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.citas_32;
        }

        public int Cita { get; internal set; }
        public int Medico { get; internal set; }

        private bool _estaGuardando = false;

        private void frmGestionarCitas_Load(object sender, EventArgs e)
        {
            mtcFecha.MinDate = DateTime.Now;
            CargaMedicos();
        }

        private void CargaMedicos()
        {
            try
            {
                DataTable medicos = VarGlobal.EjecutaConsulta("SELECT M.ID, M.NOMBRE FROM CITAS AS C LEFT JOIN MEDICOS AS M ON C.ID_MEDICO = M.ID WHERE M.ID != " + this.Medico );
                DataRow filaVacia = medicos.NewRow();
                medicos.Rows.InsertAt(filaVacia, 0);

                cboMedico.DataSource = medicos;
                cboMedico.DisplayMember = "NOMBRE";
                cboMedico.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaFechas()
        {
            try
            {
                DataTable citasTabla = VarGlobal.EjecutaConsulta("SELECT FECHA FROM citas WHERE ID_MEDICO = " + this.Medico);

                List<DateTime> fechasOcupadas = new List<DateTime>();
                foreach (DataRow row in citasTabla.Rows)
                {
                    DateTime fechaOcupada = Convert.ToDateTime(row["FECHA"]);
                    fechasOcupadas.Add(fechaOcupada);
                }

                mtcFecha.BoldedDates = fechasOcupadas.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaHoras()
        {
            try
            {
                DataTable horas = VarGlobal.EjecutaConsulta("WITH horas AS (SELECT generate_series(8, 20) AS hora) SELECT hora FROM horas WHERE hora NOT IN (SELECT HORA FROM citas WHERE ID_MEDICO = " + this.Medico + " AND FECHA = '" + mtcFecha.SelectionStart.ToString() + "');");
                DataRow filaVacia = horas.NewRow();
                horas.Rows.InsertAt(filaVacia, 0);

                cboHora.DataSource = horas;
                cboHora.DisplayMember = "HORA";
                cboHora.ValueMember = "HORA";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedico.Text.Length > 0)
            {
                mtcFecha.Enabled = true; CargaFechas();
            }
            else
            {
                mtcFecha.Enabled = false;
            }
        }

        private void mtcFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mtcFecha.SelectionStart.ToString().Length > 0)
            {
                cboHora.Enabled = true; 
                CargaHoras();
            }
            else
            {
                cboHora.Enabled = false;
            }
        }
    }
}
