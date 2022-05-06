using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabDeRepaso1_Parcial2_
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
 
        public static int CalcularEdad(Persona persona)
        {
            DateTime fecha = DateTime.Now;
            int edad;

            edad = fecha.Year - persona.FechaNacimiento.Year;
            return edad;
        }

    }
}