using Anandashram.BAL;
using Anandashram.BAL.Interface;
using Anandashram.DAL;
using Anandashram.DAL.Interface;
using Anandashram.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AnandashramContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("AnandashramDbContext") ?? throw new InvalidOperationException("Connection string 'AnandashramDbContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//Register All BO's for DI
builder.Services.AddScoped<IDevoteeBO, DevoteeBO>();
builder.Services.AddScoped<IInfraStructureBO, InfraStructureBO>();

//Register All DAO's for DI
builder.Services.AddScoped<IDevoteeDAO, DevoteeDAO>();
builder.Services.AddScoped<IInfraStructureDAO, InfraStructureDAO>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
