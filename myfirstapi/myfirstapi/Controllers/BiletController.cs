using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myfirstapi.Models;
using System.Collections;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace myfirstapi.Controllers
{
    [Authorize(Roles = "39,5")]
    [Route("api/[controller]")]
    [ApiController]
    public class BiletController : ControllerBase
    {
        public readonly Context _context;

        public BiletController(Context context)
        {
            this._context = context;
        }

        [Authorize(Roles = "39")]
        [HttpGet("BiletGetAll")]
        public async Task<List<Bilet>> GetAll()
        {
            var b = await _context.Bilets.ToListAsync();
            return b;
        }

        [Authorize(Roles = "37,39")]
        [HttpGet("BiletGetId")]
        public Bilet Get(int id)
        {
            return _context.Bilets.Where(i => i.BiletId == id).FirstOrDefault();
        }

        //[Authorize(Roles = "37,39,5")]
        [Authorize(Roles = "39,5")]
        [HttpPost("BiletPost")]
        public Bilet Post(Bilet b)
        {
            _context.Bilets.Add(b);
            _context.SaveChanges();
            return b;
        }

        [Authorize(Roles = "39")]
        [HttpPut("BiletPut")]
        public Bilet Put(Bilet b)
        {
            _context.Bilets.Update(b);
            _context.SaveChanges();
            return b;
        }

        [Authorize(Roles = "39")]
        [HttpDelete("BiletDelete")]
        public Bilet Delete(int id)
        {
            var blt = _context.Bilets.Where(i => i.BiletId == id).SingleOrDefault();
            if (blt != null)
            {
                _context.Bilets.Remove(blt);
                _context.SaveChanges();
            }
            return blt;
        }
    }
}
