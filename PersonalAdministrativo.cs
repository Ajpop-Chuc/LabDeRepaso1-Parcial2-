using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabDeRepaso1_Parcial2_
{
    public class PersonalAdministrativo:Persona
    {
        public string noIgss { get; set; }
        public string Profesion { get; set; }
        public DateTime FechaInicioLabores { get; set; }
        public DateTime FechaFinLabores { get; set; }
    }
}