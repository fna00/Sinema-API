using myfirstapi.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class Bilet
    {
        [Key]
        public int BiletId { get; set; }
        public int SeansId { get; set; }
        //[ForeignKey("SeansId")]public virtual Seans Seanss { get; set; }
        public int KullaniciId { get; set; }
        //[ForeignKey("KullaniciId")] public virtual Kullanici Kullanicis { get; set; }
    }
}
