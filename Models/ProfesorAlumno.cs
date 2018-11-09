namespace Sporfe_1._0.Models
{
    public class ProfesorAlumno
    {
        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }
        public int IdAlumno { get; set; }  
        public Alumno Alumno { get; set; }
              
    }
}