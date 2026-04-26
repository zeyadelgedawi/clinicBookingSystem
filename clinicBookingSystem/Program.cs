using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;



var builder = WebApplication.CreateBuilder(args);

//  Controllers
builder.Services.AddControllers();

//SQL Server
builder.Services.AddDbContext<ClinicDbContext>(options =>
    options.
    UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowAll");

// Controllers
app.MapControllers();


app.Run();