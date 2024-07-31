using FirstAPI;

var builder = WebApplication.CreateBuilder(args);

/*var app = builder.Build();

app.MapGet("/pizzas", () =>
{
    return PizzaStore.Pizzas;
});

app.MapPost("/pizzas", (Pizza pizza) =>
{
    // Generate a new Id for the pizza
    var newId = PizzaStore.Pizzas.Max(p => p.Id) + 1;
    pizza.Id = newId;

    // Add the new pizza to the list
    PizzaStore.Pizzas.Add(pizza);

    // Return the created pizza
    //status 200, 404, 501
    return Results.Created($"/pizzas/{pizza.Id}", pizza);
});

app.Run();*/

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestAPI V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the root path
    });
}

//convention based routing
//url/api/pizza(controller)/{1}
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();



