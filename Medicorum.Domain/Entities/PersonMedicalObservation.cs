using System;

namespace Medicorum.Core.Entities
{
    public class PersonMedicalObservation
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public int PersonMedicalObservationTypeId { get; set; }
        public bool IsActive { get; set; }
        public PersonMedicalObservationType PersonMedicalObservationType { get; set; }
    }
}
