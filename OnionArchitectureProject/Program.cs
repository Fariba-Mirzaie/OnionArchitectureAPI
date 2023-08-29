using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using OA.Domain.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));

#region ApiVersioning

//builder.Services.AddApiVersioning();
//builder.Services.AddApiVersioning(opt =>
//{
//    opt.AssumeDefaultVersionWhenUnspecified = true;
//    opt.DefaultApiVersion = new ApiVersion(1, 0);
//});

//builder.Services.AddApiVersioning(opt => opt.ApiVersionReader = new HeaderApiVersionReader("api-version"));


builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new QueryStringApiVersionReader("version");
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
