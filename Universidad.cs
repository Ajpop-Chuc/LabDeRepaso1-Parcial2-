using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LabDeRepaso1_Parcial2_
{
    public class Universidad
    {
        public string Nombre { get; set; }
        private List<Alumnos> listaAlumnos = new List<Alumnos>();
        private List<Docentes> listaDocentes = new List<Docentes>();
        private List<PersonalAdministrativo> listaPersonalAdmin = new List<PersonalAdministrativo>();

        public static List<Universidad> listaDatosU = new List<Universidad>();

        public List<Alumnos> ListaAlumnos { get => listaAlumnos; set => listaAlumnos = value; }
        public List<Docentes> ListaDocentes { get => listaDocentes; set => listaDocentes = value; }
        public List<PersonalAdministrativo> ListaPersonalAdmin { get => listaPersonalAdmin; set => listaPersonalAdmin = value; }

        public static void guardarenJson(string archivo)
        {
            string json = JsonConvert.SerializeObject(listaDatosU);
            System.IO.File.WriteAllText(archivo, json);
        }
        public static void leerJson(string archivo)
        {
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            listaDatosU = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }
    }
}