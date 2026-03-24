using demo.Model;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        static List<Food> foods = new List<Food>()
        {
            new Food { Id = 1, Name = "Pho", Calories = 350 },
            new Food { Id = 2, Name = "Banh Mi", Calories = 250 }
        };

        // GET: api/food
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(foods); // trả về JSON
        }

        // POST: api/food
        [HttpPost]
        public IActionResult Create(Food food)
        {
            foods.Add(food);
            return Ok(food); // nhận + trả JSON
        }
    }
}