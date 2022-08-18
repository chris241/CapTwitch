using CapTwitch.Api.Controllers;
using CapTwitch.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContextPool<CaptTwitchDbContext>(op =>
{
    string cs = "server=localhost;Database=captwitch; user=root; password=''";
    op.UseMySql(cs, ServerVersion.AutoDetect(cs));
});

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
