using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class CreateEsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateEsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Estudiante Estudiante { get; set; } = default!;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Estudiantes.Add(Estudiante);
        await _context.SaveChangesAsync();
        return RedirectToPage("ListEs");
    }
}
