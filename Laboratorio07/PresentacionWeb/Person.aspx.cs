using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace PresentacionWeb
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            gvdatos.DataSource = dt;
            gvdatos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int PersonId = Int32.Parse(txtPersonID.Text.Trim());
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetUsuario(PersonId);

            gvdatos.DataSource = dt;
            gvdatos.DataBind();
        }
    }
    
}