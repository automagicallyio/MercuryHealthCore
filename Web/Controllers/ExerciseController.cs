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
    public class ExerciseController : Controller
    {
        private IExerciseRepository _exerciseRepo;
        public ExerciseController(IExerciseRepository exerciseRepo) {
            _exerciseRepo = exerciseRepo;
        }

        public IActionResult Index()
        {
            var allExercises = _exerciseRepo.GetExercises();
            return View(allExercises);
        }

        public IActionResult Edit(Guid id) {
            var exerciseObj = _exerciseRepo.GetExercise(id);
            return View(exerciseObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Exercise exercise) {
            if(ModelState.IsValid) {
                _exerciseRepo.SaveExercise(exercise);
                _exerciseRepo.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id) {
            var exerciseObj = _exerciseRepo.GetExercise(id);
            return View(exerciseObj);
        }

        public IActionResult Delete(Guid id) {
            var exerciseObj = _exerciseRepo.GetExercise(id);
            return View(exerciseObj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Exercise exercise) {
            _exerciseRepo.DeleteExercise(exercise.Id);
            _exerciseRepo.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Exercise exercise) {
            _exerciseRepo.SaveExercise(exercise);
            _exerciseRepo.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
