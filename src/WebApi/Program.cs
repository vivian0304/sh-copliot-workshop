// add a namespace for rewriteoptions
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // add a new rewrite option that redirects root to /swagger
    var options = new RewriteOptions();
    options.AddRedirect("^$", "swagger");
    app.UseRewriter(options);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
