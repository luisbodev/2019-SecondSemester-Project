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
        public string id_cliente, nombre_cliente, userEmp, idEmp, noOrden;
        DateTime fecha;
        

        
        TransacMenu objMenu = new TransacMenu();
        TransacOrden objOrden = new TransacOrden();
        TransacDetalleOrden objDtaOrde = new TransacDetalleOrden();

        
        String res = "";   
        public frmCajero()
        {
            InitializeComponent();
        }

        //Llenar Formulario
        public void llenarMenu() {
            dgvMenu.DataSource = objMenu.mostrar_menuOrden();
        }
        //Mostrar Orden Actual
        public void llenarOrden() {
            dgvDetalleOrden.DataSource = objDtaOrde.mostrar_detOrdenEspe(txtNoOrden.Text);
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor     
            Int32 ancho = (this.Width - panelTime.Width) / 2;
            panelTime.Location = new Point(ancho, panelTime.Location.Y);
            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelHora.Text = DateTime.Now.ToShortTimeString();

            llenarMenu();

            
            labelUsuario.Text ="Usuario: " + this.userEmp;
            idEmp = objOrden.mostrar_IdEmpleado(this.userEmp);
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


        private void dgvMenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgvMenu.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvMenu.CurrentRow.Cells[3].Value.ToString();
            txtDesc.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();
            if(!(txtId.Text=="" || txtNoOrden.Text=="")) {
                btnAgregar.Enabled = true;
            }
            else {
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            double total;
            total = double.Parse(txtPrecio.Text) * double.Parse(txtCantidad.Text);
            res = objDtaOrde.agregar_platoDetalle(txtNoOrden.Text, txtId.Text, txtExtra.Text, txtCantidad.Text, txtPrecio.Text, total.ToString());
            btnAgregar.Enabled = false;
            llenarOrden();
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
            DatosCliente selecClie = new DatosCliente();
            selecClie.btnSelecClie.Visible = true;
            selecClie.btnModificar.Visible = false;
            selecClie.btnEliminar.Visible = false;
            selecClie.ShowDialog();
            txtIdCliente.Text = selecClie.idCliente;
            txtNombreCliente.Text = selecClie.nombre;

            fecha = DateTime.Today;
            double total = 0;
            res = objOrden.agrega_orden(idEmp, fecha.ToString(), txtIdCliente.Text, total.ToString());
            if (res == "1")
            {
                MessageBox.Show("Orden Creada Exitosamente");
                noOrden = objOrden.mostrar_ultOrden();
                txtNoOrden.Text = noOrden;
            }
            else
            {
                MessageBox.Show("Fallo en crear orden " + res);
            }
        }
    }
}
