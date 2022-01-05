using FluentAssertions.Common;
using System.Configuration;
using ToDoApi1.Models;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ToDoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Program� �al��t�rd���m�zda otomatik swagger a de�ilde yazm�� oldu�um api ye gitmesi i�in( launchUrl de tan�mlad�m) art�k UseSwagger � kullanmas�na gerek kalmad�.
    //app.UseSwagger();
    //app.UseSwaggerUI();

    //kendi ayarlar�m�z� ekleyebiliriz
    //IServiceCollection serviceCollection = Services.AddDbContext<ToDoContext>(OptionsBuilderConfigurationExtensions.UseInMemoryDataBase("DataBaseAdd ToDoList"));
    

   
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
