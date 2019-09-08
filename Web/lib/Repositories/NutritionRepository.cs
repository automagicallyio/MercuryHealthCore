using System;
using System.Collections.Generic;
using System.Linq;
using MercuryHealthCore.Data.MercuryHealthDB;
using MercuryHealthCore.lib.DomainModel;

namespace MercuryHealthCore.lib.Repositories {
    public class NutritionRepository : INutritionRepository
    {
        private MercuryHealthContext _context;

        public NutritionRepository(MercuryHealthContext dbContext) {
            _context = dbContext;
        }
        
        public void DeleteFoodLogEntry(int id)
        {
            var dataObj = _context.FoodLogEntries.FirstOrDefault(x => x.Id == id);
            _context.FoodLogEntries.Remove(dataObj);
        }

        public IEnumerable<FoodLogEntry> GetFoodLogEntries()
        {
            return _context.FoodLogEntries.ToList();
        }

        public FoodLogEntry GetFoodLogEntry(int id)
        {
            return _context.FoodLogEntries.First(x => x.Id == id);
        }

        public void SaveFoodLogEntry(FoodLogEntry food)
        {
            if (food.Id == 0) {
                _context.FoodLogEntries.Add(food);
            }
            else {
                _context.Entry(food).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}