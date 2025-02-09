using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using VetPassport.API.Data;
using VetPassport.API.Endpoints;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

builder.Services.AddDbContext<VetPassportContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<VetPassportContext>();
    dbContext.Database.Migrate();
}

app.MapScalarApiReference(endpointPrefix: "/api-reference");
app.MapOpenApi();

app.MapGet("/ping", () => "Pong!");
app.MapAuthenticationEndpoints();
app.MapUserEndpoints();
app.MapPetEndpoints();
app.MapVaccineEndpoints();

app.Run();