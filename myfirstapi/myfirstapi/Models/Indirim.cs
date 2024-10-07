using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class Indirim
    {
        [Key] public int IndirimId { get; set; }
        public string Indirimad { get; set; }
        public string Indirimgun { get; set; }
        public Boolean Indirimiçecek { get; set; }
        public Boolean Indirimmisir { get; set; }
        [ForeignKey("SeansId")] public Seans Seanss { get; set; }
    }
}
