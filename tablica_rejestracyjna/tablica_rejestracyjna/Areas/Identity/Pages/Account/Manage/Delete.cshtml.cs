using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Areas.Identity.Pages.Account.Manage
{
    public class DeleteModel : PageModel
    {
        private readonly tablica_rejestracyjna.Data.tablicaContext _context;

        public DeleteModel(tablica_rejestracyjna.Data.tablicaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public tablice tablice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            tablice = await _context.Tablice.FirstOrDefaultAsync(m => m.tablicaId == id);

            if (tablice == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            tablice = await _context.Tablice.Include(x=>x.UserID).FirstOrDefaultAsync(x=>x.tablicaId==id);
            tablice.UserID = null;

            if (tablice != null)
            {
                _context.Tablice.Update(tablice);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./TabliceUserListPage");
        }
    }
}
