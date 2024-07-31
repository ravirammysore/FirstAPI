using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    //attributes - they help customize
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : ControllerBase
    {
        //decoration
        [HttpGet]
        public ActionResult<List<Pizza>> Get()
        {
            return PizzaStore.Pizzas;
        }

        [HttpPost]
        public ActionResult<Pizza> Post(Pizza pizza)
        {
            var newId = PizzaStore.Pizzas.Max(p => p.Id) + 1;
            pizza.Id = newId;
            PizzaStore.Pizzas.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
        }
    }
}
