using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablica_rejestracyjna.Data
{
    public class tablice
    {
        [Key]
        public int tablicaId { get; set; }
        //[ForeignKey("UserId")]
        public virtual ApplicationUser UserID { get; set; }
        public string tablicaName { get; set; }
        public int ocen_w_gore { get; set; }
        public int ocen_w_dol { get; set; }
        public virtual IEnumerable<Komentarze> Komentarze { get; set; }
        public powiat powiat { get; set; }
        public string Nazwa_pojazdu { get; set; }

        //[Column(TypeName = "ntext")]
        //public string Body { get; set; }

    }
}
