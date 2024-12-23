using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class EditRolModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public EditRolModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Rol Rol { get; set; } = default!;

    //Logica para buscar Roles
    public async Task<IActionResult> OnGetAsync(int id)
    {
        Rol = await _context.Roles.FindAsync(id);
        if (Rol == null)
        {
            return NotFound();
        }
        return Page();
    }

    //Logica para grabar datos modificados del Rol
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Rol).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("ListRol");
    }
}
