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
    public partial class DatosCliente : Form
    {
        public string idCliente, nombre;
        public int bandera = 0;

        TransacCliente obj = new TransacCliente();
        string res = "";
        public DatosCliente()
        {
            InitializeComponent();
        }
        void llenar()
        {

            dgvCliente.DataSource = obj.mostrar_Cliente();
        }

       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
             txtIdCliente.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            mskDui.Clear();
            btnAgregar.Enabled = true;


        }
        private void DatosCliente_Load(object sender, EventArgs e)
        {
            llenar();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            res = obj.agregar_Cliente(txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, mskDui.Text);
            btnAgregar.Enabled = false;
            llenar();
            if (res == "1")
            {
                MessageBox.Show("Registro Insertado Correctamente");
            }
            else
                MessageBox.Show("Dato no insertado" + res);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            res = obj.modificar_Cliente(txtIdCliente.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, mskDui.Text);
            llenar();
            if (res == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");
                txtIdCliente.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                mskDui.Clear();
            }

            else
            {
                MessageBox.Show("Registro no modificado" + res);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Eliminar el Registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                res = obj.eliminar_Cliente(txtIdCliente.Text);
                txtIdCliente.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                mskDui.Clear();
                llenar();
                if (res == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro no eliminado" + res);
            }
        }

      
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCliente.DataSource = obj.buscar_Cliente(txtBuscar.Text);
        }

        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            mskDui.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            if(!(txtIdCliente.Text == ""))
                btnSelecClie.Enabled = true;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        private void DatosCliente_Load_1(object sender, EventArgs e)
        {
            llenar();
        }

        public void btnSelecClie_Click(object sender, EventArgs e)
        {
            bandera = 1;
            idCliente = this.txtIdCliente.Text;
            nombre = this.txtNombre.Text+" " + this.txtApellido.Text;
            this.Close();
        }
    }
}
