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
global using Newtonsoft.Json;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Security.Claims;

global using Anandashram.DTO;
using Anandashram;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.FileProviders;
using System.Text.Json.Serialization;
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
builder.Services.AddControllersWithViews(options =>
{
    // This might be adding antiforgery globally
    options.Filters.Add(new IgnoreAntiforgeryTokenAttribute());
});
    
builder.Services.AddScoped<ICompany, CompanyRepository>();
builder.Services.AddDataProtection().ProtectKeysWithDpapi(); builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
    options.Cookie.HttpOnly = true;                 // Protect from JavaScript access
    options.Cookie.IsEssential = true;              // Required for GDPR compliance
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // HTTPS only
    options.Cookie.SameSite = SameSiteMode.Lax;
});//Dependency Injection
builder.Services.AddScoped<IDevotee, DevoteeRepository>();
builder.Services.AddScoped<IBlock, BlockRepository>();
builder.Services.AddScoped<IFloor, FloorRepository>();
builder.Services.AddScoped<IBuilding, BuildingRepository>();
builder.Services.AddScoped<IRoom, RoomRepository>();
builder.Services.AddScoped<IFileManagement, FileManagement>();
builder.Services.AddScoped<IDevoteeCategory, DevoteeCategoryRepository>();
builder.Services.AddScoped<IReservation, ReservationRepository>();
builder.Services.AddFastReport();
var app = builder.Build();

app.UseFastReport();
app.UseDeveloperExceptionPage();
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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Reservation}/{action=ReservationList}/{id?}");
app.MapRazorPages();

app.Run();
