using EcomnnereceBack.Data;
using Infra.Data;
using Infra.IRepo;
using Infra.Repo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped <IProductRpository, ProductRpository> ();
builder.Services.AddScoped  (typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<StoreContext>(s => s.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// using this to update the migration each time i run the app
using var scoped = app.Services.CreateScope();
var Services = scoped.ServiceProvider;
var context = Services.GetRequiredService<StoreContext>();
try
{
    await context.Database.MigrateAsync();
    await SeedStoreContext.SeedAsync(context);
}
catch (Exception)
{

	throw;
}
app.Run();
