using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ToDoApp.Data;
using MudBlazor.Services;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = builder.Configuration.GetConnectionString("Default")
	?? throw new NullReferenceException("no connection string in config!");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<KanBanSectionService>();
builder.Services.AddTransient<KanbanTaskItemService>();
builder.Services.AddMudServices();
builder.Services.AddDbContextFactory<ToDoDbContext>((DbContextOptionsBuilder options)=>
options.UseSqlServer(connectionstring));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
