using BackendNet.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, SslPolicyErrors) => true;

builder.Services.AddControllers();

builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
