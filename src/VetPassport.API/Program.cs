using Scalar.AspNetCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference(endpointPrefix: "/api-reference");
    app.MapOpenApi();
}


app.MapGet("/", () => "Hello world!");

app.Run();