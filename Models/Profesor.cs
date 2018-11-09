using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Edad { get; set; }
        
        public string correo { get; set; }
        public int AniosExperiencia { get; set; }
        
        public Calificacion calificacion { get; set; }
        public string comentario { get; set; }
        public List<ProfesorCurso> ProfesorCurso { get; set; }
        //public int CursoId { get; set; }
        
        public List<ProfesorAlumno> ProfesorAlumno { get; set; }
        //public int AlumnoId { get; set; }
        

    }
}