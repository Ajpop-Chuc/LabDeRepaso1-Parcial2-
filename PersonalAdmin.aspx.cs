using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDeRepaso1_Parcial2_
{
    public partial class About : Page
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

        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Datos.json");
            Universidad universidad = Universidad.listaDatosU.Find(x => x.Nombre == TextBoxNombreU.Text);
            if (universidad == null) { universidad = new Universidad(); }

            PersonalAdministrativo personal = new PersonalAdministrativo();
            personal.nombre = TextBoxNombre.Text;
            personal.apellido = TextBoxApellido.Text;
            personal.direccion = TextBoxDireccion.Text;
            personal.FechaNacimiento = Calendar1.SelectedDate;
            personal.noIgss = TextBoxNoIGSS.Text;
            personal.Profesion = TextBoxProfesion.Text;
            personal.FechaInicioLabores = CalendarInicioLabores.SelectedDate;
            personal.FechaFinLabores = CalendarFinLabores.SelectedDate;

            universidad.Nombre = TextBoxNombreU.Text;
            universidad.ListaPersonalAdmin.Add(personal);
            if (Universidad.listaDatosU.Find(x => x.Nombre == TextBoxNombreU.Text) == null) { Universidad.listaDatosU.Add(universidad); }
            Universidad.guardarenJson(archivo);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}