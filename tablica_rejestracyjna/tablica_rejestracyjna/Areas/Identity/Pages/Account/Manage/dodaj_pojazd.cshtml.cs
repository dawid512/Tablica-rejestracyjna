using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Areas.Identity.Pages.Account.Manage
{
    public class dodaj_pojazdModel : PageModel
    {
        private readonly tablica_rejestracyjna.Data.tablicaContext _context;

        public dodaj_pojazdModel(tablica_rejestracyjna.Data.tablicaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
               
                return Page();
            }
            var tablica = await _context.Tablice.FirstOrDefaultAsync(m => m.tablicaId == id);
            tablica.Nazwa_pojazdu = tablice.Nazwa_pojazdu;
            _context.Update(tablica);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tabliceExists(tablice.tablicaId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./TabliceUserListPage");
        }

        private bool tabliceExists(int id)
        {
            return _context.Tablice.Any(e => e.tablicaId == id);
        }
    }
}
