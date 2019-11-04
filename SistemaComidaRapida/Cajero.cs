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
    public partial class frmCajero : Form
    {
        
        TransacMenu objMenu = new TransacMenu();
        String res = "";   
        public frmCajero()
        {
            InitializeComponent();
        }

        //Llenar Formulario
        public void llenar() {
            dgvMenu.DataSource = objMenu.mostrar_menu();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor     
            Int32 ancho = (this.Width - panelTime.Width) / 2;
            panelTime.Location = new Point(ancho, panelTime.Location.Y);
            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelHora.Text = DateTime.Now.ToShortTimeString();

            llenar();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿Está seguro que quiere cerrar Sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        private void btnCerrarT_Click(object sender, EventArgs e) //Cerrar la ventana Para que funcione el deslogeo
        {
            if(MessageBox.Show("¿En realidad desea Cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkCombos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBebidas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkPlatos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvMenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvMenu.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvMenu.CurrentRow.Cells[3].Value.ToString();
            txtDesc.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {   
            

            
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDesc.Clear();
            txtCantidad.Value=1;


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvMenu.DataSource = objMenu.buscar_menu(txtBuscar.Text);
        }

        private void btnEnviarCocina_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente selecClie = new frmSeleccionarCliente();
            selecClie.ShowDialog();
        }
    }
}
