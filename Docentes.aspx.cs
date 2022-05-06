using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDeRepaso1_Parcial2_
{
    public partial class Contact : Page
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
            string archivo = Server.MapPath("Datos.json");
            Universidad universidad = Universidad.listaDatosU.Find(x => x.Nombre == TextBoxNombreU.Text);
            if (universidad == null) { universidad = new Universidad(); }

            Docentes docente = new Docentes();
            docente.nombre = TextBoxNombre.Text;
            docente.apellido = TextBoxApellido.Text;
            docente.direccion = TextBoxDireccion.Text;
            docente.FechaNacimiento = Calendar1.SelectedDate;
            docente.Id = TextBoxId.Text;
            docente.Titulo = TextBoxTitulo.Text;

            universidad.Nombre = TextBoxNombreU.Text;
            universidad.ListaDocentes.Add(docente);
            if (Universidad.listaDatosU.Find(x => x.Nombre == TextBoxNombreU.Text) == null) { Universidad.listaDatosU.Add(universidad); }
            Universidad.guardarenJson(archivo);
        }
    }
}