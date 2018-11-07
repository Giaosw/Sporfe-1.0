using Microsoft.EntityFrameworkCore;

namespace Sporfe_1._0.Models
{
    public class SprofeContext : DbContext
    {
        public SprofeContext(DbContextOptions<SprofeContext> options) 
        : base(options) {

        }

        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }

    }
}