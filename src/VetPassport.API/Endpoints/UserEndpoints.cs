using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetPassport.API.Endpoints
{
    public static class UserEndpoints
    {

        public static void MapUserEndpoints(this WebApplication app)
        {
            app.MapGet("/users/{user}", () => "Pong!");
            app.MapPost("/users/{user}", () => "Pong!");
            app.MapPut("/users/{user}", () => "Pong!");
        }
    }
}