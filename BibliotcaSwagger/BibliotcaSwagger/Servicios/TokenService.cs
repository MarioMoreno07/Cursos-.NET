using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Servicios {
    public class TokenService {
        public (string token, int expiresIn) CreateToken(string username, string role) {
            new Claim(ClaimTypes.Name, username);
            new Claim(ClaimTypes.Role, role);
            new Claim("scope","api");
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var creds = new SigningCredentials(signingKey,SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expiresMinutes),
                signingCredentials: creds
            );
            new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateUser(string username, string password, out string role) {
            throw new NotImplementedException();
        }
    }
}
