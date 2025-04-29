using System.Net.WebSockets;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace ECommerceAPI.Services
{
    public class TokenService
    {
        public string GenerateToken(string email)

        // claims - informações do usuario que quero guardar 
        var claims = new[]
        {
            new Claim(ClaimTypes.Email, email)
        };
        // criar uma chave de segurança e criptografar ela

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("minha-chave-secreta-senai"));

    }
}
