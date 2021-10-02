using Microsoft.EntityFrameworkCore;
using Mintic.App.Dominio;

namespace Mintic.App.Persistencia.AppRepositories
{
    public class Conexion: DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Rol> Roles {get; set;}
        public DbSet<Grupo> Grupos {get; set;}
        public DbSet<Nota> Notas {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder conn){
            if(!conn.IsConfigured){
                conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = MisionTic");
            }
        }
        
    }
}