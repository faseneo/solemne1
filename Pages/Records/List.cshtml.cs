using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class ListModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ListModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Record> Records { get; set; } = new List<Record>();

    public async Task OnGetAsync()
    {
        Records = await _context.Records.ToListAsync(); // Carga los registros desde la base de datos
    }

    public async Task<IActionResult> OnGetDeleteAsync(int id)
    {
        var record = await _context.Records.FindAsync(id);
        if (record != null)
        {
            _context.Records.Remove(record);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }

    
}
