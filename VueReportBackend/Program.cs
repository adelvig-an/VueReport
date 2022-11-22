using System.Reflection;
using BussinesLayer;
using BussinesLayer.Common.Mappings;
using DbLayer;
using DbLayer.Interfaces;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IReportDbContext).Assembly));
});

builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();

    });
});

IConfiguration Configuration = builder.Configuration;

builder.Services.AddApplication();
builder.Services.AddPersistence(Configuration);

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var servicesProvider = scope.ServiceProvider;
    try
    {
        var context = servicesProvider.GetRequiredService<ApplicationDbContext>();
        DbInitializer.Initializer(context);
    }
    catch (Exception exception)
    { }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(b => {
    b.AllowAnyOrigin();
    b.AllowAnyHeader();
    b.AllowAnyMethod(); 
});

app.UseRouting();
app.UseHttpsRedirection();
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
