using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MiSalud
{
    public partial class frmGestionarMedicos : Form
    {
        public bool Actualiza { get; internal set; }
        public int Medico { get; internal set; }

        private bool _estaGuardando = false;

        public frmGestionarMedicos()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.medico_32;
            btnVer.Image = Properties.Resources.ojo_32;

        }

        private void frmGestionarMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                btnAceptar.FlatAppearance.BorderSize = 2;
                btnVer.FlatAppearance.BorderColor = btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
                btnVer.FlatAppearance.BorderSize = btnCancelar.FlatAppearance.BorderSize = 0;
                if (this.Actualiza)
                {
                    DataTable tablaUpdate = VarGlobal.EjecutaConsulta("SELECT * FROM MEDICOS WHERE MEDICOS.ID = " + this.Medico);
                    if (tablaUpdate.Rows.Count > 0)
                    {
                        txtEmail.Text = tablaUpdate.Rows[0]["EMAIL"].ToString();
                        txtTelefono.Text = tablaUpdate.Rows[0]["TELEFONO"].ToString();
                        txtCiudad.Text = tablaUpdate.Rows[0]["CIUDAD"].ToString();
                        txtCentro.Text = tablaUpdate.Rows[0]["CENTRO"].ToString();
                        txtEspecialidad.Text = tablaUpdate.Rows[0]["ESPECIALIDAD"].ToString();
                        txtNombre.Text = tablaUpdate.Rows[0]["NOMBRE"].ToString();
                        txtApellidos.Text = tablaUpdate.Rows[0]["APELLIDOS"].ToString();
                    }

                    lblNombreUsu.Visible = lblContrasegna.Visible = txtContrasegna.Visible = txtUsuario.Visible = btnVer.Visible = false;
                    lblEmail.Location = lblCiudad.Location;
                    txtEmail.Location = txtCiudad.Location;
                    lblTelefono.Location = lblCentro.Location;
                    txtTelefono.Location = txtCentro.Location;
                    lblCiudad.Location = lblEspecialidad.Location;
                    txtCiudad.Location = txtEspecialidad.Location;
                    lblCentro.Location = lblApellidos.Location;
                    txtCentro.Location = txtApellidos.Location;
                    lblEspecialidad.Location = lblNombre.Location;
                    txtEspecialidad.Location = txtNombre.Location;
                    lblNombre.Location = lblNombreUsu.Location;
                    txtNombre.Location = txtUsuario.Location;
                    lblApellidos.Location = lblContrasegna.Location;
                    txtApellidos.Location = txtContrasegna.Location;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                txtCentro.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtEmail.Text.Length > 0) && !this.Actualiza)
            {
                MessageBox.Show("Tienes que rellenar todos los campos para introducir un médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtCiudad.Text.Length > 0 &&
                txtCentro.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtEmail.Text.Length > 0))
            {
                MessageBox.Show("Tienes que rellenar todos los campos para actualizar el médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmGestionarMedicos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
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
                DialogResult result = MessageBox.Show("No se va a actualizar el medico. ¿Quieres continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            return (txtUsuario.Text.Length > 0 || txtContrasegna.Text.Length > 0 || txtNombre.Text.Length > 0 || txtApellidos.Text.Length > 0 || txtCiudad.Text.Length > 0 ||
                txtCentro.Text.Length > 0 || txtTelefono.Text.Length > 0 || txtEmail.Text.Length > 0);
        }
        private bool GuadarDatos()
        {
            try
            {
                if (this.Actualiza)
                {
                    VarGlobal.EjecutaSentencia("UPDATE Medicos SET nombre = '" + txtNombre.Text + "', apellidos = '" + txtApellidos.Text + "', especialidad = '" + txtEspecialidad.Text + "', " +
                        "centro = '" + txtCentro.Text + "', ciudad = '" + txtCiudad.Text + "', telefono = '" + txtTelefono.Text + "', email = '" + txtEmail.Text + "' WHERE id = " + this.Medico);
                }
                else
                {
                    DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM USUARIOS WHERE NOMBRE_CUENTA = '" + txtUsuario.Text.Replace(" ", "") + "'");
                    if (tabla.Rows.Count > 0)
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre de cuenta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                    {
                        VarGlobal.EjecutaSentencia("INSERT INTO Usuarios (nombre_cuenta, contrasena, tipo) VALUES ('" + txtUsuario.Text.Replace(" ", "") + "', '" + txtContrasegna.Text.Replace(" ", "") + "', 1)");
                        VarGlobal.EjecutaSentencia("INSERT INTO MEDICOS (nombre, apellidos, especialidad, centro, ciudad, telefono, email, id_usuario) " +
                                                      "VALUES ('" + txtNombre.Text + "', '" + txtApellidos.Text + "', '" + txtEspecialidad.Text + "', '" + txtCentro.Text + "', '" + txtCiudad.Text + "', " +
                                                      txtTelefono.Text + ", '" + txtEmail.Text + "', (SELECT MAX(id) FROM Usuarios))");
                    }
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
