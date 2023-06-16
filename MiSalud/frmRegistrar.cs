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
    public partial class frmRegistrar : Form
    {
        private bool _estaGuardando = false;
        public frmRegistrar()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.H_T_Misalud_logo;
            btnVer.Image = Properties.Resources.ojo_32;
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnVer.FlatAppearance.BorderColor = btnAceptar.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnVer.FlatAppearance.BorderSize = btnCancelar.FlatAppearance.BorderSize = 0;
            dtpNacimiento.Value = dtpNacimiento.MaxDate = DateTime.Now;

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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaGuardando)
            {
                if (CamposLlenos() && !ConfirmarBorradoDatos())
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text.Length > 0 && txtContrasegna.Text.Length > 0 && txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtCiudad.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtEmail.Text.Length > 0))
            {
                MessageBox.Show("Tienes que rellenar todos los campos para crear la cuenta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool GuadarDatos()
        {
            try
            {
                DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM USUARIOS WHERE NOMBRE_CUENTA = '" + txtUsuario.Text.Replace(" ", "") + "'");
                if (tabla.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe un usuario con esa cuenta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
                else
                {

                    VarGlobal.EjecutaSentencia("INSERT INTO Usuarios (nombre_cuenta, contrasena, tipo) VALUES ('" + txtUsuario.Text.Replace(" ", "") + "', '" + txtContrasegna.Text.Replace(" ", "") + "', 2)");
                    VarGlobal.EjecutaSentencia("INSERT INTO Pacientes (nombre, apellidos, fecha_nacimiento, direccion, ciudad, telefono, email, certificado_vacunacion, id_usuario) " +
                                                  "VALUES ('" + txtNombre.Text + "', '" + txtApellidos.Text + "', '" + dtpNacimiento.Text.Substring(0, 10) + "', '" + txtDireccion.Text + "', '" +
                                                  txtCiudad.Text + "', " + txtTelefono.Text + ", '" + txtEmail.Text + "', " + false + ", (SELECT MAX(id) FROM Usuarios))");
                    return true;
                }
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
            return (txtUsuario.Text.Length > 0 || txtContrasegna.Text.Length > 0 || txtNombre.Text.Length > 0 || txtApellidos.Text.Length > 0 || txtCiudad.Text.Length > 0 ||
                txtDireccion.Text.Length > 0 || txtTelefono.Text.Length > 0 || txtEmail.Text.Length > 0);
        }

    }
}
