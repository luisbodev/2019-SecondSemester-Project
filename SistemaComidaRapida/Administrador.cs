using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace SistemaComidaRapida
{
    public partial class frmAdministrador : Form
    {
        public string userEmp;

        TransacOrden objOrden = new TransacOrden();
        
        public frmAdministrador()
        {
            InitializeComponent();
        }

        

       

        private void menuToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmDatosMenu crudmenu = new frmDatosMenu();//Mostrar Crud Menu  
            crudmenu.MdiParent = this;
            crudmenu.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar Sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEmpleado frmDE = new frmDatosEmpleado();
            frmDE.MdiParent = this;
            frmDE.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosCliente frmCli = new DatosCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosOrdenes frmOrd = new frmDatosOrdenes();
            frmOrd.MdiParent = this;
            frmOrd.Show();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = "Usuario: " + this.userEmp;
        }

        private void frmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosCategoria frmCat = new DatosCategoria();
            frmCat.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportEmpleados reporEmple = new ReportEmpleados();
            reporEmple.ShowDialog();
        }

        private void generarReporteDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿En realidad desea Cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void cocineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCocinero objCoci = new frmCocinero();
            objCoci.btnCerrarT.Visible = false;
            objCoci.btnCerrarFrm.Visible = true;
            objCoci.formulario = 1;
            objCoci.labelUsuario.Text = "Usuario: " + this.userEmp;
            objCoci.labelTipodeCuenta.Text = "Administrador";
            objCoci.btnCerrarSesion.Visible = false;
            objCoci.Show();
        }

        private void pantallaCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCajero objCaje = new frmCajero();
            objCaje.btnCerrarT.Visible = false;
            objCaje.btnCerrarFrm.Visible = true;
            objCaje.formulario = 1;
            objCaje.labelUsuario.Text = "Usuario: " + this.userEmp;
            objOrden.mostrar_IdEmpleado(this.userEmp);
            objCaje.labelTipodeCuenta.Text = "Administrador";
            objCaje.btnCerrarSesion.Visible = false;
            objCaje.Show();
        }
    }
}
