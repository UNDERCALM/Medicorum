using System;
using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class PersonMedicalEvent
    {
        public PersonMedicalEvent()
        {
            _isOpen = true;
            MeasurementEvents = new HashSet<PersonMeasurementEvent>();
        }
  
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public int PersonMedicalEventTypeId { get; set; }
        public PersonMedicalEventType PersonMedicalEventType { get; set; }
        public ICollection<PersonMeasurementEvent> MeasurementEvents { get; set; }
        private bool _isOpen;
        public bool IsOpen() => _isOpen;
        public void Close() => _isOpen = false;

    }
}
