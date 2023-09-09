using Microsoft.OpenApi.Models;
using MiniTodo.Data;
using MiniTodo.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASP.NET Minimal API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("v1/todos", (AppDbContext context) =>
{
    var todos = context.Todos.ToList();

    return Results.Ok(todos);
}).Produces<Todo>();

app.MapPost("v1/todos", (AppDbContext context, CreateTodoViewModels model) =>
{
    var todo = model.MapTo();

    if (!model.IsValid)
        return Results.BadRequest(model.Notifications);

    context.Todos.Add(todo);
    context.SaveChanges();

    return Results.Created($"/v1/todos/{todo.Id}", todo);
});

app.Run();
    