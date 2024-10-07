using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class Seans
    {
        [Key]
        public int SeansId { get; set; }
        public int FilmId { get; set; }
        //[ForeignKey("FilmId")]public Film Films { get; set; }
        public string Seanssaat { get; set; }
    }
}
