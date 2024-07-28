using MediatR;
using System.Reflection;
using Contact.Core.Repositories;
using Contact.Infrastructure.Data;
using Contact.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.
    AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).
    AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();



var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();


app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
