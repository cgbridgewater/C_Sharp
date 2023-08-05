var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // MUST be before calling Build()
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}"); 
app.Run();
