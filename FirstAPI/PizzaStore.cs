namespace FirstAPI
{
    public static class PizzaStore
    {
        public static List<Pizza> Pizzas { get; } = new List<Pizza>
    {
        new Pizza { Id = 1, Name = "Margherita", Price = 9.99M },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 11.99M },
        new Pizza { Id = 3, Name = "Hawaiian", Price = 12.99M }
    };
    }

}
