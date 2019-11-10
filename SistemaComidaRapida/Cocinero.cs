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
    public partial class frmCocinero : Form
    {
        public string userEmp;
        public int formulario = 0;
        int ocupado1 = 0, ocupado2 = 0, ocupado3 = 0;

        TransacOrden obj = new TransacOrden();
        TransacDetalleOrden objDeta = new TransacDetalleOrden();

        string res = "";
        public frmCocinero()
        {
            InitializeComponent();
        }
        
        

        private void frmCocinero_Load(object sender, EventArgs e)
        {
            if (formulario == 0)
            {   //Mostrar nombre de usuario
                labelUsuario.Text = "Usuario: " + this.userEmp;
            }
            
        }
        //Boton Cerrar Sesion
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar Sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        //Boton minimizar ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Boton cerrar app
        private void btnCerrarT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿En realidad desea Cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        //Boton para actualizar el estado de la orden mostrada a cocinada
        private void btnTerminado1_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden1.Text, 3.ToString());
            txtNoOrden1.Clear();
            dgvDetalleOrden1.DataSource = null;
            btnTerminado1.Enabled = false;
            ocupado1 = 0;
        }
        //Boton para actualizar el estado de la orden mostrada a cocinada
        private void btnTerminado2_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden2.Text, 3.ToString());
            txtNoOrden2.Clear();
            dgvDetalleOrden2.DataSource = null;
            btnTerminado2.Enabled = false;
            ocupado2 = 0;
        }
        //Boton Cerrar ventana si se ha abierto desde pantalla de administrador o pantalla de cajero
        private void btnCerrarFrm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Boton para actualizar el estado de la orden mostrada a cocinada
        private void btnTerminado3_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden3.Text, 3.ToString());
            txtNoOrden3.Clear();
            dgvDetalleOrden3.DataSource = null;
            btnTerminado3.Enabled = false;
            ocupado3 = 0;
        }

      //Funcion para actualizar ordenes nuevas cada segundo utilizando componente timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ocupado1 == 0)
            {
                string noOrden, estado;

                noOrden = obj.mostrar_UltOrdenNoIni();
                if (!(noOrden == null || noOrden=="0"))
                {
                    estado = obj.mostrar_UltOrdenEsta(noOrden);

                    if (int.Parse(estado) == 1)
                    {
                        btnTerminado1.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 2.ToString());
                        ocupado1 = 1;
                        txtNoOrden1.Text = noOrden;
                        dgvDetalleOrden1.DataSource = objDeta.mostrar_detalleOrdPro(noOrden);
                    }
                }
            }
            else if (ocupado2 == 0)
            {
                string noOrden, estado;

                noOrden = obj.mostrar_UltOrdenNoIni();
                if (!(noOrden == null || noOrden == "0"))
                {
                    estado = obj.mostrar_UltOrdenEsta(noOrden);

                    if (int.Parse(estado) == 1)
                    {
                        btnTerminado2.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 2.ToString());
                        ocupado2 = 1;
                        txtNoOrden2.Text = noOrden;
                        dgvDetalleOrden2.DataSource = objDeta.mostrar_detalleOrdPro(txtNoOrden2.Text);
                    }
                }
            }
            else if (ocupado3 == 0)
            {
                string noOrden, estado;

                noOrden = obj.mostrar_UltOrdenNoIni();

                if (!(noOrden == null || noOrden == "0"))
                {
                    estado = obj.mostrar_UltOrdenEsta(noOrden);

                    if (int.Parse(estado) == 1)
                    {
                        btnTerminado3.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 2.ToString());
                        ocupado3 = 1;
                        txtNoOrden3.Text = noOrden;
                        dgvDetalleOrden3.DataSource = objDeta.mostrar_detalleOrdPro(txtNoOrden3.Text);
                    }
                }
            }



           
        }
    }
}
