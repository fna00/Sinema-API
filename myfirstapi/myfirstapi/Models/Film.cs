using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public string Filmad { get; set; }
        public string Filmsüre { get; set; }
        public DateTime Filmvizyontarihi { get; set; }
        public Boolean Filmvizyondurumu { get; set; }
        //public int TurId { get; set; }
        [ForeignKey("TurId")] public virtual Tur Turs { get; set; }
        //public int YonetmenId { get; set; }
        [ForeignKey("YonetmenId")] public virtual Yonetmen Yonetmens { get; set; }
    }
}
