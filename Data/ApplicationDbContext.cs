using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    //public DbSet<Record> Records { get; set; }
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Estudiante> Estudiantes { get; set; } = null!;
    public DbSet<Rol> Roles { get; set; } = null!;
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
        public  string Nombre { get; set; }  = string.Empty;
        public  string Apellido { get; set; }  = string.Empty;
        public  string Email { get; set; }  = string.Empty;
        public  string Password { get; set; }  = string.Empty;
        public  string Rol { get; set; }  = string.Empty; // Valor: "Profesor" o "Jefe Carrera"
    }

public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  = string.Empty;
        public string Apellido { get; set; }  = string.Empty;
        public string Email { get; set; }  = string.Empty;
        public int Edad { get; set; }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string NombreRol { get; set; }  = string.Empty;
    }
