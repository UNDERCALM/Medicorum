using System;
using System.Collections.Generic;

namespace Medicorum.Core.Entities
{
    public class Person
    {
        public Person()
        {
            PersonRoles = new HashSet<PersonRole>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string BiologicGender { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalIdentificationDocumentNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
        public ICollection<PersonRole> PersonRoles { get; }
        int Age => ( BirthDate.DayOfYear < DateTime.Now.DayOfYear ) ?
            ( BirthDate.Year - DateTime.Now.Year ) - 1 : 
            ( BirthDate.Year - DateTime.Now.Year );
    }
}
