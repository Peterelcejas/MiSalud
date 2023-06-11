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
        public int Usuario { get; internal set; }

        private bool _estaGuardando = false;

        private void frmGestionarCitas_Load(object sender, EventArgs e)
        {
            mtcFecha.MinDate = DateTime.Now;
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
            CargaMedicos();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(cboMedico.SelectedIndex != 0 && cboHora.SelectedIndex != 0))
            {
                MessageBox.Show("Tienes que rellenar todos los campos para actualizar el paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (GuadarDatos())
                {
                    _estaGuardando = true;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionarCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
                }
            }
        }

        private void cboHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHora.SelectedIndex != 0)
            {
                txtFechaCita.Text = mtcFecha.SelectionStart.ToString().Substring(0, 10) + " " + cboHora.Text + "H";
            }
        }

        private void CargaMedicos()
        {
            try
            {
                DataTable medicos = VarGlobal.EjecutaConsulta("SELECT ID, NOMBRE FROM MEDICOS WHERE ID != " + this.Medico);
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
                DataTable horas = VarGlobal.EjecutaConsulta("WITH horas AS (SELECT generate_series(8, 20) AS hora) SELECT hora FROM horas WHERE hora NOT IN (SELECT HORA FROM citas WHERE ID_MEDICO = (SELECT ID FROM MEDICOS WHERE NOMBRE = '" + cboMedico.Text + "') AND FECHA = '" + mtcFecha.SelectionStart.ToString() + "');");
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

        private bool GuadarDatos()
        {
            try
            {
                VarGlobal.EjecutaSentencia("UPDATE CITAS SET id_medico = (SELECT ID FROM MEDICOS WHERE NOMBRE = '" + cboMedico.Text + "'), fecha = '" + mtcFecha.SelectionStart.ToString() +
                    "', hora = " + Convert.ToInt32(cboHora.Text) + " WHERE id = " + this.Cita);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ConfirmarBorradoDatos()
        {
            DialogResult result = MessageBox.Show("Se borrará los datos introducidos. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private bool CamposLlenos()
        {
            return (cboHora.Text.Length > 0 || cboMedico.Text.Length > 0 || mtcFecha.SelectionStart.ToString().Length > 0);
        }
    }
}
