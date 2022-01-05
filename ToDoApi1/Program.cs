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
    //Programý çalýþtýrdýðýmýzda otomatik swagger a deðilde yazmýþ olduðum api ye gitmesi için( launchUrl de tanýmladým) artýk UseSwagger ý kullanmasýna gerek kalmadý.
    //app.UseSwagger();
    //app.UseSwaggerUI();

    //kendi ayarlarýmýzý ekleyebiliriz
    //IServiceCollection serviceCollection = Services.AddDbContext<ToDoContext>(OptionsBuilderConfigurationExtensions.UseInMemoryDataBase("DataBaseAdd ToDoList"));
    

   
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
