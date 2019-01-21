using System;
using System.Collections.Generic;

namespace Medicorum.Core.Entities.Entities
{
    public class PersonMedicalEvent
    {
        public PersonMedicalEvent()
        {
            _isOpen = true;
            PersonMedicalObservations = new HashSet<PersonMedicalObservation>();
        }
  
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public int PersonMedicalEventTypeId { get; set; }
        public PersonMedicalEventType PersonMedicalEventType { get;}
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<PersonMedicalObservation> PersonMedicalObservations { get;}
        private bool _isOpen;
        public bool IsOpen() => _isOpen;
        public void Close() => _isOpen = false;

    }
}
