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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            TransacAutenticacion obj = new TransacAutenticacion();





            //_______________________________________________________________



            string cadena = obj.loginUser(txtNomUsu.Text);

            

          

            bool validLogin = obj.validacion(txtNomUsu.Text, txtContraUs.Text);



            if (validLogin == true)
            {
                MessageBox.Show("¡Ha ingresado correctamente!");
                if (cadena == "admi")
                {
                    frmAdministrador adm = new frmAdministrador();
                    this.Hide();
                    adm.ShowDialog();
                    this.Close();

                }
                else if (cadena == "caje")
                {
                    frmCajero caje = new frmCajero();
                    this.Hide();
                    caje.ShowDialog();
                    this.Close();
                }
                else if (cadena == "chef")
                {
                    frmCocinero chef = new frmCocinero();
                    this.Hide();
                    chef.ShowDialog();
                    this.Close();
                }

                
            }
            else
            {

                txtContraUs.Clear();
                txtNomUsu.Clear();
                txtNomUsu.Focus();

                MessageBox.Show("Error al iniciar cesion");
            }

            //_______________________________________________________________







        }
    }
}

