using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public EditModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Record Record { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Record = await _context.Records.FindAsync(id);
        if (Record == null)
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

        _context.Attach(Record).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToPage("List");
    }
}
