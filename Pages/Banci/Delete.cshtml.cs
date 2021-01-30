using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_proiect.Data;
using ureche_iudita_proiect.Models;

namespace ureche_iudita_proiect.Pages.Banci
{
    public class DeleteModel : PageModel
    {
        private readonly ureche_iudita_proiect.Data.ureche_iudita_proiectContext _context;

        public DeleteModel(ureche_iudita_proiect.Data.ureche_iudita_proiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Banca Banca { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Banca = await _context.Banca.FirstOrDefaultAsync(m => m.ID == id);

            if (Banca == null)
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

            Banca = await _context.Banca.FindAsync(id);

            if (Banca != null)
            {
                _context.Banca.Remove(Banca);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
