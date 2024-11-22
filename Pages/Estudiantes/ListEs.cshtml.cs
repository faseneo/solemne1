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
    //Crea lista de objetos de tipo Estudiante 
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

     //Logica para cargar listado de estudiantes desde la base de datos
    public async Task OnGetAsync()
    {
        Estudiantes = await _context.Estudiantes.ToListAsync(); 
    }

    //Logica para eliminar Estudiante 
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