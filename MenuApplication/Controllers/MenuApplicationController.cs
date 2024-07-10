using Microsoft.AspNetCore.Mvc;
using MenuApplication.Models;
using MenuApplication.Models.Data;
using Microsoft.EntityFrameworkCore;
using MenuApplication.Migrations;

namespace MenuApplication.Controllers
{
    public class MenuApplication : Controller
    {
        private readonly MenuContext _context;
        public MenuApplication(MenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var dishes = from d in _context.Dishes
                       select d;
            if(!String.IsNullOrEmpty(searchString))
            {
                dishes = dishes.Where(d => d.Name.Contains(searchString));
                return View(await dishes.ToListAsync());
            }
            return View(await dishes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dish = await _context.Dishes
                .Include(di => di.DishIngredients)
                .ThenInclude(i => i.Ingredient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }
    }
}
