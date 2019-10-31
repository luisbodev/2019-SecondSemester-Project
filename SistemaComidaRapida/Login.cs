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
                    adm.Show();
                    //this.Close();
                    adm.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                    this.Hide();

                }
                else if (cadena == "caje")
                {
                    frmCajero caje = new frmCajero();
                    caje.Show();
                    //this.Close();
                    caje.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                    this.Hide();
                }
                else if (cadena == "chef")
                {
                    frmCocinero chef = new frmCocinero();
                    this.Hide();
                    chef.ShowDialog();
                    //this.Close();

                    chef.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                }

                
            }
            else
            {

                txtContraUs.Clear();
                txtNomUsu.Clear();
                txtNomUsu.Focus();

                MessageBox.Show("Contraneña o Usuario no validos");
            }

            //_______________________________________________________________




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desLoguear( object sender, FormClosedEventArgs e) //Funcion para desloguear
        {
            txtContraUs.Clear();
            txtNomUsu.Clear();
            lblError.Visible = false;

            this.Show();
            txtNomUsu.Focus();

        }






    }
}

