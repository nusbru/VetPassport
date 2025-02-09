using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetPassport.API.Endpoints
{
    public static class AuthenticationEndpoints
    {
        public static void MapAuthenticationEndpoints(this WebApplication app)
        {
            app.MapGet("/signin", () => "Pong!");
            app.MapGet("/signup", () => "Pong!");
        }
    }
}