using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class ListUsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ListUsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public async Task OnGetAsync()
    {
        Usuarios = await _context.Usuarios.ToListAsync(); // Carga los registros desde la base de datos
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }    
}
