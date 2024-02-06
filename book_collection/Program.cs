using book_collection.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // MVC
var app = builder.Build();

app.UseStaticFiles(); // wwwroot
app.UseRouting();

// Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Databas
builder.Services.AddDbContext<AuthorContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString"))
);

app.Run();
