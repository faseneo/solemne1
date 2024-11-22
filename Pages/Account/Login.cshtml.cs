using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Password { get; set; }
    [BindProperty]
    public string ErrorMessage { get; private set; }

    public void OnGet()
    {
        // Lógica para mostrar la página de inicio de sesión.
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            // logica para inicio de sesión
            if (Email == "test@example.com" && Password == "pass123")
            {
                // Redirecciona al Dashboard despues del Login
                return RedirectToPage("/Dashboard");
            }else{
                ErrorMessage = "Inicio de sesion no Valido";
                return Page();
            }
        }
        // Si hay errores, se vuelve a mostrar el formulario de inicio de sesión
        return Page();
    }
}
