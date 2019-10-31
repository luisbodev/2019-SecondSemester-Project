using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComidaRapida
{
    public partial class frmCajero : Form
    {
        public frmCajero()
        {
            InitializeComponent();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            /*int desktopWidth5 = desktopSize.Width / 6;
            panelMenu.Width = desktopWidth5 * 4;
            dtgMenu.Width = (desktopWidth5 * 3) - 25;
            dtgOrden.Width = (desktopWidth5 * 2) - 25;
            panelBuscar.Width = desktopWidth5;
            panelOrden.Width = desktopWidth5*2;*/

            

            Int32 ancho = (this.Width - panelTime.Width) / 2;
            panelTime.Location = new Point(ancho, panelTime.Location.Y);

            

            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelHora.Text = DateTime.Now.ToShortTimeString();
          
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿Está seguro que quiere cerrar Seción?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }

        private void btnCerrarT_Click(object sender, EventArgs e) //Cerrar la ventana Para que funcione el deslogeo
        {
            if(MessageBox.Show("¿En realidad desea Cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
