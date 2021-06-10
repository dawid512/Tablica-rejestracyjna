using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tablica_rejestracyjna.Data
{
    public class powiat
    {
        [Key]
        public int powiatId { get; set; }
        //[ForeignKey("wojewodztwaID")]
        public wojewodztwa wojewodztwoid { get; set; }
        public List<tablice> ListaTablice { get; set; }
        
        public string Name { get; set; }
        public string tab_letter { get; set; }
    }
}
