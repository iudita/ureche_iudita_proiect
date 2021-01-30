using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ureche_iudita_proiect.Models
{
    public class Banca
    {
        public int ID { get; set; }
        [Display(Name = "Nume banci")]
        public string nume { get; set; }
        [Display(Name = "Detalii contact")]
        public string contact { get; set; }
        public int ServiciuID { get; set; }
        public Serviciu Serviciu { get; set; }




    }
}
