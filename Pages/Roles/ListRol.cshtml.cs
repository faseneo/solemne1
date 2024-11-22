using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class ListRolModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ListRolModel(ApplicationDbContext context)
    {
        _context = context;
    }

    //Crea lista de objetos de tipo Rol 
    public List<Rol> Roles { get; set; } = new List<Rol>();

    //Logica para cargar listado de estudiantes desde la base de datos
    public async Task OnGetAsync()
    {
        Roles = await _context.Roles.ToListAsync(); // Carga los registros desde la base de datos
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var rol = await _context.Roles.FindAsync(id);
        if (rol != null)
        {
            _context.Roles.Remove(rol);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }

    
}
