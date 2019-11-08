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
        int cantidad;
        public string idMenu, precioUnidad, total;
        double totalDeta;

        TransacOrden obje = new TransacOrden();
        TransacDetalleOrden detaOrden = new TransacDetalleOrden();
        string respuesta = "";

        public frmDatosOrdenes()
        {
            InitializeComponent();
        }

        void llenar()
        {
            dgvOrden.DataSource = obje.mostrar_Orden();
        }

        void llenardaosorden()
        {
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


            if (!(dgvDetalleOrden.CurrentRow.Cells[0].Value.ToString() == ""))
            {
                txtIdMenu.Text = dgvDetalleOrden.CurrentRow.Cells[0].Value.ToString();
                txtNombreMenu.Text = dgvDetalleOrden.CurrentRow.Cells[1].Value.ToString();
                txtExtra.Text = dgvDetalleOrden.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dgvDetalleOrden.CurrentRow.Cells[3].Value.ToString();
                txtPrecioUni.Text = dgvDetalleOrden.CurrentRow.Cells[4].Value.ToString();

                total = double.Parse(dgvDetalleOrden.CurrentRow.Cells[4].Value.ToString()) * int.Parse(txtCantidad.Text = dgvDetalleOrden.CurrentRow.Cells[3].Value.ToString());
                txtTotalMe.Text = total.ToString();///-----------------------------------------------


                btnModificarDeta.Enabled = true;
                btnEliminarDeta.Enabled = true;
            }

        }

        private void txtIdMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarDeta_Click(object sender, EventArgs e)
        {
            double totalFinal;

            if (int.Parse(txtCantidad.Text) > cantidad)
            {
                totalFinal = double.Parse(txtTotal.Text) + double.Parse(txtTotalMe.Text);
            }
            else
            {
                totalFinal = double.Parse(txtTotal.Text) - double.Parse(txtTotalMe.Text);
            }

            //totalFinal = double.Parse(txtPrecioUni.Text) * int.Parse(txtCantidad.Text);

            obje.total_FinalOrden(totalFinal.ToString(), txtNoOrden.Text);

            detaOrden.actualizar_Det(totalDeta.ToString(), txtIdMenu.Text, txtNoOrden.Text);

            respuesta = detaOrden.modificar_DetalleOrden(txtNoOrden.Text, txtIdMenu.Text, txtExtra.Text, txtCantidad.Value.ToString(), txtPrecioUni.Text, txtTotalMe.Text);




            if (respuesta == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");
                btnModificarDeta.Enabled = false;
                btnEliminarDeta.Enabled = false;

                llenardaosorden();
                llenar();
                txtTotal.Text = dgvOrden.CurrentRow.Cells[4].Value.ToString();

                txtIdMenu.Clear();
                txtNombreMenu.Clear();
                txtExtra.Clear();
                txtCantidad.Text = "1";
                txtPrecioUni.Clear();
                txtTotalMe.Clear();
            }
            else
            {
                MessageBox.Show("Registro no modificado" + respuesta);
            }
        }

        int cantidadDetalle;

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            cantidadDetalle = int.Parse(txtCantidad.Text);
            totalDeta = double.Parse(txtPrecioUni.Text) * cantidadDetalle;///--------------<><<<<>>>>><<<<>
            txtTotalMe.Text = totalDeta.ToString();
            

        }

        
        private void btnEliminarDeta_Click(object sender, EventArgs e)
        {
            double totalFinal;
            if (MessageBox.Show("¿Está seguro de Eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                respuesta = detaOrden.eliminar_Detalle(txtNoOrden.Text, txtIdMenu.Text);
                btnModificarDeta.Enabled = false;
                btnEliminarDeta.Enabled = false;


                totalFinal = double.Parse(txtTotal.Text) - double.Parse(txtTotalMe.Text);

                obje.total_FinalOrden(totalFinal.ToString(), txtNoOrden.Text);

                txtIdMenu.Clear();
                txtNombreMenu.Clear();
                txtExtra.Clear();
                txtCantidad.Text = "1";
                txtPrecioUni.Clear();
                txtTotalMe.Clear();
                llenardaosorden();
                llenar();
                txtTotal.Text = dgvOrden.CurrentRow.Cells[4].Value.ToString();
                if (respuesta == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No eliminado" + respuesta);
            }
        }
    }

}