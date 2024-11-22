using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Declaracion de tablas Usuario, Estudiantes y Rol
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Estudiante> Estudiantes { get; set; } = null!;
    public DbSet<Rol> Roles { get; set; } = null!;
}

// Declaracion de clase usuario
public class Usuario
    {
        public int Id { get; set; }
        public  string Nombre { get; set; }  = string.Empty;
        public  string Apellido { get; set; }  = string.Empty;
        public  string Email { get; set; }  = string.Empty;
        public  string Password { get; set; }  = string.Empty;
        public  string Rol { get; set; }  = string.Empty; // Valor: "Profesor" o "Jefe Carrera"
    }

// Declaracion de clase Estudiante
public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  = string.Empty;
        public string Apellido { get; set; }  = string.Empty;
        public string Email { get; set; }  = string.Empty;
        public int Edad { get; set; }
    }

// Declaracion de clase Rol
    public class Rol
    {
        public int Id { get; set; }
        public string NombreRol { get; set; }  = string.Empty;
    }
