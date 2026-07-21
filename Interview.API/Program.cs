using Infrastructure;
using Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<InMemDbContext>(options => options.UseInMemoryDatabase("Default"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => (object?)null)
    .WithName("Default Endpoint");

# region InMemoryDB Setup
using (IServiceScope scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<InMemDbContext>();

    if (!context.Products.Any())
    {
        context.Products.AddRange(InitialDataSet.Get());
        context.SaveChanges();
    }
}
# endregion

app.Run();
