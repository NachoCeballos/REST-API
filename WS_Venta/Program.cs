string MiCors = "MiCors";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MiCors,
                      builder =>
                      {
                          builder.WithOrigins("*");
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(MiCors);

app.MapControllers();

app.Run();
