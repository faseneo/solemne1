using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class EditUsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public EditUsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Usuario Usuario { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Usuario = await _context.Usuarios.FindAsync(id);
        if (Usuario == null)
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

        _context.Attach(Usuario).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("ListUs");
    }
}
