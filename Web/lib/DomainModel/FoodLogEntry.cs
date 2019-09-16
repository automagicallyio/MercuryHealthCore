using System;
using System.ComponentModel.DataAnnotations;

namespace MercuryHealthCore.lib.DomainModel
{

    public class FoodLogEntry
    {

        public int Id { get; set; }

        public MemberProfile MemberProfile { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        [Display(Name="Meal Time")]
        public DateTime MealTime { get; set; }

        public string Tags { get; set; }

        public int Calories { get; set; }

        [Display(Name="Protein/g")]
        public decimal ProteinInGrams { get; set; }

        [Display(Name="Fat/g")]
        public decimal FatInGrams { get; set; }

        [Display(Name="Carbohydrates/g")]
        public decimal CarbohydratesInGrams { get; set; }

        [Display(Name="Sodium/g")]
        public decimal SodiumInGrams { get; set; }

        //[Display(Name = "Color")]
        //public string Color { get; set; }


    }
}