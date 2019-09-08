using System;
using System.Collections.Generic;
using MercuryHealthCore.lib.DomainModel;

namespace MercuryHealthCore.lib.Repositories {
    public interface IExerciseRepository {
        IEnumerable<Exercise> GetExercises();
        Exercise GetExercise(Guid id);
        void SaveExercise(Exercise exercise);
        void DeleteExercise(Guid id);
        void SaveChanges();

    }
}
