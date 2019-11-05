using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComidaRapida
{
    public partial class ReporteUsuario : Form
    {
        frmDatosEmpleado objE = new frmDatosEmpleado();


        public ReporteUsuario()
        {
            MessageBox.Show("ES. " + objE.parametro);
            InitializeComponent();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            CrystalReportUsuario crystlUs = new CrystalReportUsuario();
            crystlUs.SetParameterValue("@IDEmpleado", objE.parametro); //<<<<<<<<<<<<<<<<<<<<<<<
            crystalReportViewer1.ReportSource = crystlUs;


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
