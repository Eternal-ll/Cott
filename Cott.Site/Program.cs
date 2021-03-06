using Cott.Database.Context;
using Cott.Site.Infrastructure.Services;
using Cott.Site.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add database
builder.Services.AddDbContext<CottContext>(
    opt => opt
       .UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"),
       o => o
       .MigrationsAssembly("Cott.Database.SqlServer")
       .CommandTimeout(5000)));
builder.Services
    .AddScoped<WordReportService>()
    .AddScoped<ExcelReportService>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reports}/{action=Index}/{id?}");
app.Run();
