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
    public class YonetmenController : ControllerBase
    {
        public readonly Context _context; 

        public YonetmenController(Context context) 
        {
            this._context = context;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("YonetmenGetAll")]
        public async Task<List<Yonetmen>> GetAll()
        {
            /*.Select(t => new Tur(){TurId = t.TurId,Turad = t.Turad,}).*/
            var y = await _context.Yonetmens.ToListAsync();
            return y;
        }
        //[HttpGet("YonetmenGetAll")]
        //public IEnumerable GetAll()
        //{
        //    return _context.Yonetmens.ToList();
        //}

        [Authorize(Roles = "37,38")]
        [HttpGet("YonetmenGetId")]
        public Yonetmen Get(int id)
        {
            return _context.Yonetmens.Where(i => i.YonetmenId == id).FirstOrDefault();
        }

        [Authorize(Roles = "37,38")]
        [HttpPost("YonetmenPost")]
        public Yonetmen Post(Yonetmen yonetmen)
        {
            _context.Yonetmens.Add(yonetmen);
            _context.SaveChanges();
            return yonetmen;
        }

        [Authorize(Roles = "37,38")]
        [HttpPut("YonetmenPut")]
        public Yonetmen Put(Yonetmen y)
        {
            _context.Yonetmens.Update(y);
            _context.SaveChanges();
            return y;
        }

        [Authorize(Roles = "37,38")]
        [HttpDelete("YonetmenDelete")]
        public Yonetmen Delete(int id)
        {
            var ynt = _context.Yonetmens.Where(i => i.YonetmenId == id).SingleOrDefault();
            if (ynt != null)
            {
                _context.Yonetmens.Remove(ynt);
                _context.SaveChanges();
            }
            return ynt;
        }
    }
}
