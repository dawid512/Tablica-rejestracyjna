using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Areas.Identity.Pages.Account.Manage
{
    public class TabliceUserListPageModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly tablicaContext _context;

        public TabliceUserListPageModel(tablicaContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public IList<tablice> tablice1 { get; set; }
        [BindProperty]
        public tablice tablice { get; set; }

        public async Task OnGetAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            tablice1 = await _context.Tablice.Where(x => x.UserID == user).Include(x => x.powiat).ThenInclude(w => w.wojewodztwoid).ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            var tablica1 = _context.Tablice.Where(t=>t.UserID==null).FirstOrDefault(x => x.tablicaName == tablice.tablicaName);

            if (tablica1 == null)
            {
                //return  new HttpResponseMessage(HttpStatusCode.OK);
                return NotFound();

            }
          
           

            try
            {
                tablica1.UserID = user;
                _context.Update(tablica1);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tabliceExists(tablica1.tablicaId))
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
