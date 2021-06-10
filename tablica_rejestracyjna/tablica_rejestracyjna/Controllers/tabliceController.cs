using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PusherServer;
using tablica_rejestracyjna.Data;
using tablica_rejestracyjna.Models;



namespace tablica_rejestracyjna.Controllers
{
    public class tabliceController : Controller
    {
        private readonly tablicaContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _environment;

        public tabliceController(tablicaContext context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _environment = hostEnvironment;
        }

        // GET: tablice
        public async Task<IActionResult> Index()
        {

            

            return View(await _context.Komentarze.Include(t=>t.Tablice).OrderByDescending(x=>x.CommentDate).ToListAsync());
        }

        // GET: tablice/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id, string searchString)
        {


            if (!String.IsNullOrEmpty(searchString))
            {

                string alpha = searchString.ToUpper();
                //  Plates = Plates.Where(x => x.tablicaName.Contains(searchString));
                var tablice1 = await _context.Tablice.Include(X => X.UserID).Include(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                    .FirstOrDefaultAsync(m => m.tablicaName == searchString);
                if (tablice1 == null)
                {
                    tablice tab = new tablice();




                    
                    var builder = new StringBuilder();
                    string powiatletters;
                    bool isLetter2 = !String.IsNullOrEmpty(searchString) && Char.IsLetter(searchString[1]);
                    bool isLetter3 = !String.IsNullOrEmpty(searchString) && Char.IsLetter(searchString[2]);
                    if (isLetter3 == true)
                    {
                        powiatletters = searchString.Substring(0, 3);
                        char[] space = searchString.Substring(3, 1).ToCharArray();
                        bool spaceResult;
                        spaceResult =   Char.IsWhiteSpace(space[0]);
                        if (spaceResult == false)
                        {
                            alpha = powiatletters + ' ' + searchString.Substring(3);
                        }
                      
                       
                    }
                    else
                        if (isLetter2 == true)
                    {
                        powiatletters = searchString.Substring(0, 2);
                        char[] space = searchString.Substring(2, 1).ToCharArray();
                        bool spaceResult;
                        spaceResult = Char.IsWhiteSpace(space[0]);
                        if (spaceResult == false)
                        {
                            alpha = powiatletters + ' ' + searchString.Substring(2);
                        }
                        
                    }
                    else powiatletters = null;

                   


                    tab.tablicaName = alpha.ToUpper();
                    //var listaPowiaty = _context.Powiaty.ToList();

                    //  listaPowiaty.Where(x=>x.tab_letter.Equals(powiatletters)).FirstOrDefault().ListaTablice.Add(tab);


                    tab.powiat = _context.Powiaty.Where(x => x.tab_letter == powiatletters).FirstOrDefault();

                    if (ModelState.IsValid)
                    {
                        _context.Add(tab);
                        await _context.SaveChangesAsync();
                        //return RedirectToAction(nameof(Index));
                    }



                }
                else
                {
                    ViewBag.Komentarze = await _context.Komentarze.Include(K => K.Tablice).ThenInclude(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                    .Where(m => m.Tablice.tablicaName == tablice1.tablicaName).ToListAsync();

                    ViewBag.Tablice = tablice1;
                    return View(new Komentarze());


                }

                var tablice2 = await _context.Tablice.Include(X => X.UserID).Include(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                    .FirstOrDefaultAsync(m => m.tablicaName == alpha);
                ViewBag.Komentarze = await _context.Komentarze.Include(t => t.Tablice).ThenInclude(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                   .Where(m => m.Tablice.tablicaName == tablice2.tablicaName).ToListAsync();

                ViewBag.Tablice = tablice2;
                return View(new Komentarze());

            }
            else if (id != null)
            {


                //if (id == null)
                //{
                //    return NotFound();
                //}

                var tablice = await _context.Tablice.Include(X=>X.UserID).Include(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                    .FirstOrDefaultAsync(m => m.tablicaId == id);
                
                if (tablice == null)
                {
                    return NotFound();
                }
                ViewBag.Komentarze = await _context.Komentarze.Include(t => t.Tablice).ThenInclude(t => t.powiat).ThenInclude(t => t.wojewodztwoid)
                   .Where(m => m.Tablice.tablicaName == tablice.tablicaName).ToListAsync();
                ViewBag.Tablice = tablice;
                return View(new Komentarze());
            }
            else
            {
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public async Task<IActionResult> Details(int id, string name, string tresc_comment, List<IFormFile>? zdjecie)
        {
            if (zdjecie.Count == 0)
            {
                await _context.Komentarze.AddAsync(new Komentarze()
                {
                    Name = name,
                    tablicaID = id,
                    tresc_comment = tresc_comment

                });
                await _context.SaveChangesAsync();
            }
            else
            {
                string path = Path.Combine(_environment.WebRootPath, "photos");

                string pathToDatabase = @"/photos";
                foreach (var file in zdjecie)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    Guid guid = Guid.NewGuid();
                    string fileDirctory = Path.Combine(path, guid.ToString());
                    string OrginalFilePath = Path.Combine(path, guid.ToString(), fileName);
                    string pathToSave = Path.Combine(pathToDatabase, guid.ToString(), fileName);
                    Directory.CreateDirectory(fileDirctory);
                    using (FileStream stream = new(OrginalFilePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    await _context.Komentarze.AddAsync(new Komentarze()
                    {
                        Name = name,
                        tablicaID = id,
                        tresc_comment = tresc_comment,
                        zdjecie = pathToSave
                    });
                    await _context.SaveChangesAsync();

                }



            }





            return RedirectToAction(nameof(Details), new { id = id });
        }
       


        [HttpGet]
        public async Task<IActionResult> Ocena_tablice(int? ocen_w_gore, int? ocena_w_dol, int idX)
        {
            
           var tablica=   _context.Tablice.FirstOrDefault(x => x.tablicaId == idX);
            
            if (ocen_w_gore == null)
            {
                tablica.ocen_w_dol = tablica.ocen_w_dol + 1;
            }
            else { tablica.ocen_w_gore = tablica.ocen_w_gore + 1; }
            try
                {
                   
                    _context.Update(tablica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tabliceExists(tablica.tablicaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = idX });
        


        }



        // GET: tablice/Create
        public IActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int id, string name, string tresc_comment, List<IFormFile>? zdjecie)
        {
            if (zdjecie.Count == 0)
            {
                await _context.Komentarze.AddAsync(new Komentarze()
                {
                    Name = name,
                    tablicaID = id,
                    tresc_comment = tresc_comment

                });
                await _context.SaveChangesAsync();
            }
            else
            {
                string path = Path.Combine(_environment.WebRootPath, "photos");

                string pathToDatabase = @"/photos";
                foreach (var file in zdjecie)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    Guid guid = Guid.NewGuid();
                    string fileDirctory = Path.Combine(path, guid.ToString());
                    string OrginalFilePath = Path.Combine(path, guid.ToString(), fileName);
                    string pathToSave = Path.Combine(pathToDatabase, guid.ToString(), fileName);
                    Directory.CreateDirectory(fileDirctory);
                    using (FileStream stream = new(OrginalFilePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    await _context.Komentarze.AddAsync(new Komentarze()
                    {
                        Name = name,
                        tablicaID = id,
                        tresc_comment = tresc_comment,
                        zdjecie = pathToSave
                    });
                    await _context.SaveChangesAsync();

                }



            }





            return RedirectToAction(nameof(Index));
        }

        // POST: tablice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("tablicaName")] tablice tablice)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(tablice);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(tablice);
        //}

        // GET: tablice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablice = await _context.Tablice.FindAsync(id);
            if (tablice == null)
            {
                return NotFound();
            }
            return View(tablice);
        }

        // POST: tablice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tablicaId,tablicaName,ocen_w_gore,ocen_w_dol,Nazwa_pojazdu")] tablice tablice)
        {
            if (id != tablice.tablicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablice);
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
                return RedirectToAction(nameof(Index));
            }
            return View(tablice);
        }

        // GET: tablice/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var komentarze = await _context.Komentarze
        //        .FirstOrDefaultAsync(m => m.komentarzID == id);
        //    if (komentarze == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(komentarze);
        //}

        // POST: tablice/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id1)
        {
            var idTablicy = _context.Komentarze.FirstOrDefault(x => x.komentarzID == id1).tablicaID;
            var komentarze = await _context.Komentarze.FindAsync(id1);
            _context.Komentarze.Remove(komentarze);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new{ id = idTablicy } );
        }

        private bool tabliceExists(int id)
        {
            return _context.Komentarze.Any(e => e.komentarzID == id);
        }


        public IActionResult List(string wojewodztwa)
        {
            IEnumerable<powiat> powiaty;
            string currentwojewodztwa;

            if (string.IsNullOrEmpty(wojewodztwa))
            {
                powiaty = _context.Powiaty.OrderBy(p => p.powiatId);
                currentwojewodztwa = "Wszystkie wojewodztwa";
            }
            else
            {
                powiaty = _context.Powiaty.Where(p => p.wojewodztwoid.Name == wojewodztwa)
                    .OrderBy(p => p.powiatId);
                currentwojewodztwa = _context.Powiaty.FirstOrDefault(c => c.wojewodztwoid.Name == wojewodztwa)?.wojewodztwoid.Name;
            }

            return View(new wojewodztwaListViewModel
            {
                powiaty = powiaty,
                wojewodztwa = currentwojewodztwa
            });
        }



    }
}
