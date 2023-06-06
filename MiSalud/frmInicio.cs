using System.Data;

namespace MiSalud
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblkRegistrar.LinkBehavior = LinkBehavior.NeverUnderline;
            this.Icon = Properties.Resources.H_T_Misalud_logo;
        }

        private void lblkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrar frmRegistrar = new frmRegistrar();
            frmRegistrar.ShowDialog();
        }

        private void btnConsectarse_Click(object sender, EventArgs e)
        {
            DataTable tabla = VarGlobal.EjecutaConsulta("SELECT id FROM Usuarios WHERE nombre_cuenta = '" + txtUsuario.Text + "' AND contrasena = '" + txtContrasegna.Text + "'");
            if (tabla.Rows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Nombre de cuenta o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}