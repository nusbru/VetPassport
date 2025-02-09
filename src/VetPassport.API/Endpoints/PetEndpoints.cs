using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetPassport.API.Endpoints
{
    public static class PetEndpoints
    {
        public static void MapPetEndpoints(this WebApplication app)
        {
            app.MapGet("/users/{user}/pets", () => "Pong!");
            app.MapGet("/users/{user}/pets/{pet}", () => "Pong!");

        }
    }
}