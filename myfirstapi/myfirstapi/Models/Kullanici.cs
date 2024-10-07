using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfirstapi.Models
{
    public class Kullanici
    {
        [Key] public int KullaniciId { get; set; }
        public string Kullaniciad { get; set; }
        public string Kullanicisoyad { get; set; }
        public string Kullanicisifre { get; set; }
        public string KullaniciTC { get; set; }
        public string Kullanicitelefon { get; set; }
        public string Kullanicimail { get; set; }
        public string Kullaniciadres { get; set; }
        public bool Kullanicicinsiyet { get; set; }
        public string Kullanicid_tarihi { get; set; }
        public int RolId { get; set; }
        //[ForeignKey("RolId")] public virtual Rol Rols { get; set; }
    }
}