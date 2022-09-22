using Academia_De_Idiomas.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia_De_Idiomas.Context
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Idiomas> Idiomas { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Modalidad> Modalidad { get; set; }
    }
}
