using System.IdentityModel.Tokens.Jwt;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace ECommerceAPI.Services
{
    public class TokenService
    {
        public string GenerateToken(string email)
        {

            // claims - informações do usuario que quero guardar 
            var claims = new[]
            {
            new Claim(ClaimTypes.Email, email)
            };
            // criar uma chave de segurança e criptografar ela

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha-chave-ultra-secreta-senai"));

            var creds = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            // montar um token
            var token = new JwtSecurityToken(
                issuer: "ecommerce",
                audience: "ecommerce",    
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),    
                signingCredentials: creds
    

            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }           
 
    }
}
