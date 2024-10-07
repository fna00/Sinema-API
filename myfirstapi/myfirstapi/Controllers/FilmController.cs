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
    public class FilmController : ControllerBase
    {
        public readonly Context _context;

        public FilmController(Context context) 
        {
            this._context = context;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("FilmGetAll")]
        public async Task<List<Film>> GetAll()
        {
            var f = await _context.Films.ToListAsync();
            return f;
        }

        [Authorize(Roles = "37,38")]
        [HttpGet("FilmGetId")]
        public Film Get(int id)
        {
            var flm = _context.Films.Where(i => i.FilmId == id).SingleOrDefault();
            return flm;
        }

        [Authorize(Roles = "37,38")]
        [HttpPost("FilmPost")]
        public Film Post([FromBody] Film film)
        {
            _context.Films.Add(film);
            _context.SaveChanges();
            return film;
        }

        [Authorize(Roles = "37,38")]
        [HttpPut("FilmPut")]
        public Film Put(Film f)
        {
            _context.Films.Update(f);
            _context.SaveChanges();
            return f;
        }

        [Authorize(Roles = "37,38")]
        [HttpDelete("FilmDelete")]
        public Film Delete(int id)
        {
            var flm = _context.Films.Where(i => i.FilmId == id).SingleOrDefault();
            if (flm != null)
            {
                _context.Films.Remove(flm);
                _context.SaveChanges();
            }
            return flm;
        }

    }
}
