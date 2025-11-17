global using Anandashram.Data;
global using Anandashram.DTO;
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
global using Microsoft.AspNetCore.Authorization;
using Anandashram;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Database connection
var connectionString = builder.Configuration.GetConnectionString("AnandashramDBConnection")
    ?? throw new InvalidOperationException("Connection string 'AnandashramDBConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// 🔹 Identity configuration
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

// 🔹 Configure Identity cookie settings
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login"; // Redirect here when not logged in
    options.LogoutPath = "/Identity/Account/Logout";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Match session timeout
    options.SlidingExpiration = true; // Extend cookie if user is active
});

// 🔹 MVC and global authorization policy
builder.Services.AddControllersWithViews(options =>
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    options.Filters.Add(new AuthorizeFilter(policy));

    options.Filters.Add(new IgnoreAntiforgeryTokenAttribute());
}).AddRazorPagesOptions(options =>
{
    // ✅ Allow anonymous access to Identity pages
    options.Conventions.AllowAnonymousToAreaFolder("Identity", "/Account");
}); ;


builder.Services.Configure<ValidationSettings>(builder.Configuration.GetSection("ValidationSettings"));
builder.Services.AddAuthorization();
builder.Services.AddResponseCompression();
builder.Services.AddDataProtection().ProtectKeysWithDpapi();

// 🔹 Session configuration
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.SameSite = SameSiteMode.Lax;
});

// 🔹 Dependency Injection
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
builder.Services.AddFastReport();

var app = builder.Build();

app.UseFastReport();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// 🔹 Serve document storage folder
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        builder.Configuration.GetSection("DocumentStoragePath").Value),
    RequestPath = "/Documents"
});

app.UseRouting();

app.UseSession();

// 🔹 Middleware to check for expired session and force login
app.Use(async (context, next) =>
{
    if (context.User.Identity?.IsAuthenticated == true)
    {
        if (context.Session.GetString("UserId") == null)
        {
            // If it's an AJAX request, return 401 instead of redirecting
            if (context.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                return;
            }

            var signInManager = context.RequestServices.GetRequiredService<SignInManager<IdentityUser>>();
            await signInManager.SignOutAsync();
            context.Response.Redirect("/Identity/Account/Login");
            return;
        }
    }
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

// 🔹 Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
