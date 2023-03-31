using ParksLookupApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ParksLookupApi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
  }
}

// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers();

// builder.Services.AddDbContext<ParksLookupContext>(
//                   dbContextOptions => dbContextOptions
//                     .UseMySql(
//                       builder.Configuration["ConnectionStrings:DefaultConnection"], 
//                       ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
//                     )
//                   )
//                 );

// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
// else 
// {
//   app.UseHttpsRedirection();
// }

// app.UseAuthorization();

// app.MapControllers();

// app.Run();



