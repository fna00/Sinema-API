using Microsoft.AspNetCore.Mvc;
using myfirstapi.Models;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Collections;
using System.Data.Entity;


namespace myfirstapi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        private readonly Context _context;

        public RolController(Context context)
        {
            this._context = context;
        }

        [HttpGet("UserGetAll")]
        public async Task<ActionResult<List<Rol>>> UserGet()
        {
            try
            {
                List<Rol> users = _context.Rols.ToList();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet("RolGetAll")]
        //public async Task<List<Rol>> GetAll()
        //{
        //    var t = await _context.Rols.ToListAsync();
        //    return t;
        //}


        [HttpGet("RolGetId")]
        public Rol GetById(int id)
        {
            return _context.Rols.Where(i => i.RolId == id).FirstOrDefault();
        }

        
        [HttpPost("RolPost")]
        public Rol Post(Rol rol)
        {
            _context.Rols.Add(rol);
            _context.SaveChanges();
            return rol;
        }

        
        [HttpPut("RolPut")]
        public Rol Put(Rol r)
        {
            _context.Rols.Update(r);
            _context.SaveChanges();
            return r;
        }

        
        [HttpDelete("RolDelete")]
        public Rol Delete(int id)
        {
            var rol = _context.Rols.Where(i => i.RolId == id).SingleOrDefault();
            if (rol != null)
            {
                _context.Rols.Remove(rol);
                _context.SaveChanges();
            }
            return rol;
        }
    }
}

//--------------------------------------------------------------------

//[HttpPut("RolPut")]
//public IActionResult Put(int id, Rol r)
//{
//    Rol rol = _context.Rols.Where(x => x.RolId == r.RolId).SingleOrDefault();
//    _context.Entry(rol).CurrentValues.SetValues(r);
//    _context.SaveChanges();
//    return Ok();
//}

//--------------------------------------------------------------------

//[HttpGet("GetId")]
//public ActionResult Get(int id)
//{
//    return Ok(_context.Rols.Where(i => i.RolId == id));
//}

//--------------------------------------------------------------------

//[HttpGet("GetAll")]
//public IEnumerable GetAll()
//{
//    return _context.Rols.ToList();
//}

//--------------------------------------------------------------------

//[HttpGet("GetAll")]
//public ActionResult GetAll()
//{
//    return Ok(_context.Rols.ToList());
//}