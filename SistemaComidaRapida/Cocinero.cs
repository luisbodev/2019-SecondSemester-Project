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

        private void frmCocinero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
