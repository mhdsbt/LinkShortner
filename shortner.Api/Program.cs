using Microsoft.AspNetCore.Connections;
using Shortner.BusinessLayer.Services;
using Shortner.BusinessLayer.Services.Interfaces;
using shortner.DataAccessLayer.Context;
using shortner.DataAccessLayer.Repositories;
using shortner.DataAccessLayer.Repositories.Interface;
using   Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<ILinkRepository, LinkRepository>();
builder.Services.AddScoped<ILinkService, LinkService>();
System.Net.ServicePointManager.ServerCertificateValidationCallback +=
    (sender, certificate, chain, errors) => true;
builder.Services.AddDbContext<shortnerDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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