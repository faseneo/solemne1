using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //public DbSet<Record> Records { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Rol> Roles { get; set; }
}

/*public class Record
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
*/

public class Usuario
    {
        public int Id { get; set; }
        public  string Nombre { get; set; } 
        public  string Apellido { get; set; } 
        public  string Email { get; set; }
        public  string Password { get; set; }
        public  string Rol { get; set; } // Valor: "Profesor" o "Jefe Carrera"
    }

public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string NombreRol { get; set; }
    }
