using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class Role
    {
        public Role()
        {
            PersonRoles = new HashSet<PersonRole>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<PersonRole> PersonRoles { get;}
    }
}
