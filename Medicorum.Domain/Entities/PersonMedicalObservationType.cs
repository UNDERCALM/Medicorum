using System.Collections.Generic;

namespace Medicorum.Core.Entities.Entities
{
    public class PersonMedicalObservationType
    {
        public PersonMedicalObservationType()
        {
            PersonMedicalObservations = new HashSet<PersonMedicalObservation>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<PersonMedicalObservation> PersonMedicalObservations { get; }
    }
}
