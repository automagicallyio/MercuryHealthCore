using System;
using System.Collections.Generic;

namespace MercuryHealthCore.lib.DomainModel {
    public class Exercise
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public string VideoUrl { get; set; }

        public string MusclesInvolved { get; set; }

        public string Equipment { get; set; }

        public List<Exercise> RelatedExercises { get; set; }
        
    }
}