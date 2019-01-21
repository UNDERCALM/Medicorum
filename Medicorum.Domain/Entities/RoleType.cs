using System.Collections.Generic;

namespace Medicorum.Core.Entities.Entities
{
    public class RoleType
    {
        public RoleType()
        {
            PersonRoles = new HashSet<PersonRole>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<PersonRole> PersonRoles { get;}
    }
}
