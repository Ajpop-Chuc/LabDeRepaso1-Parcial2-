using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDeRepaso1_Parcial2_
{
    public partial class Visulizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("Datos.json");
                Universidad.listaDatosU.Clear();
                Universidad.leerJson(archivo);
            }

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string NombreU = TextBox1.Text;
            Universidad universidad = Universidad.listaDatosU.Find(x => x.Nombre == NombreU);
            GridViewAlumno.DataSource = null;
            GridViewAlumno.DataBind();
            GridViewAlumno.DataSource = universidad.ListaAlumnos;
            GridViewAlumno.DataBind();

            GridViewDocente.DataSource = null;
            GridViewDocente.DataBind();
            GridViewDocente.DataSource = universidad.ListaDocentes;
            GridViewDocente.DataBind();

            GridViewPersonal.DataSource = null;
            GridViewPersonal.DataBind();
            GridViewPersonal.DataSource = universidad.ListaPersonalAdmin;
            GridViewPersonal.DataBind();
        }
    }
}