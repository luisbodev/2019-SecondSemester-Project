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
            dgvUsuario.DataSource = objU.mostrar_Usuario();
            dgbEmpleado200.DataSource = objE.mostrar_Empleado();
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

            //-----------------------

            txtUser.Clear();
            txtPass.Clear();
            txtIdUsuario.Clear();
            txtRol.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            respuestaE = objE.modificar_Empleado(txtIdEmpleado.Text, txtNombre.Text, txtApellido.Text, mskDui.Text, cmbCargo.Text);
            llenar();
            if (respuestaE == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");

                txtUser.Clear();
                txtPass.Clear();
                txtIdUsuario.Clear();
                txtRol.Clear();

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
            //--------------------------------------------------------------------

            txtIdUsuario.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtRol.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //_-Agregar Usuario.  .Substring(0, 3)
            llenar();

            if(txtPass.Text == txtsena.Text)
            {
                respuestaE = objU.agregar_Usuario(txtUser.Text, txtIdUsuario.Text, txtPass.Text, txtRol.Text.Substring(0, 4));
                btnAgregar.Enabled = false;
                llenar();
                if (respuestaE == "1")
                {
                    MessageBox.Show("Registro Insertado Correctamente");
                }
                else
                    MessageBox.Show("Datono Incertado" + respuestaE);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, intentelo de nuevo");
                txtPass.Clear();
                txtsena.Clear();
            }
        }

        private void dgbEmpleado200_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdEmpleado.Text = dgbEmpleado200.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgbEmpleado200.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgbEmpleado200.CurrentRow.Cells[2].Value.ToString();
            mskDui.Text = dgbEmpleado200.CurrentRow.Cells[3].Value.ToString();
            cmbCargo.Text = dgbEmpleado200.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUnuevo_Click(object sender, EventArgs e)
        {
            txtsena.Clear();
            txtRol.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtIdUsuario.Clear();
        }

        private void btnUeliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de Eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                respuestaE = objU.eliminar_Usuario(txtIdUsuario.Text);
                txtsena.Clear();
                txtRol.Clear();
                txtUser.Clear();
                txtPass.Clear();
                txtIdUsuario.Clear();
                llenar();
                if (respuestaE == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No eliminado" + respuestaE);
            }
        }

        private void btnUmodificar_Click(object sender, EventArgs e)
        {
            respuestaE = objU.modificar_Usuario(txtUser.Text, txtIdUsuario.Text, txtPass.Text, txtRol.Text.Substring(0, 3));
            llenar();
            if (respuestaE == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");

                txtUser.Clear();
                txtPass.Clear();
                txtIdUsuario.Clear();
                txtRol.Clear();

            }
            else
            {
                MessageBox.Show("Registro no Modificado " + respuestaE);
            }
        }

        private void dgvUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           txtUser.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            txtIdUsuario.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtRol.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
