using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = "EduardoHT";
            string password = "12345";

            string usuario2 = "Manolito";
            string password2 = "1234";

            string usuario3 = "God";
            string password3 = "123";

            Dictionary<String, String> Cuentas = new Dictionary<String, String>();
            Cuentas.Add(usuario, password);
            Cuentas.Add(usuario2, password2);
            Cuentas.Add(usuario3, password3);


            try
            {


                String Bcuenta = Cuentas[txtUsuario.Text.ToString()];


                if (Bcuenta.Equals(txtPassword.Text))
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta UwU");
                }
            }
            catch
            {
                MessageBox.Show("El usuario no existe c:");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
