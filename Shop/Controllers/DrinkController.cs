using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class DrinkController: Controller
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);
        }
    }
}
