using Cap_issus_1204;
using DotNetCore.CAP;
using Savorboard.CAP.InMemoryMessageQueue;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<IDemoService, DemoService>();
builder.Services.AddScoped<DemoService>(sp =>
{
    var d = new DemoService();
    return d;
});

builder.Services.AddCap(options =>
{
    options.UseInMemoryStorage();
    options.UseInMemoryMessageQueue();
    options.UseDashboard();
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllers();

app.Run();
