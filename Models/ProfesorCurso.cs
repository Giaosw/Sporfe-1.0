namespace Sporfe_1._0.Models
{
    public class ProfesorCurso
    {
        
        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }
        
        public int IdCurso { get; set; }    
        public Curso Curso { get; set; }
    }
}