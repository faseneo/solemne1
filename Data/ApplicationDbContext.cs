using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Record> Records { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}

public class Record
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
public class Usuario
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}