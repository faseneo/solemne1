using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class EditEsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public EditEsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Estudiante Estudiante { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Estudiante = await _context.Estudiantes.FindAsync(id);
        if (Estudiante == null)
        {
            return NotFound();
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Estudiante).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("List");
    }
}
