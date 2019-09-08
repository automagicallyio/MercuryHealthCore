using System;
using System.Collections.Generic;
using System.Linq;
using MercuryHealthCore.Data.MercuryHealthDB;
using MercuryHealthCore.lib.DomainModel;

namespace MercuryHealthCore.lib.Repositories {
    public class ExerciseRepository : IExerciseRepository
    {
        private MercuryHealthContext _context;

        public ExerciseRepository(MercuryHealthContext dbContext) {
            _context = dbContext;
        }

        public Exercise GetExercise(Guid id)
        {
            return _context.Exercises
                .First(x => x.Id == id);
        }

        public IEnumerable<Exercise> GetExercises()
        {
            return _context.Exercises
                .ToList();
        }

        public void SaveExercise(Exercise exercise)
        { 
            if (exercise.Id == Guid.Empty) {
                _context.Exercises.Add(exercise);
            }
            else {
                _context.Entry(exercise).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void DeleteExercise(Exercise exercise) {
            var dbObj = _context.Exercises.First(x => x.Id == exercise.Id);
            _context.Exercises.Remove(dbObj);
        }

        public void DeleteExercise(Guid id) {
            var dbObj = _context.Exercises.First(x => x.Id == id);
            _context.Exercises.Remove(dbObj);
        }

        public void SaveChanges() {
            _context.SaveChanges();
        }
    }
}
