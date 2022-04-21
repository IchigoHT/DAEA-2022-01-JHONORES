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

namespace Lab05
{
    public partial class manPerson : Form
    {
        SqlConnection conn;
        public manPerson()
        {
            InitializeComponent();
        }


        private void manPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-9586QKG\\LOCAL;Database=School;Integrated Security=true";
            conn = new SqlConnection(str);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            conn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirtsName.Text);
            cmd.Parameters.AddWithValue("@LastNAme", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el codigo:" + codigo);
            conn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirtsName.Text);
            cmd.Parameters.AddWithValue("@LastNAme", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int resultado = cmd.ExecuteNonQuery();
            if(resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro Correctamente");
            }
            conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);

            try
            {
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Se ha eliminado el registro correctamente");
                }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Eliminar : " + ex.ToString());
            }
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirtsName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

            if (txtFirtsName.TextLength > 0)
            {
                conn.Open();
                String bpn = "BuscarPersonaNombre";
                SqlCommand cmd = new SqlCommand(bpn, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", txtFirtsName.Text);

                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al Eliminar : " + ex.ToString());
                }

            }

            if (txtPersonID.TextLength > 0)
            {
                conn.Open();
                String bpi = "BuscarPersonaID";
                SqlCommand cmd = new SqlCommand(bpi, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", Int32.Parse(txtPersonID.Text));

                try
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al Eliminar : " + ex.ToString());
                }
            }
        }
    }
}
