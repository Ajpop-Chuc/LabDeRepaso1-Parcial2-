using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabDeRepaso1_Parcial2_
{
    public partial class CRUD : System.Web.UI.Page
    {
        static Universidad universidad;
        static Alumnos datosAlumno;
        static string carneSeleccionado;
        static Docentes datosDocente;
        static string IdSeleccionado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string archivo = Server.MapPath("Datos.json");
                Universidad.listaDatosU.Clear();
                Universidad.leerJson(archivo);
            }
        }

        protected void ButtonBuscarAlumno_Click(object sender, EventArgs e)
        {
            carneSeleccionado = TextBoxCarne.Text;
            universidad = Universidad.listaDatosU.Find(x => x.Nombre == TextBoxUniversidad.Text);
            if (universidad == null) { }
            else
            {
                datosAlumno = universidad.ListaAlumnos.Find(x => x.Carne == carneSeleccionado);
                if (datosAlumno == null) { }
                else
                {
                    TextBoxNombreEstudiante.Text = datosAlumno.nombre;
                    TextBoxApellidoEstudiante.Text = datosAlumno.apellido;
                }
            }
            
        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            datosAlumno.nombre = TextBoxNombreEstudiante.Text;
            datosAlumno.apellido = TextBoxApellidoEstudiante.Text;
            string archivo = Server.MapPath("Datos.json");
            Universidad.guardarenJson(archivo);
        }

        protected void ButtonBuscarDocente_Click(object sender, EventArgs e)
        {
            IdSeleccionado = TextBoxID.Text;
            universidad = Universidad.listaDatosU.Find(x => x.Nombre == TextBoxUniversidad.Text);
            if (universidad == null) {  }
            else
            {
                datosDocente = universidad.ListaDocentes.Find(x => x.Id == IdSeleccionado);
                if (datosDocente == null) {  }
                else
                {
                    TextBoxNombreDocente.Text = datosDocente.nombre;
                    TextBoxApellidoDocente.Text = datosDocente.apellido;
                }
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int posicion = Universidad.listaDatosU.FindIndex(x => x.Nombre == TextBoxUniversidad.Text);
            universidad.ListaDocentes.RemoveAt(posicion);
            string archivo = Server.MapPath("Datos.json");
            Universidad.guardarenJson(archivo);
        }
    }
}