using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet] // /api/recipes
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Pizza", "Chips", "Chicken Curry", "Sushi", "Burger", "Soup", "Pasta" };

            if (recipes.Any())
                return NotFound();
            return Ok(recipes);
        }

        [HttpPost]
        public ActionResult CreateNewRecipes()
        {
            string[] recipes = { "Pizza", "Chips", "Chicken Curry", "Sushi", "Burger", "Soup", "Pasta" };

            if (recipes.Any())
                return NotFound();
            return Ok(recipes);
        }

        [HttpDelete("{id}")] // /api/recipes/1234
        public ActionResult DeleteRecipes(string id)
        {
            bool badThingsHappned = false;

            if (badThingsHappned)
                return BadRequest();
            return NoContent();
        }

    }
}
