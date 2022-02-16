using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lesson9.Data;
using Lesson9.Domain.Managers.Interfaces;
using Lesson9.Domain.Managers.Implementation;
using Lesson9.Data.Interfaces;
using Lesson9.Data.Implementation;
using System.Configuration;
using MailKit.Net.Smtp;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserManager, UserManager>();

builder.Services.AddScoped<IUserRepo, UserRepo>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
