using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sporfe_1._0.Models
{
    public class Profesor
    {
        public Profesor(){
            Alumnos = new List<Alumno>();
            Cursos = new List<Curso>();
        }
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Edad { get; set; }
        
        public string correo { get; set; }
        public int AniosEsperiencia { get; set; }
        
        public Calificacion calificacion { get; set; }
        public string comentario { get; set; }
        public List<Curso> Cursos { get; set; }
        //public int CursoId { get; set; }
        
        public List<Alumno> Alumnos { get; set; }
        //public int AlumnoId { get; set; }
        

    }
}