using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Alumno
    {
        public Alumno()
        {
            Profesores = new List<Profesor>();
        }
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string correo { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [NotMapped]
        public List<Profesor> Profesores  { get; set; }
                
        //public int ProfesorId  { get; set; }

    }
}