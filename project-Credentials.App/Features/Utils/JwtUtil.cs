using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using project_Credentials.App.Interfaces;
using project_Credentials.Domain.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace project_Credentials.App.Features.Utils;


public class JwtUtil : IJwtUtil
{
    private readonly IConfiguration _config;

    public JwtUtil(IConfiguration config) { _config = config; }

    public string GenerateIdentityJwtToken(User user, string secretKey = null)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        SecurityKey securityKey;
        if (secretKey == null)
        { securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration.GetSection("SecretKey").Value)); }
        else
        { securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)); }

        var credidentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[] {
                new Claim("UserId",  user.UserId.ToString()),
                new Claim("Email", user.Email),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName",user.LastName)
                };
        var token = new SecurityTokenDescriptor
        {

            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(10),
            SigningCredentials = credidentials
        };

        var t = tokenHandler.CreateToken(token);


        return tokenHandler.WriteToken(t);
    }
    public bool Validate(string token, string stringKey)
    {
        if (token == null) return false;

        var tokenHandler = new JwtSecurityTokenHandler();
        //  var byteKey = Encoding.ASCII.GetBytes(stringKey);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(stringKey))
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;

            return tokenHandler.CanReadToken(jwtToken.ToString());

        }
        catch (Exception)
        {
            return false;
        }
    }
}
