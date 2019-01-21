using System;
using AutoMapper;
using Medicorum.Core.Interactors.Interfaces.Mapping;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientDetails
{
    public class PatientViewModel 
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSID { get; set; }
        public string DriverLicenseNumber { get; set; }
        public DateTime BithDate { get; set; }
        public string Gender { get; set; }
        public bool EditEnabled { get; set; }
        public bool DeleteEnabled { get; set; }

    }
}
