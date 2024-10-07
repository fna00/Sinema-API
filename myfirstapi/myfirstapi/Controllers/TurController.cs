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
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace myfirstapi.Controllers
{
    [Authorize(Roles = "37,38")]
    [Route("api/[controller]")]
    [ApiController]
    public class TurController : ControllerBase
    {
        public readonly Context _context;

        public TurController(Context context)
        {
            this._context = context;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("TurGetAll")]
        public async Task<List<Tur>> GetAll()
        {
            /*.Select(t => new Tur(){TurId = t.TurId,Turad = t.Turad,}).*/
            var t = await _context.Turs.ToListAsync();
            return t;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("TurGetId")]
        public Tur Get(int id)
        {
            return _context.Turs.Where(i => i.TurId == id).FirstOrDefault();
        }

        [Authorize(Roles = "37,38")]
        [HttpPost("TurPost")]
        public Tur Post(Tur t)
        {
            _context.Turs.Add(t);
            _context.SaveChanges();
            return t;
        }

        [Authorize(Roles = "37,38")]
        [HttpPut("TurPut")]
        public Tur Put(Tur t)
        {
            _context.Turs.Update(t);
            _context.SaveChanges();
            return t;
        }

        [Authorize(Roles = "37,38")]
        [HttpDelete("TurDelete")]
        public Tur Delete(int id)
        {
            var tur = _context.Turs.Where(i => i.TurId == id).SingleOrDefault();
            if (tur != null)
            {
                _context.Turs.Remove(tur);
                _context.SaveChanges();
            }
            return tur;
        }
    }
}
