using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.
    AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).
    AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true).
    AddJsonFile("ocelot.json",optional:false,reloadOnChange:true);
builder.Services.AddControllers();
builder.Services.AddOcelot();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
await app.UseOcelot();
app.Run();
