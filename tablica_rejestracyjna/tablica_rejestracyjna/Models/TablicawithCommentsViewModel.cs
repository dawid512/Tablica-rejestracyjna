using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Models
{
    public class TablicawithCommentsViewModel 
    {
      public  tablice tablices { get; set; }
        public powiat powiat { get; set; }
        public wojewodztwa wojewodztwa { get; set; }
        public Komentarze Komentarze { get; set; }
    }
}
