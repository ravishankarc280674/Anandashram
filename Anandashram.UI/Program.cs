global using Anandashram.Data;
global using Anandashram.DTO;
global using Anandashram.Interfaces;
global using Anandashram.Interfaces.Repository;
global using Anandashram.Interfaces.Services;
global using Anandashram.Models;
global using Anandashram.Reports;
global using Anandashram.Repository;
global using Anandashram.Services;
global using Anandashram.UI.Tools.Core.Helpers;
global using Anandashram.UI.Tools.Core.Models;
global using Anandashram.UI.Tools.Enums;
global using Anandashram.UI.Tools.Models;
global using ClosedXML.Excel;
global using DocumentFormat.OpenXml;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc.Authorization;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using Microsoft.EntityFrameworkCore;
global using Newtonsoft.Json;
global using QuestPDF.Fluent;
global using QuestPDF.Infrastructure;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Security.Claims;
global using Microsoft.AspNetCore.Mvc;

QuestPDF.Settings.License = LicenseType.Community;

var builder = WebApplication.CreateBuilder(args);

// Database
var connectionString = builder.Configuration.GetConnectionString("AnandashramDBConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.Configure<BackupSettings>(
    builder.Configuration.GetSection("BackupSettings"));

builder.Services.AddHostedService<BackupHostedService>();
// Identity
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

// Cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.SlidingExpiration = true;
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
});

// MVC
builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
})
.AddRazorPagesOptions(options =>
{
    // Allow anonymous access to login and register pages only
    options.Conventions.AllowAnonymousToAreaFolder("Identity", "/Account");
});

// Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// DI
builder.Services.AddScoped<ICompany, CompanyRepository>();
builder.Services.AddScoped<IDevotee, DevoteeRepository>();
builder.Services.AddScoped<IBlock, BlockRepository>();
builder.Services.AddScoped<IFloor, FloorRepository>();
builder.Services.AddScoped<IBuilding, BuildingRepository>();
builder.Services.AddScoped<IRoom, RoomRepository>();
builder.Services.AddScoped<IFileManagement, FileManagement>();
builder.Services.AddScoped<IDevoteeCategory, DevoteeCategoryRepository>();
builder.Services.AddScoped<IReservation, ReservationRepository>();
builder.Services.AddScoped<IHome, HomeRepository>();
builder.Services.AddScoped<IBuildingService, BuildingService>();
builder.Services.AddScoped<IBlockService, BlockService>();
builder.Services.AddScoped<IFloorService, FloorService>();
builder.Services.AddScoped<IDevoteeCategoryService, DevoteeCategoryService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IDevoteeService, DevoteeService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IReportService, ReportService>();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

// Default
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
