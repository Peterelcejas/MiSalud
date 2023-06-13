using System.Data;

namespace MiSalud
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.H_T_Misalud_logo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblkRegistrar.LinkBehavior = LinkBehavior.NeverUnderline;

        }

        private void lblkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.ShowDialog();
        }

        private void btnConsectarse_Click(object sender, EventArgs e)
        {
            DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM Usuarios WHERE nombre_cuenta = '" + txtUsuario.Text.Trim() + "' AND contrasena = '" + txtContrasegna.Text.Trim() + "'");
            if (tabla.Rows.Count > 0)
            {
                switch (tabla.Rows[0]["tipo"])
                {
                    case 0:
                        frmMainAdministrador frmMainAdministrador = new frmMainAdministrador();
                        frmMainAdministrador.Usuario = Convert.ToInt32(tabla.Rows[0]["TIPO"]);
                        frmMainAdministrador.Show();
                        this.Hide();
                        break;
                    case 1:
                        frmMainMedico frmMainMedico = new frmMainMedico();
                        frmMainMedico.Usuario = Convert.ToInt32(tabla.Rows[0]["TIPO"]);
                        frmMainMedico.IdUsuario = Convert.ToInt32(tabla.Rows[0]["ID"]);
                        frmMainMedico.Show();
                        this.Hide();
                        break;
                    case 2:
                        frmMainPacientes frmMainPacientes = new frmMainPacientes();
                        frmMainPacientes.Usuario = Convert.ToInt32(tabla.Rows[0]["TIPO"]);
                        frmMainPacientes.IdUsuario = Convert.ToInt32(tabla.Rows[0]["ID"]);
                        frmMainPacientes.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nombre de cuenta o contrase�a incorrectos", "Error de inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}