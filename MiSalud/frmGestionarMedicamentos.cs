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
    public partial class frmGestionarMedicamentos : Form
    {
        public frmGestionarMedicamentos()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.medicamentos_32;
        }

        public bool Actualiza { get; internal set; }
        public int Medicamento { get; internal set; }

        private bool _estaGuardando = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text.Length > 0 && txtDescripcion.Text.Length > 0) && !this.Actualiza)
            {
                MessageBox.Show("Tienes que rellenar todos los campos para introducir un medicamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(txtNombre.Text.Length > 0 && txtDescripcion.Text.Length > 0))
            {
                MessageBox.Show("Tienes que rellenar todos los campos para actualizar el medicamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmGestionarMedicamentos_Load(object sender, EventArgs e)
        {
            try
            {
                btnAceptar.FlatAppearance.BorderSize = 2;
                btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
                if (this.Actualiza)
                {
                    DataTable tablaUpdate = VarGlobal.EjecutaConsulta("SELECT * FROM MEDICAMENTOS WHERE MEDICAMENTOS.ID = " + this.Medicamento);
                    if (tablaUpdate.Rows.Count > 0)
                    {
                        txtNombre.Text = tablaUpdate.Rows[0]["NOMBRE"].ToString();
                        txtDescripcion.Text = tablaUpdate.Rows[0]["DESCRIPCION"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGestionarMedicamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
                }
            }
        }
        private bool ConfirmarBorradoDatos()
        {
            if (this.Actualiza)
            {
                DialogResult result = MessageBox.Show("No se va a actualizar el medicamento. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return result == DialogResult.Yes;
            }
            else
            {
                DialogResult result = MessageBox.Show("Se borrarán los datos introducidos. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return result == DialogResult.Yes;
            }

        }

        private bool CamposLlenos()
        {
            return (txtNombre.Text.Length > 0 || txtDescripcion.Text.Length > 0);
        }
        private bool GuadarDatos()
        {
            try
            {
                if (this.Actualiza)
                {
                    VarGlobal.EjecutaSentencia("UPDATE MEDICAMENTOS SET nombre = '" + txtNombre.Text + "', descripcion = '" + txtDescripcion.Text + "' WHERE id = " + this.Medicamento);
                }
                else
                {
                    VarGlobal.EjecutaSentencia("INSERT INTO MEDICAMENTOS (nombre, descripcion) VALUES ('" + txtNombre.Text + "', '" + txtDescripcion.Text + "')");
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
