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
    public partial class frmGestionarPacientes : Form
    {
        public frmGestionarPacientes()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.paciente_32;
            btnVer.Image = Properties.Resources.ojo_32;
            dtpNacimiento.Value = dtpNacimiento.MaxDate = DateTime.Now;
        }

        public bool Actualiza { get; internal set; }
        public int Paciente { get; internal set; }

        private bool _estaGuardando = false;

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtContrasegna.UseSystemPasswordChar)
            {
                txtContrasegna.UseSystemPasswordChar = false;
                btnVer.FlatAppearance.BorderSize = 1;
            }
            else
            {
                txtContrasegna.UseSystemPasswordChar = true;
                btnVer.FlatAppearance.BorderSize = 0;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text.Length > 0 && txtContrasegna.Text.Length > 0 && txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtCiudad.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtEmail.Text.Length > 0) && !this.Actualiza)
            {
                MessageBox.Show("Tienes que rellenar todos los campos para introducir el paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtCiudad.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtEmail.Text.Length > 0))
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

        private void frmGestionarPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmGestionarPacientes_Load(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnVer.FlatAppearance.BorderColor = btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnVer.FlatAppearance.BorderSize = btnCancelar.FlatAppearance.BorderSize = 0;
            if (this.Actualiza)
            {
                try
                {
                    DataTable tablaUpdate = VarGlobal.EjecutaConsulta("SELECT * FROM PACIENTES WHERE PACIENTES.ID = " + this.Paciente);
                    if (tablaUpdate.Rows.Count > 0)
                    {
                        txtEmail.Text = tablaUpdate.Rows[0]["EMAIL"].ToString();
                        txtTelefono.Text = tablaUpdate.Rows[0]["TELEFONO"].ToString();
                        txtCiudad.Text = tablaUpdate.Rows[0]["CIUDAD"].ToString();
                        txtDireccion.Text = tablaUpdate.Rows[0]["DIRECCION"].ToString();
                        dtpNacimiento.Text = tablaUpdate.Rows[0]["FECHA_NACIMIENTO"].ToString();
                        txtNombre.Text = tablaUpdate.Rows[0]["NOMBRE"].ToString();
                        txtApellidos.Text = tablaUpdate.Rows[0]["APELLIDOS"].ToString();
                    }

                    lblNombreUsu.Visible = lblContrasegna.Visible = txtContrasegna.Visible = txtUsuario.Visible = btnVer.Visible = false;
                    lblEmail.Location = lblCiudad.Location;
                    txtEmail.Location = txtCiudad.Location;
                    lblTelefono.Location = lblDireccion.Location;
                    txtTelefono.Location = txtDireccion.Location;
                    lblCiudad.Location = lblFechaNac.Location;
                    txtCiudad.Location = dtpNacimiento.Location;
                    lblDireccion.Location = lblApellidos.Location;
                    txtDireccion.Location = txtApellidos.Location;
                    lblFechaNac.Location = lblNombre.Location;
                    dtpNacimiento.Location = txtNombre.Location;
                    lblNombre.Location = lblNombreUsu.Location;
                    txtNombre.Location = txtUsuario.Location;
                    lblApellidos.Location = lblContrasegna.Location;
                    txtApellidos.Location = txtContrasegna.Location;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            return (txtUsuario.Text.Length > 0 || txtContrasegna.Text.Length > 0 || txtNombre.Text.Length > 0 || txtApellidos.Text.Length > 0 || txtCiudad.Text.Length > 0 ||
                txtDireccion.Text.Length > 0 || txtTelefono.Text.Length > 0 || txtEmail.Text.Length > 0);
        }
        private bool GuadarDatos()
        {
            try
            {
                if (this.Actualiza)
                {
                    VarGlobal.EjecutaSentencia("UPDATE PACIENTES SET nombre = '" + txtNombre.Text + "', apellidos = '" + txtApellidos.Text + "', fecha_nacimiento = '" + dtpNacimiento.Text.Substring(0, 10) + "', " +
                    "direccion = '" + txtDireccion.Text + "', ciudad = '" + txtCiudad.Text + "', telefono = '" + txtTelefono.Text + "', email = '" + txtEmail.Text +
                    "' WHERE id = " + this.Paciente);
                }
                else
                {
                    VarGlobal.EjecutaSentencia("INSERT INTO Usuarios (nombre_cuenta, contrasena, tipo) VALUES ('" + txtUsuario.Text.Replace(" ", "") + "', '" + txtContrasegna.Text.Replace(" ", "") + "', 1)");
                    VarGlobal.EjecutaSentencia("INSERT INTO PACIENTES (nombre, apellidos, fecha_nacimiento, direccion, ciudad, telefono, email, certificado_vacunacion, id_usuario) " +
                                                  "VALUES ('" + txtNombre.Text + "', '" + txtApellidos.Text + "', '" + dtpNacimiento.Text.Substring(0, 10) + "', '" + txtDireccion.Text + "', '" + txtCiudad.Text + "', " +
                                                  txtTelefono.Text + ", '" + txtEmail.Text + "', (SELECT MAX(id) FROM Usuarios))");
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
