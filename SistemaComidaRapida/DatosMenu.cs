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
    public partial class frmDatosMenu : Form
    {
        
        
        TransacMenu obje = new TransacMenu();
        TransacCategoria objecd =  new TransacCategoria();

        string respuesta = "";

        

        public frmDatosMenu()
        {
            InitializeComponent();

            cobCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void llenar()
        {
            dgvAlumnos.DataSource = obje.mostrar_menu();
        }

        private void frmDatosMenu_Load(object sender, EventArgs e)
        {
            llenar();
            listarCategorias();
        }

        private void listarCategorias()
        {
            TransacCategoria objeC = new TransacCategoria();
            cobCategoria.DataSource = objeC.Listar_Cat("categoria");
            cobCategoria.DisplayMember = "nombreCate";
            cobCategoria.ValueMember = "idCategoria";
        }
      



 

    



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            respuesta = obje.agregar_menu(txtNom.Text,txtDesc.Text, txtPrec.Text, cobCategoria.SelectedValue.ToString());
            btnAgregar.Enabled = false;
            llenar();
            if (respuesta == "1")
            {
                MessageBox.Show("Registro Insertado Correctamente");
            }
            else
                MessageBox.Show("Dato No Incertado" + respuesta);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtDesc.Clear();
            txtIdMenu.Clear();
            txtNom.Clear();
            txtPrec.Clear();
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            respuesta = obje.modificar_menu(txtIdMenu.Text, txtNom.Text, txtDesc.Text, txtPrec.Text, cobCategoria.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro de Eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                respuesta = obje.eliminar_menu(txtIdMenu.Text);
                txtBuscar.Clear();
                txtDesc.Clear();
                txtIdMenu.Clear();
                txtNom.Clear();
                txtPrec.Clear();
                llenar();
                if (respuesta == "1")
                    MessageBox.Show("Registro Eliminado Correctamente");
                else
                    MessageBox.Show("Registro No eliminado" + respuesta);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = obje.buscar_menu(txtBuscar.Text);
        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdMenu.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtNom.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtPrec.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            cobCategoria.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumeros(e);
        }

      
        void validarNumeros(KeyPressEventArgs e)

        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {

                e.Handled = false;

            }

            else if (e.KeyChar == 8)

            {

                e.Handled = false;

            }

            else if (e.KeyChar == '.'){
                if(txtPrec.Text.IndexOf(".")==0) {
                    e.Handled = true;
                }
                else if(txtPrec.Text.IndexOf(".")>0) {
                        e.Handled = true;
                    }
                else {
                        e.Handled = false;
                    }
                }
            else{
                e.Handled = true;
            }

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
