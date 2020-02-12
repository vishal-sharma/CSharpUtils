using System;
using System.IdentityModel.Tokens.Jwt;

namespace JwtTokenDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var jwtToken = @"<put your token here instead of this placeholder>";

            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwtToken);

            Console.WriteLine(token);
            Console.WriteLine("Decoced JWT Token is above in cmd window. Once you found the value you were looking from decoded token. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
