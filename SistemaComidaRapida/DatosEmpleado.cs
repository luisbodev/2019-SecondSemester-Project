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
    public partial class frmDatosEmpleado : Form
    {
        TransacEmpleado objE = new TransacEmpleado();
        TransacUsuario objU = new TransacUsuario();

        string respuestaE= "";
      

        public frmDatosEmpleado()
        {
            InitializeComponent();
        }

        void llenar()
        {
            dgvEmpleado.DataSource = objE.mostrar_Empleado();
        }

        private void DatosEmpleado_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            respuestaE = objE.agregar_Empleado(txtNombre.Text, txtApellido.Text, mskDui.Text, cmbCargo.Text);
            btnAgregar.Enabled = false;
            llenar();
            if (respuestaE == "1")
            {
                MessageBox.Show("Registro Insertado Correctamente");
            }
            else
                MessageBox.Show("Datono Incertado" + respuestaE);


        }








        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtIdEmpleado.Clear();
            mskDui.Clear();
            cmbCargo.ResetText();
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            respuestaE = objE.modificar_Empleado(txtIdEmpleado.Text, txtNombre.Text, txtApellido.Text, mskDui.Text, cmbCargo.Text);
            llenar();
            if (respuestaE == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");
            }
            else
            {
                MessageBox.Show("Registro no Modificado " + respuestaE);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de Eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                respuestaE = objE.eliminar_Empleado(txtIdEmpleado.Text);
                txtNombre.Clear();
                txtApellido.Clear();
                txtIdEmpleado.Clear();
                mskDui.Clear();
                cmbCargo.ResetText();
                llenar();
                if (respuestaE == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No eliminado" + respuestaE);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = objE.buscar_Empleado(txtBuscar.Text);
        }

        private void dgvEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            mskDui.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            cmbCargo.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
