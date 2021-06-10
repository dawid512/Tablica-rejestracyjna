using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tablica_rejestracyjna.Data
{
    public class wojewodztwa
    {
        [Key]
        public int wojewodztwaID { get; set; }
        //[ForeignKey("tablicaId")]
       // public tablice tablicaID { get; set; }
        public List<powiat> ListaPowiat { get; set; }
        public string Name { get; set; }
        public string tab_letter { get; set; }
    }
}
