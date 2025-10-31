using BussinessLayerService.AutoMapper;
using BussinessLayerService.MiddleWare;
using BussinessLayerService.Repositories.Implementation;
using BussinessLayerService.Repositories.Interface;
using BussinessLayerService.Services.Implementation;
using BussinessLayerService.Services.Interface;
using DataAccessLayerService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.   

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Add Db
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));
builder.Services.AddSwaggerGen();

//Add Repo
builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddAutoMapper(typeof(TeacherMapper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
    app.MapOpenApi();
}

app.UseMiddleware<GlobalExceptionHandlingMiddleWare>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
