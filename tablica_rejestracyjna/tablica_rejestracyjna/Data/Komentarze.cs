using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tablica_rejestracyjna.Data
{
    public class Komentarze
    {
        [Key]
        public int komentarzID { get; set; }
        //[ForeignKey("tablicaId")]
        public int tablicaID { get; set; }
        public string tresc_comment { get; set; }
        public int ocena_komentarza { get; set; } = 0;
        public string zdjecie { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.Now;
        public string Name { get; set; }

        public virtual tablice Tablice{get; set;}
        //public string Name { get; set; }

        //[Column(TypeName = "ntext")]
        //public string Body { get; set; }


    }
}
