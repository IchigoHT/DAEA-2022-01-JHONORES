using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Lab03
{
    public partial class Login : Form
    {

        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

  
       

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String servidor = "DESKTOP-9586QKG\\LOCAL";
            String bd = "db_lab03";
            String user = txtUsuario.Text;
            String pws = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" +
                          bd + ";Integrated Security = true";


            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                Console.WriteLine("Conectado con exito");

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        String sql = "SELECT * FROM tbl_usuario WHERE usuario_nombre = '" +
                                        user + "' AND usuario_password = '" + pws + "'";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        int Nusuario = dt.Rows.Count;
                        Console.WriteLine(Nusuario);

                        if (Nusuario == 1)
                        {
                            Persona persona = new Persona(conn);
                            persona.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña son incorrectas");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al encontrar el usuario : \n" + ex.ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor : \n" + ex.ToString());
            }
        }

        private void cbMostarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            String Pass = txtPassword.Text;

            if (cbMostarContraseña.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = Pass;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = Pass;
            }
        }
    }
}
