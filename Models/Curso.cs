using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Curso
    {
        
        [Key]
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        [NotMapped]
        public List<ProfesorCurso> ProfesorCurso { get; set; }
        
        public List<Profesor> Profesores { get; set; }
    }
}