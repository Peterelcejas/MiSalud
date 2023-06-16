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
    public partial class frmCertificadosGrid : Form
    {
        public frmCertificadosGrid()
        {
            InitializeComponent();
        }

        public int Paciente { get; internal set; }
        public int Usuario { get; internal set; }
    }
}
