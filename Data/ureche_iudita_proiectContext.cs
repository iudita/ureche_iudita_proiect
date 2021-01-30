using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_proiect.Models;

namespace ureche_iudita_proiect.Data
{
    public class ureche_iudita_proiectContext : DbContext
    {
        public ureche_iudita_proiectContext (DbContextOptions<ureche_iudita_proiectContext> options)
            : base(options)
        {
        }

        public DbSet<ureche_iudita_proiect.Models.Banca> Banca { get; set; }

        public DbSet<ureche_iudita_proiect.Models.Serviciu> Serviciu { get; set; }

        public DbSet<ureche_iudita_proiect.Models.Client> Client { get; set; }
    }
}
