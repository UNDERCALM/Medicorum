using System;
using AutoMapper;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Interfaces.Mapping;

namespace Medicorum.Core.Interactors.Patients.Queries
{
    public class PatientDto : IHaveCustomMapping
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSID { get; set; }
        public string DriverLicenseNumber{ get; set; }
        public DateTime BithDate { get; set; }
        public string Gender { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Person, PatientDto>()
                .ForMember(p => p.PatientId, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.FirstName, opt => opt.MapFrom(p => p.FirstName))
                .ForMember(p => p.LastName, opt => opt.MapFrom(p => p.LastName))
                .ForMember(p => p.BithDate, opt => opt.MapFrom(p => p.BirthDate))
                .ForMember(p => p.Gender, opt => opt.MapFrom(p => p.BiologicGender))
                .ForMember(p => p.DriverLicenseNumber, opt => opt.MapFrom(p => p.DriverLicenseNumber))
                .ForMember(p => p.SSID, opt => opt.MapFrom(p => p.SocialSecurityNumber));
        }
       
    }
}
