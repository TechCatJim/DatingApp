using System.Text;
using API.Data;
using API.Entities;
using API.Extensions;
using API.Interface;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader()
    .AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.UseAuthentication(); //do you have valid token
app.UseAuthorization(); //what are you allowed to do if you have valid token

app.MapControllers();

app.Run();
