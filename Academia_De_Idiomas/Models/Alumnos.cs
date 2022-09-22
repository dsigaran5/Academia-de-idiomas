using System.ComponentModel.DataAnnotations;

namespace Academia_De_Idiomas.Models
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string NomAlum { get; set; }
        public string ApeAlum { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contraseña { get; set; }
        public Modalidad CodModalidad { get; set; }
        public Idiomas CodIdioma { get; set; }
        public Profesores IdProfe { get; set; }
    }
}
