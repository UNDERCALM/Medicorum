using System;
using System.Collections.Generic;
using System.Text;

namespace Medicorum.Core.Entities
{
    public class PersonMeasurementEvent
    {

        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public int PersonMeasurementId { get; set; }
        public PersonMeasurement PersonMeasurement { get; set; }
        public int PersonMedicalEventId { get; set; }
        public PersonMedicalEvent Type { get; set; }
    }
}
