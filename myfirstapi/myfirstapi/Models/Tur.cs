using System.ComponentModel.DataAnnotations;

namespace myfirstapi.Models
{
    public class Tur
    {
        [Key] public int TurId { get; set; }
        public string Turad { get; set;}
    }
}