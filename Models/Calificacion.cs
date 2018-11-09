using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sporfe_1._0.Models
{
    public class Calificacion
    {
        [Key]
        public int IdCalificacion { get; set; }
        public int promcalificacion { get; set; }
        public int ensenanza { get; set; }
        public int evaluacion { get; set; }
        public int buenaGente { get; set; }
    }
}