using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string correo { get; set; }
        [Required]
        public string Contraseña { get; set; }
        
        public List<ProfesorAlumno> ProfesorAlumno  { get; set; }
                
  
    }
}