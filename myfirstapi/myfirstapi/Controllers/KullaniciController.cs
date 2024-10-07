using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using myfirstapi.Models;
using System.Collections;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks.Dataflow;

namespace myfirstapi.Controllers
{
    [Authorize(Roles = "37,12")]
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        private readonly Context _context;

        public KullaniciController(Context context)
        {
            this._context = context;
        }

        [Authorize(Roles = "37,12")]
        [HttpGet("KullaniciGetAll")]
        public async Task<List<Kullanici>> GetAll()
        {
            var t = await _context.Kullanicis.ToListAsync();
            return t;
        }

        [Authorize(Roles = "37,12")]
        [HttpGet("KullaniciGetId")]
        public Kullanici GetById(int id)
        {
            return _context.Kullanicis.Where(i => i.KullaniciId == id).FirstOrDefault();
        }

        [Authorize(Roles = "37,12")]
        [HttpPost("KullaniciPost")]
        public Kullanici Post(Kullanici k)
        {
            _context.Kullanicis.Add(k);
            _context.SaveChanges();
            return k;
        }

        [Authorize(Roles = "37,12")]
        [HttpPut("KullaniciPut")]
        public Kullanici Put(Kullanici k)
        {
            _context.Kullanicis.Update(k);
            _context.SaveChanges();
            return k;
        }

        [Authorize(Roles = "37,12")]
        [HttpDelete("KullaniciDelete")]
        public Kullanici Delete(int id)
        {
            var kullanici = _context.Kullanicis.Where(i => i.KullaniciId == id).SingleOrDefault();
            if (kullanici != null)
            {
                _context.Kullanicis.Remove(kullanici);
                _context.SaveChanges();
            }
            return kullanici;
        }

        //[HttpGet("GetByUserName")]
        //public  Kullanici GetByUserName(string id)
        //{
        //    return _context.Kullanicis.Where(i => i.KullaniciTC == id).FirstOrDefault();
        //}
    }
}


//[HttpGet("GetAll")]
//public ActionResult GetAll()
//{
//    return Ok(_context.Kullanicis.ToList());
//}