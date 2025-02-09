namespace VetPassport.API.Endpoints
{
    public static class VaccineEndpoints
    {
        public static void MapVaccineEndpoints(this WebApplication app)
        {
            app.MapGet("/users/{user}/pets/{pet}/vaccines", () => "Pong!");
            app.MapGet("/users/{user}/pets/{pet}/vaccines/{vaccines}", () => "Pong!");
        }
    }
}