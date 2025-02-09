using Scalar.AspNetCore;
using VetPassport.API.Endpoints;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference(endpointPrefix: "/api-reference");
    app.MapOpenApi();
}


app.MapGet("/ping", () => "Pong!");
app.MapAuthenticationEndpoints();
app.MapUserEndpoints();
app.MapPetEndpoints();
app.MapVaccineEndpoints();

app.Run();