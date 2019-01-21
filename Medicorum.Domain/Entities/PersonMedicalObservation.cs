using System;
using System.Collections.Generic;

namespace Medicorum.Core.Entities.Entities
{
    public class PersonMedicalObservation
    {
        public PersonMedicalObservation()
        {
            PersonMeasurements = new HashSet<PersonMeasurement>();
        }
        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
       
        public bool IsActive { get; set; }
        public int PersonMedicalObservationTypeId { get; set; }
        public PersonMedicalObservationType PersonMedicalObservationType { get; set; }
        public int PersonMedicalEventId { get; set; }
        public PersonMedicalEvent PersonMedicalEvent { get; set; }
        private ICollection<PersonMeasurement> PersonMeasurements { get; }
    }
}
