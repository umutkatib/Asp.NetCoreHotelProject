using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
	public class CreateJwtToken
	{
		public string CreateToken()
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
			SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(1), signingCredentials: signingCredentials);

			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
			return handler.WriteToken(jwtSecurityToken);
		}

		public string CreateTokenForAdmin()
		{
			var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
			SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
			SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			List<Claim> claims = new List<Claim>()
			{
				new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Role, "Admin"),
				new Claim(ClaimTypes.Role, "Visitor"),
			};

			JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(1), signingCredentials: signingCredentials, claims: claims);

			JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

			return handler.WriteToken(jwtSecurityToken);
		}
	}
}
