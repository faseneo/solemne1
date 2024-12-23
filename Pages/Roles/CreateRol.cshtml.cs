using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class CreateRolModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public CreateRolModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Rol Rol { get; set; } = default!;

    public void OnGet()
    {
    }
    
    //Logica para agregar Rol
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Roles.Add(Rol);
        await _context.SaveChangesAsync();
        return RedirectToPage("ListRol");
    }
}
