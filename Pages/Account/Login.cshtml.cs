using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; }

    [BindProperty]
    public string Password { get; set; }
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
            if (Email == "test@example.com" && Password == "Password123")
            {
                // Redirect to a secure area after successful login
                return RedirectToPage("/Dashboard");
            }else{
                ErrorMessage = "Invalid login attempt.";
                return Page();
                /*return RedirectToPage("/Index"); // Redirige al dashboard*/
            }

            
        }

        // Si hay errores, se vuelve a mostrar el formulario de inicio de sesión
        return Page();
    }
}
