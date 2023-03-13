using DesignPattern.Command.Application.CommandHandlers;
using DesignPattern.Command.Application.Commands;
using DesignPattern.Command.Application.EventHandlers;
using DesignPattern.Command.Application.Events;
using DesignPattern.Framework.Abstractions;
using DesignPattern.Framework.Abstractions.EventAbstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICommandBus, CommandBus>();
builder.Services.AddTransient<ICommandHandler<CreateOrderCommand>, CreateOrderCommandHandler>();

builder.Services.AddTransient<IEventHandler<OrderCreatedEvent>, OrderCreatedEventHandler>();

builder.Services.AddSingleton<IEventBus, EventAggregator>();


//var x= builder.Services<ICommandHandler<CreateOrderCommand>>().ToList();

var app = builder.Build();

//var x= app.Services.GetRequiredService<IEnumerable<ICommandHandler<ICommand>>>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();

