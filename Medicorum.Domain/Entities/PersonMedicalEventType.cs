using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class PersonMedicalEventType
    {
        public PersonMedicalEventType()
        {
            PersonMedicalEvents = new HashSet<PersonMedicalEvent>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<PersonMedicalEvent> PersonMedicalEvents { get; }
    }
}
