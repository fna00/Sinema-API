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
    [Authorize(Roles = "37,38")]
    [Route("api/[controller]")]
    [ApiController]
    public class SeansController : ControllerBase
    {
        public readonly Context _context;

        public SeansController(Context context)
        {
            this._context = context;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("SeansGetAll")]
        public async Task<List<Seans>> GetAll()
        {
            var s = await _context.Seanss.ToListAsync();
            return s;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("SeansGetId")]
        public Seans Get(int id)
        {
            return _context.Seanss.Where(i => i.SeansId == id).FirstOrDefault();
        }

        [Authorize(Roles = "37,38")]
        [HttpPost("SeansPost")]
        public Seans Post(Seans s)
        {
            _context.Seanss.Add(s);
            _context.SaveChanges();
            return s;
        }

        [Authorize(Roles = "37,38")]
        [HttpPut("SeansPut")]
        public Seans Put(Seans s)
        {
            _context.Seanss.Update(s);
            _context.SaveChanges();
            return s;
        }

        [Authorize(Roles = "37,38")]
        [HttpDelete("SeansDelete")]
        public Seans Delete(int id)
        {
            var sens = _context.Seanss.Where(i => i.SeansId == id).SingleOrDefault();
            if (sens != null)
            {
                _context.Seanss.Remove(sens);
                _context.SaveChanges();
            }
            return sens;
        }
    }
}
