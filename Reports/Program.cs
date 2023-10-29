//using Reports.Storage.Entities;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using System.Configuration;
//using Microsoft.Extensions.Caching.Memory;
//using Microsoft.AspNetCore.Authentication;
////using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Reports.Storage.DataBase.PostgreSQL.Maps;
//using Reports.Storage.DataBase;
//using Microsoft.Extensions.Configuration;
//using Npgsql.EntityFrameworkCore.PostgreSQL;


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();
////var cs = builder.Configuration["Database:ConnectionString"];

////builder.Services.AddDbContext<ApplicationDbContext>(options =>
////{
////    options.UseNpgsql(
////    cs,
////    
////    );
////});
////public void ConfigureServices(IServiceCollection services)
////{
////    var connectionString = Configuration["Database:ConnectionString"];
////    services.AddDbContext<ApplicationDbContext>(options =>
////    {
////        options.UseNpgsql(connectionString);
////    });
////}

//    var configuration = new ConfigurationBuilder()
//        .SetBasePath(Directory.GetCurrentDirectory())
//        .AddJsonFile("appsettings.json")
//        .Build();

//    builder.Services.AddDbContext<ApplicationDbContext>(options =>
//        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));



////builder.Services.AddSwaggerGen();
//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    //app.UseExceptionHandler("/Home/Error");
//    //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    //app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
using Reports.Storage.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Authentication;
using Reports.Storage.DataBase.PostgreSQL.Maps;
using Reports.Storage.DataBase;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Добавьте сервис базы данных напрямую в Program.cs
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Нет необходимости в методе ConfigureServices

// Ваш остальной код остается без изменений

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");
    //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
