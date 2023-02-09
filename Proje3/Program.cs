using Proje3.Extensions;
using Repository.Repositories.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Proje3Context>();
builder.Services.MyconfigureServices();//Autofac.Extensions.DependencyInjection k�t�phamesini indirmen laz�m
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc().AddRazorRuntimeCompilation();

//builder.Services.MyConfigureServices();
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

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
});

app.Run();
