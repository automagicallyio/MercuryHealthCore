
using System;
using System.Collections.Generic;
using MercuryHealthCore.lib.DomainModel;

namespace MercuryHealthCore.lib.Repositories {
    public interface INutritionRepository {
        IEnumerable<FoodLogEntry> GetFoodLogEntries();
        FoodLogEntry GetFoodLogEntry(int id);
        void SaveFoodLogEntry(FoodLogEntry food);
        void DeleteFoodLogEntry(int id);
        void SaveChanges();
    }

}