using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class ListEsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ListEsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public async Task OnGetAsync()
    {
        Estudiantes = await _context.Estudiantes.ToListAsync(); // Carga los registros desde la base de datos
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var estudiante = await _context.Estudiantes.FindAsync(id);
        if (estudiante != null)
        {
            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }    
}