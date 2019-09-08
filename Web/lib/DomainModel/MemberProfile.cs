using System;

namespace MercuryHealthCore.lib.DomainModel
{

    public class MemberProfile
    {
        
        public int Id { get; set; }

        public DateTime Birthdate { get; set; }

        public Gender Gender { get; set; }

        public string Bio { get; set; }
        
        public int WeightInKilograms { get; set; }

        public int HeightInCentimeters { get; set; }

        public int Age
        {
            get
            {
                return CalculateAge(this.Birthdate);
            }
        }

        public int CalculateAge()
        {
            return CalculateAge(this.Birthdate);
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

    }

}
