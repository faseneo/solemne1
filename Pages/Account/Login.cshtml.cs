using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public void OnGet()
    {
        // Lógica para mostrar la página de inicio de sesión.
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            // logica para inicio de sesión
            return RedirectToPage("/Dashboard"); // Redirige al dashboard
        }

        // Si hay errores, se vuelve a mostrar el formulario de inicio de sesión
        return Page();
    }
}
