using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Curso
    {
        
        public Curso(){
            Profesores = new List<Profesor>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        [NotMapped]
        public List<Profesor> Profesores { get; set; }
        
    }
}