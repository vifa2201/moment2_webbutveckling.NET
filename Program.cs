var builder = WebApplication.CreateBuilder(args);

//aktivera mvc 
builder.Services.AddControllersWithViews();

var app = builder.Build();
//aktivera statiska filer
app.UseStaticFiles();

app.UseRouting();

//skapar egen routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
