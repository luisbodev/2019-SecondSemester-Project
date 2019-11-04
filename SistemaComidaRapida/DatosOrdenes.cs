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
            dgvDetalleOrden.DataSource = detaOrden.mostrar_detOrdenEspe(dgvOrden.CurrentRow.Cells[0].Value.ToString());
            dgvCliente.DataSource = obje.mostrar_ClienteEspecifico(dgvOrden.CurrentRow.Cells[3].Value.ToString());
            dgvEmpleado.DataSource = obje.mostrar_EmpleadoEspecifico(dgvOrden.CurrentRow.Cells[1].Value.ToString());
        }
    }
    
}
