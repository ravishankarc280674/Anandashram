global using Anandashram.Data;
global using Anandashram.Interfaces;
global using Anandashram.Models;
global using Anandashram.Repositories;
global using Anandashram.UI.Tools.Core.Helpers;
global using Anandashram.UI.Tools.Core.Models;
global using Anandashram.UI.Tools.Enums;
global using Anandashram.UI.Tools.Models;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.Security.Claims;
global using Newtonsoft.Json;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations.Schema;
using Anandashram;
using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("AnandashramDBConnection") ?? throw new InvalidOperationException("Connection string 'AnandashramDBConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddResponseCompression();
builder.Services.AddControllersWithViews();
//Dependency Injection
builder.Services.AddScoped<IDevotee, DevoteeRepository>();
builder.Services.AddScoped<IBlock, BlockRepository>();
builder.Services.AddScoped<IFloor, FloorRepository>();
builder.Services.AddScoped<IBuilding, BuildingRepository>();
builder.Services.AddScoped<IRoom, RoomRepository>();
builder.Services.AddScoped<IFileManagement, FileManagement>();


builder.Services.AddScoped<IDevoteeCategory, DevoteeCategoryRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(builder.Configuration.GetSection("DocumentStoragePath").Value),
    RequestPath = "/Documents"
});
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Devotee}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
