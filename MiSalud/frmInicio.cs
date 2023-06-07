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
            DataTable tabla = VarGlobal.EjecutaConsulta("SELECT * FROM Usuarios WHERE nombre_cuenta = '" + txtUsuario.Text + "' AND contrasena = '" + txtContrasegna.Text + "'");
            if (tabla.Rows.Count > 0)
            {
                switch (tabla.Rows[0]["tipo"])
                {
                    case 0:
                        frmMainAdministrador frmMainAdministrador = new frmMainAdministrador();
                        frmMainAdministrador.Show();
                        this.Hide();
                        break;
                    case 1:
                        this.Hide();
                        break;
                    case 2:
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nombre de cuenta o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}