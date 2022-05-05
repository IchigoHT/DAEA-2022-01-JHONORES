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
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public manPerson()
        {
            InitializeComponent();
        }


        private void manPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-9586QKG\\LOCAL;Database=School;Integrated Security=true";
            conn = new SqlConnection(str);
            btnBuscar.Enabled = false;
            btnInsertar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            ds.Clear();

            adapter.Fill(ds, "Person");

            tablePerson = ds.Tables["Person"];

            btnBuscar.Enabled = true;
            btnInsertar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
            Clear();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, conn);

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirtsName.Text;
            fila["HireDate"] = txtHireDate.Value;
            fila["EnrollmentDate"] = txtEnrollmentDate.Value;


            tablePerson.Rows.Add(fila);

            adapter.Update(tablePerson);

            MessageBox.Show("Registro Insetado");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@LastNAme", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID ='" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirtsName.Text;
            fila[0]["HireDate"] = txtHireDate.Value;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Value;

            adapter.Update(tablePerson);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");

            fila[0].Delete();
            adapter.Update(tablePerson);

        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirtsName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();

                string hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hireDate;

                string enrollmenteDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (string.IsNullOrEmpty(enrollmenteDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmenteDate;

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPersonID.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }

            if (txtLastName.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }

            if (txtFirtsName.Text.Trim().Length > 0)
            {

                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "FirstName = '" + txtFirtsName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }

            if (txtPersonID.Text.Trim().Length == 0 && txtFirtsName.Text.Trim().Length == 0 && txtLastName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe almenos llenar un campo para buscar");
            }

            Clear();
        }


        void Clear()
        {
            txtPersonID.Text = "";
            txtFirtsName.Text = "";
            txtLastName.Text = "";
            txtHireDate.Checked = false;
            txtEnrollmentDate.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPersonID.Text = "";
            txtFirtsName.Text = "";
            txtLastName.Text = "";
            txtHireDate.Checked = false;
            txtEnrollmentDate.Checked = false;

        }
    }
}
