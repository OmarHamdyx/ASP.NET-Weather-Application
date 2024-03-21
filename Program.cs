using Interfaces;
using Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISetViewBag, SetViewBag>();

builder.Services.AddTransient<ICitiesProvider,CitiesProvider>();
var app = builder.Build();
app.MapControllers();   
app.UseStaticFiles();
app.UseRouting();   
app.Run();
