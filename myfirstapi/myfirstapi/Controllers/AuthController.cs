using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myfirstapi.Models;
using System.Collections;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using myfirstapi.Migrations;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Data;
//using System.Data.Entity;

namespace myfirstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly Context _context;
        public AuthController(Context context)
        {
            this._context = context;
        }

        [Produces("application/json")]
        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<string> Login(string ad, string sifre)
        {

            var t = await _context.Kullanicis.Where(i => i.Kullaniciad == ad && i.Kullanicisifre == sifre).FirstOrDefaultAsync();

            Claim claim1 = new Claim("name", t.Kullaniciad.ToString());
            Claim claim2 = new Claim("role", t.RolId.ToString());
            Claim[] additionalClaims = new Claim[]
            {
                claim1,
                claim2
            };

            var bytes = Encoding.UTF8.GetBytes("bunagöresifrele");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "http://localhost:7168/",
                audience: "http://localhost:7168/",
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials,
                claims: additionalClaims
            );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);
        }

        //[HttpGet("[action]")]
        //[Authorize(Roles = "37")]
        //public IActionResult Test2()
        //{
        //    return Ok("Token Başarılı Şekilde Oluşturuldu");
        //}

        //------------------------------------------------------------

        //[AllowAnonymous]
        //[HttpGet("login")]
        //public async Task<string> login(string kullaniciAdi, string sifre)
        //{
        //    var t = await _context.Kullanicis.Where(i => i.Kullaniciad == kullaniciAdi && i.Kullanicisifre == sifre).FirstOrDefaultAsync();

        //    if (t == null)
        //    {
        //        Console.WriteLine("YANLIŞ GİRİŞ");
        //    }

        //    var rol = t.RolId.ToString();
        //    Claim claim1 = new Claim("name", t.Kullaniciad.ToString());
        //    Claim claim2 = new Claim("role", t.RolId.ToString());
        //    Claim[] additionalClaims = new Claim[]
        //    {
        //        claim1,
        //        claim2
        //    };
        //    var token = JwtHelper.GetJwtToken(
        //        t.Kullaniciad,
        //        rol,
        //        "signingkey123",
        //        "issuerdeğeri",
        //        "audiencedeğeri",
        //        TimeSpan.FromHours(1),
        //        additionalClaims);
        //    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        //    return handler.WriteToken(token);
        //}

        //------------------------------------------------------------

        //[HttpGet("login")]
        //public async Task<string> login(string kullaniciAdi, string sifre)
        //{
        //    var t = await _context.Kullanicis.Where(i => i.Kullaniciad == kullaniciAdi && i.Kullanicisifre == sifre).FirstOrDefaultAsync();
        //    var rol = t.RolId.ToString();
        //    Claim claim1 = new Claim("name", t.Kullaniciad.ToString());
        //    Claim claim2 = new Claim("role", t.RolId.ToString());
        //    Claim[] additionalClaims = new Claim[]
        //    {
        //        claim1,
        //        claim2
        //    };
        //    var token = JwtHelper.GetJwtToken(TimeSpan.FromMinutes(45), additionalClaims);
        //    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        //    return handler.WriteToken(token);
        //}

        //------------------------------------------------------------

        //[AllowAnonymous]
        //[HttpGet("login")]
        //public async Task<string> login(string kullaniciAdi, string sifre)
        //{
        //    var t = await _context.Kullanicis.Where(i => i.Kullaniciad == kullaniciAdi && i.Kullanicisifre == sifre).FirstOrDefaultAsync();
        //    var rol = t.RolId.ToString();
        //    Claim claim1 = null;
        //    Claim claim2 = null;

        //    if (t != null)
        //    {
        //        claim1 = new Claim("name", t.Kullaniciad.ToString());
        //        claim2 = new Claim("role", t.RolId.ToString());
        //    }

        //    Claim[] additionalClaims;

        //    if (claim1 != null && claim2 != null)
        //    {
        //        additionalClaims = new Claim[]
        //        {
        //            claim1,
        //            claim2
        //        };
        //    }
        //    else
        //    {
        //        additionalClaims = new Claim[] { };
        //    }
        //    var token = JwtHelper.GetJwtToken(t.Kullaniciad, rol, additionalClaims);
        //    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        //    return handler.WriteToken(token);
        //}
    }
}
