using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class BiletFiyat
    {
        [Key] public int BiletFiyatId { get; set; }
        public string Bilettur{ get; set; }
        public Double Biletfiyat { get; set; }
        [ForeignKey("IndirimId")] public Indirim Indirims { get; set; }
    }
}
