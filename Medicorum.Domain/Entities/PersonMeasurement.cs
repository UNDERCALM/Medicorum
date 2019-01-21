using System;
using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class PersonMeasurement
    {
        public PersonMeasurement()
        {
            MeasurementEvents = new HashSet<PersonMeasurementEvent>();
        }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public double Measure { get; set; }
        public int PersonMeasurementTypeId { get; set; }
        public PersonMeasurementType PersonMeasurementType { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public ICollection<PersonMeasurementEvent> MeasurementEvents { get; set; }
    }
}
