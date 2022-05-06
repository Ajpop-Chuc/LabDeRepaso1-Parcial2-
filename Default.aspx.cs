using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDeRepaso1_Parcial2_
{
    public partial class _Default : Page
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

            Alumnos alumno = new Alumnos();
            alumno.nombre = TextBoxNombre.Text;
            alumno.apellido = TextBoxApellido.Text;
            alumno.direccion = TextBoxDireccion.Text;
            alumno.FechaNacimiento = Calendar1.SelectedDate;
            alumno.Carne = TextBoxCarne.Text;

            universidad.Nombre = TextBoxNombreU.Text;
            universidad.ListaAlumnos.Add(alumno);
            if (Universidad.listaDatosU.Find(x => x.Nombre == TextBoxNombreU.Text)==null) { Universidad.listaDatosU.Add(universidad);  }
            Universidad.guardarenJson(archivo);
        }
    }
}