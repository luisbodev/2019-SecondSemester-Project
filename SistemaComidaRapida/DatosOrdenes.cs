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
    public partial class frmDatosOrdenes : Form
    {
        TransacOrden obje = new TransacOrden();
        TransacDetalleOrden detaOrden = new TransacDetalleOrden();
        string respuesta = "";
           
        public frmDatosOrdenes()
        {
            InitializeComponent();
        }

        void llenar() {
            dgvOrden.DataSource = obje.mostrar_Orden();
        }
        
        void llenardaosorden() {
            dgvDetalleOrden.DataSource = detaOrden.mostrar_DetalleOrdenCaje(dgvOrden.CurrentRow.Cells[0].Value.ToString());
        }
        private void frmDatosOrdenes_Load(object sender, EventArgs e)
        {
            llenar();
        }

      

        private void dgvOrden_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNoOrden.Text = dgvOrden.CurrentRow.Cells[0].Value.ToString();
            txtIdEmpleado.Text = dgvOrden.CurrentRow.Cells[1].Value.ToString();
            txtFecha.Text = dgvOrden.CurrentRow.Cells[2].Value.ToString();
            txtIdCliente.Text = dgvOrden.CurrentRow.Cells[3].Value.ToString();
            txtTotal.Text = dgvOrden.CurrentRow.Cells[4].Value.ToString();
            llenardaosorden();
            dgvCliente.DataSource = obje.mostrar_ClienteEspecifico(dgvOrden.CurrentRow.Cells[3].Value.ToString());
            dgvEmpleado.DataSource = obje.mostrar_EmpleadoEspecifico(dgvOrden.CurrentRow.Cells[1].Value.ToString());
        }

        private void dgvDetalleOrden_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double total;
            
                txtIdMenu.Text = dgvDetalleOrden.CurrentRow.Cells[0].Value.ToString();
                txtNombreMenu.Text = dgvDetalleOrden.CurrentRow.Cells[1].Value.ToString();
                txtExtra.Text = dgvDetalleOrden.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dgvDetalleOrden.CurrentRow.Cells[3].Value.ToString();
                txtPrecioUni.Text = dgvDetalleOrden.CurrentRow.Cells[4].Value.ToString();
                total = double.Parse(txtPrecioUni.Text) * int.Parse(txtCantidad.Text);
                txtTotalMe.Text = total.ToString();

                btnModificarDeta.Enabled = true;
                btnEliminarDeta.Enabled = true;
            
        }

        private void txtIdMenu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificarDeta_Click(object sender, EventArgs e)
        {
            respuesta = detaOrden.modificar_DetalleOrden(txtNoOrden.Text, txtIdMenu.Text, txtExtra.Text, txtCantidad.Value.ToString(), txtPrecioUni.Text, txtTotalMe.Text);
            llenardaosorden();
            if (respuesta=="1") {
                MessageBox.Show("Registro Modificado Correctamente");
                btnModificarDeta.Enabled = false;
                btnEliminarDeta.Enabled = false;


                txtIdMenu.Clear();
                txtNombreMenu.Clear();
                txtExtra.Clear();
                txtCantidad.Text = "1";
                txtPrecioUni.Clear();
                txtTotalMe.Clear();
            }
            else {
                MessageBox.Show("Registro no modificado" + respuesta);
            }
        }
    }
    
}
