using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int visitorsCount = 0;

app.MapGet("/visitors", () =>
{
    visitorsCount++;
    return new { visitors = visitorsCount };
});

app.Run();
