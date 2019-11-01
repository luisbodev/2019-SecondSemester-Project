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



            if (validLogin == true ){
                if (cadena == "admi"){
                    frmAdministrador adm = new frmAdministrador();
                    adm.menuStripAdmin.Visible = true;
                    adm.menuStrip2.Visible = false;
                    adm.Show();
                    
                    //this.Close();
                    adm.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                    this.Hide();
                 }
                else if (cadena == "caje"){ 
                    frmAdministrador adm = new frmAdministrador();
                    adm.menuStripAdmin.Visible = false;
                    adm.menuStrip2.Visible = true;
                    adm.Show();


                    //frmCajero caje = new frmCajero();

                    //caje.Show();
                    //this.Close();
                    //caje.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                    this.Hide();
                }
                else if (cadena == "chef"){
                    frmCocinero chef = new frmCocinero();
                    this.Hide();
                    chef.ShowDialog();
                    //this.Close();

                    chef.FormClosed += desLoguear; //Funcion de deslogeo-----------------------------------
                }

                
            }
            else{
                txtContraUs.Clear();
                txtNomUsu.Clear();
                txtNomUsu.Focus();

                MessageBox.Show("Usuario o Contraseña no validos", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
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
            

            this.Show();
            txtNomUsu.Focus();

        }






    }
}

