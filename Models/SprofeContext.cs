using Microsoft.EntityFrameworkCore;

namespace Sporfe_1._0.Models
{
    public class SprofeContext : DbContext
    {
        public SprofeContext(DbContextOptions<SprofeContext> options) 
        : base(options) {

        }

        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<ProfesorAlumno> ProfesorAlumno { get; set; }
        public DbSet<ProfesorCurso> ProfesorCurso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<ProfesorAlumno>().HasKey(pa => new {pa.IdProfesor, pa.IdAlumno});

            modelBuilder.Entity<ProfesorAlumno>().HasOne(pa => pa.Profesor).WithMany(p => p.ProfesorAlumno)
            .HasForeignKey(pa => pa.IdProfesor);

            modelBuilder.Entity<ProfesorAlumno>().HasOne(pa => pa.Alumno).WithMany(a => a.ProfesorAlumno)
            .HasForeignKey(pa => pa.IdAlumno);


            modelBuilder.Entity<ProfesorCurso>().HasKey(pc => new{pc.IdCurso, pc.IdProfesor});

            modelBuilder.Entity<ProfesorCurso>().HasOne(pc => pc.Profesor).WithMany(p => p.ProfesorCurso)
            .HasForeignKey(pc => pc.IdProfesor); 

            modelBuilder.Entity<ProfesorCurso>().HasOne(pc => pc.Curso).WithMany(c => c.ProfesorCurso)
            .HasForeignKey(pc => pc.IdCurso); 
            
        }
        







    }
}