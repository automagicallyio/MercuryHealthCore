using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MercuryHealthCore.lib.Repositories;
using MercuryHealthCore.lib.DomainModel;

namespace MercuryHealthCore.Controllers
{
    public class NutritionController : Controller
    {
        private INutritionRepository _nutritionRepo;
        public NutritionController(INutritionRepository nutritionRepo) {
            _nutritionRepo = nutritionRepo;
        }

        public IActionResult Index()
        {
            var allFood = _nutritionRepo.GetFoodLogEntries();
            return View(allFood);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FoodLogEntry food) {
            _nutritionRepo.SaveFoodLogEntry(food);
            _nutritionRepo.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id){
            var dataObj = _nutritionRepo.GetFoodLogEntry(id);
            return View(dataObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(FoodLogEntry food) {
            _nutritionRepo.DeleteFoodLogEntry(food.Id);
            _nutritionRepo.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) {
            var dataObj = _nutritionRepo.GetFoodLogEntry(id);
            return View(dataObj);
        }

        public IActionResult Edit(int id) {
            var dataObj = _nutritionRepo.GetFoodLogEntry(id);
            return View(dataObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FoodLogEntry food) {
            _nutritionRepo.SaveFoodLogEntry(food);
            _nutritionRepo.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
