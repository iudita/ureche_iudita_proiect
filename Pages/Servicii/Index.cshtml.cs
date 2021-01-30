using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_proiect.Data;
using ureche_iudita_proiect.Models;

namespace ureche_iudita_proiect.Pages.Servicii
{
    public class IndexModel : PageModel
    {
        private readonly ureche_iudita_proiect.Data.ureche_iudita_proiectContext _context;

        public IndexModel(ureche_iudita_proiect.Data.ureche_iudita_proiectContext context)
        {
            _context = context;
        }

        public IList<Serviciu> Serviciu { get;set; }

        public async Task OnGetAsync()
        {
            Serviciu = await _context.Serviciu.ToListAsync();
        }
    }
}
