using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ureche_iudita_proiect.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        [Display(Name = "Denumire servicii")]
        public string denumire_serviciu { get; set; }
        
        public string Descriere { get; set; }

       // public ICollection<Banca> Banci { get; set; }
    }
}
