var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllers();   
app.UseStaticFiles();
app.UseRouting();   
app.Run();
