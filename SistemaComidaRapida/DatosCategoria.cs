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
    public partial class DatosCategoria : Form
    {
        TransacCategoria obje = new TransacCategoria();
        string respuesta = "";


        public DatosCategoria()
        {
            InitializeComponent();
        }
        void llenar()
        {
            dgvCat.DataSource = obje.mostrar_Cat();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            respuesta = obje.agregar_cat(txtNombreCat.Text);

            llenar();
            if (respuesta == "1")
            {
                MessageBox.Show("Registro Insertado Correctamente");
            }
            else
                MessageBox.Show("Dato No Incertado" + respuesta);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de Eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                respuesta = obje.eliminar_cat(txtIdCat.Text);
                txtBuscar.Clear();

                llenar();
                if (respuesta == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No eliminado" + respuesta);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            respuesta = obje.modificar_cat(txtIdCat.Text, txtNombreCat.Text);
            llenar();
            if (respuesta == "1")
            {
                MessageBox.Show("Registro Modificado Correctamente");
            }
            else
            {
                MessageBox.Show("Registro no Modificado " + respuesta);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreCat.Clear();
            txtIdCat.Clear();
            txtBuscar.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvCat.DataSource = obje.buscar_cat(txtBuscar.Text);
        }

        private void DatosCategoria_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void dgvCat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCat.Text = dgvCat.CurrentRow.Cells[0].Value.ToString();
            txtNombreCat.Text = dgvCat.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
