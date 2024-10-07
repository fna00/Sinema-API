using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;
using myfirstapi.Controllers;
using myfirstapi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace myfirstapi
{
    public class JwtHelper
    {
        //public static JwtSecurityToken GetJwtToken(
        //    //parametrelerim
        //    string username,
        //    string rol,
        //    string signingKey,
        //    string issuer,
        //    string audience,
        //    TimeSpan expiration,
        //    Claim[] additionalClaims = null)
        //{
        //    var claims = new[]
        //    {

        //        new Claim(JwtRegisteredClaimNames.Sub,username),
        //        //benzersiz olamsı içinmiş
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(ClaimTypes.Role, rol)
        //    };

        //    if (additionalClaims is object) //varlığını kontrol 
        //    {
        //        var claimList = new List<Claim>(claims);
        //        claimList.AddRange(additionalClaims); //additionalClaims içeriğini claimList aktardım 
        //        claims = claimList.ToArray(); //claimList içeriğini claims aktardım
        //    }

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("uniqueKeyiçeriği"));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    return new JwtSecurityToken(
        //        issuer: "Issuer",
        //        audience: "Audience",
        //        expires: DateTime.UtcNow.Add(expiration),
        //        claims: claims,
        //        signingCredentials: creds
        //    );
        //}

        //public static JwtSecurityToken GetJwtToken(
        //    TimeSpan expiration,
        //    Claim[] additionalClaims = null)
        //{
        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    };
        //    if (additionalClaims is object)
        //    {
        //        var claimList = new List<Claim>(claims);
        //        claimList.AddRange(additionalClaims);
        //        claims = claimList.ToArray();
        //    }
        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dfghjklşlköjmhngbf"));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    return new JwtSecurityToken(
        //    issuer: "issuerdeğeri",
        //    audience: "audiencedeğeri",
        //    expires: DateTime.UtcNow.Add(expiration),
        //    claims: claims,
        //    signingCredentials: creds
        //    );
        //}

        //------------------------------------------------------------

        //public static JwtSecurityToken GetJwtToken(string username, string rol, Claim[] additionalClaims = null)
        //{
        //    var issuer = "https://localhost:7168/";
        //    var audience = "https://localhost:7168/";
        //    var key = Encoding.ASCII.GetBytes("S1u*p7e_r+S2e/c4r6e7t*0K/e7y");
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[]
        //                {
        //            new Claim("Id", Guid.NewGuid().ToString()),
        //                new Claim(JwtRegisteredClaimNames.Sub, username),
        //                new Claim(ClaimTypes.Role, rol),
        //                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        //        }),
        //        Expires = DateTime.UtcNow.AddMinutes(5),
        //        Issuer = issuer,
        //        Audience = audience,
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        //    };
        //    return new JwtSecurityToken(
        //        issuer: tokenDescriptor.Issuer,
        //        audience: tokenDescriptor.Audience,
        //        expires: tokenDescriptor.Expires,
        //        claims: (IEnumerable<Claim>)tokenDescriptor.Subject,
        //        signingCredentials: tokenDescriptor.SigningCredentials
        //    );
        //}
    }
}
