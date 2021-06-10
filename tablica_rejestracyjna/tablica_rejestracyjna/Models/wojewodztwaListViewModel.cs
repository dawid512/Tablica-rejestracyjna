using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tablica_rejestracyjna.Data;

namespace tablica_rejestracyjna.Models
{
    public class wojewodztwaListViewModel
    {
        public IEnumerable<powiat> powiaty { get; set; }
        public string wojewodztwa { get; set; }
    }
}
