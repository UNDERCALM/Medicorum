using System;

namespace Medicorum.Core.Entities
{
    public class PersonRole
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public string Note { get; set; }
    }
}
