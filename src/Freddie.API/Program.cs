using Freddie.API.Models;
using Freddie.API.Services;
using Microsoft.AspNetCore.Mvc;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IStudentService, StudentService>();

WebApplication app = builder.Build();

app.MapGet("/students", ([FromServices] IStudentService studentService) =>
{
    IQueryable<Student> retrievedStudents = studentService.RetrieveAllStudents();

    return Results.Ok(retrievedStudents);
});

app.Run();