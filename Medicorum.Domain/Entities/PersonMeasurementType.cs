using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class PersonMeasurementType
    {
        public PersonMeasurementType()
        {
            PersonMeasurements = new HashSet<PersonMeasurement>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public ICollection<PersonMeasurement> PersonMeasurements { get; }
    }
}
