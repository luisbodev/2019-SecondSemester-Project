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
        string noOrdenIni;

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
            obj.modi_estadoOrden(txtNoOrden1.Text, 2.ToString());
            txtNoOrden2.Clear();
            dgvDetalleOrden2.DataSource = null;
            btnTerminado3.Enabled = false;
            ocupado3 = 0;
        }

        private void frmCocinero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ocupado1 == 0 || ocupado2 == 0 || ocupado3 == 0){
                    string noOrdenIni;
                    noOrdenIni = obj.mostrar_UltOrdenNoIni();
                if (!(noOrdenIni == null))
                {
                    if (ocupado1 == 0 && noOrdenIni == "0")
                    {
                        ocupado1 = 1;
                        btnTerminado1.Enabled = true;
                        obj.modi_estadoOrden(noOrdenIni, 1.ToString());

                        txtNoOrden1.Text = noOrdenIni;
                        dgvDetalleOrden1.DataSource = obj.mostrar_detalleOrdPro(txtNoOrden1.Text);
                    }
                    else if (ocupado2 == 0 && int.Parse(noOrdenIni) == 0)
                    {
                        ocupado2 = 1;
                        btnTerminado2.Enabled = true;

                        txtNoOrden2.Text = noOrdenIni;
                        dgvDetalleOrden2.DataSource = obj.mostrar_detalleOrdPro(txtNoOrden1.Text);
                    }
                    else if (ocupado3 == 0 && int.Parse(noOrdenIni) == 0)
                    {
                        ocupado3 = 1;
                        btnTerminado3.Enabled = true;

                        txtNoOrden3.Text = noOrdenIni;
                        dgvDetalleOrden3.DataSource = obj.mostrar_detalleOrdPro(txtNoOrden1.Text);
                    }
                }
            }
        }
    }
}
