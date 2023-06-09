using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSalud
{
    public partial class fmrGestionarHistoriales : Form
    {
        public fmrGestionarHistoriales()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.historial_32;
        }

        public bool Actualiza { get; internal set; }
        public int Historial { get; internal set; }
        public int Paciente { get; internal set; }

        private bool _estaGuardando = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(cboMedicamento.SelectedIndex != 0 && dtpFechaIni.Text.Length > 0 && dtpFechaFin.Text.Length > 0) && !this.Actualiza)
            {
                MessageBox.Show("Tienes que rellenar todos los campos para introducir el paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(dtpFechaFin.Text.Length > 0))
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

        private void fmrGestionarHistoriales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
                }
            }
        }

        private void fmrGestionarHistoriales_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM HISTORIAL_MEDICAMENTOS WHERE ID = " + this.Historial);

                btnAceptar.FlatAppearance.BorderSize = 2;
                btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
                dtpFechaFin.MinDate = DateTime.Now.AddMonths(1);
                if (this.Actualiza)
                {
                    if (tabla.Rows.Count > 0)
                    {
                        dtpFechaFin.Text = tabla.Rows[0]["FECHA_FIN"].ToString();
                    }
                    cboMedicamento.Visible = dtpFechaIni.Visible = lblFechaIni.Visible = lblNombreM.Visible = false;
                    dtpFechaFin.Location = cboMedicamento.Location;
                    lblFechaFin.Location = lblNombreM.Location;
                    this.Size = new Size(883, 200);
                }
                else
                {
                    tabla = VarGlobal.EjecutaConsulta("SELECT * FROM MEDICAMENTOS");
                    DataRow filaVacia = tabla.NewRow();
                    tabla.Rows.InsertAt(filaVacia, 0);

                    cboMedicamento.DataSource = tabla;
                    cboMedicamento.DisplayMember = "Nombre";
                    cboMedicamento.ValueMember = "ID";

                    dtpFechaIni.Value = DateTime.Now;
                    dtpFechaIni.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ConfirmarBorradoDatos()
        {
            if (this.Actualiza)
            {
                DialogResult result = MessageBox.Show("No se va a actualizar el Paciente. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return result == DialogResult.Yes;
            }
            else
            {
                DialogResult result = MessageBox.Show("Se borrará los datos introducidos. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return result == DialogResult.Yes;
            }

        }

        private bool CamposLlenos()
        {
            return (cboMedicamento.Text.Length > 0 || dtpFechaIni.Text.Length > 0 || dtpFechaFin.Text.Length > 0);
        }
        private bool GuadarDatos()
        {
            try
            {
                if (this.Actualiza)
                {
                    VarGlobal.EjecutaSentencia("UPDATE HISTORIAL_MEDICAMENTOS SET fecha_fin = '" + dtpFechaFin.Text.Substring(0, 10) + "' WHERE id = " + this.Historial);
                }
                else
                {
                    VarGlobal.EjecutaSentencia("INSERT INTO HISTORIAL_MEDICAMENTOS (id_paciente, id_medicamento, fecha_inicio, fecha_fin) " +
                                                  "VALUES (" + this.Paciente + ", '" + cboMedicamento.SelectedIndex + "', '" + dtpFechaIni.Text.Substring(0, 10) + "', '" + dtpFechaFin.Text.Substring(0, 10) + "')");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
