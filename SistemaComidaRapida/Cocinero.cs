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
        int ocupado1 = 0, ocupado2 = 0, ocupado3 = 0;

        TransacOrden obj = new TransacOrden();

        string res = "";
        public frmCocinero()
        {
            InitializeComponent();
        }

        

        private void frmCocinero_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = "Usuario: " + this.userEmp;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere cerrar Sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close(); 
        }

        private void btnTerminado1_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden1.Text, 2.ToString());
            txtNoOrden1.Clear();
            dgvDetalleOrden1.DataSource = null;
            btnTerminado1.Enabled = false;
            ocupado1 = 0;
        }

        private void btnTerminado2_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden2.Text, 2.ToString());
            txtNoOrden2.Clear();
            dgvDetalleOrden2.DataSource = null;
            btnTerminado2.Enabled = false;
            ocupado2 = 0;
        }

        private void btnTerminado3_Click(object sender, EventArgs e)
        {
            obj.modi_estadoOrden(txtNoOrden3.Text, 2.ToString());
            txtNoOrden3.Clear();
            dgvDetalleOrden3.DataSource = null;
            btnTerminado3.Enabled = false;
            ocupado3 = 0;
        }

        private void frmCocinero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ocupado1 == 0)
            {
                string noOrden, estado;

                noOrden = obj.mostrar_UltOrdenNoIni();
                if (!(noOrden == null || noOrden=="0"))
                {
                    estado = obj.mostrar_UltOrdenEsta(noOrden);

                    if (int.Parse(estado) == 0)
                    {
                        btnTerminado1.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 1.ToString());
                        ocupado1 = 1;
                        txtNoOrden1.Text = noOrden;
                        dgvDetalleOrden1.DataSource = obj.mostrar_detalleOrdPro(noOrden);
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

                    if (int.Parse(estado) == 0)
                    {
                        btnTerminado2.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 1.ToString());
                        ocupado2 = 1;
                        txtNoOrden2.Text = noOrden;
                        dgvDetalleOrden2.DataSource = obj.mostrar_detalleOrdPro(noOrden);
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

                    if (int.Parse(estado) == 0)
                    {
                        btnTerminado3.Enabled = true;
                        obj.modi_estadoOrden(noOrden, 1.ToString());
                        ocupado3 = 1;
                        txtNoOrden3.Text = noOrden;
                        dgvDetalleOrden3.DataSource = obj.mostrar_detalleOrdPro(noOrden);
                    }
                }
            }



           
        }
    }
}
