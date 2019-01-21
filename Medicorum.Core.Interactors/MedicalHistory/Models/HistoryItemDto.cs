using System;
using System.Linq.Expressions;
using AutoMapper;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Interfaces.Mapping;

namespace Medicorum.Core.Interactors.Patients.Queries
{
    public class HistoryItemDto : IHaveCustomMapping
    {
        public int HistoryItemId { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public int ItemTypeId { get; set; }
        public DateTime Date { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<PersonMedicalObservation, HistoryItemDto>()
                .ForMember(p => p.HistoryItemId, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.Label, opt => opt.MapFrom(p => p.Label))
                .ForMember(p => p.Description, opt => opt.MapFrom(p => p.Description))
                .ForMember(p => p.ItemTypeId, opt => opt.MapFrom(p => p.PersonMedicalObservationTypeId))
                .ForMember(p => p.ItemType, opt => opt.MapFrom(p => p.PersonMedicalObservationType.Description));
        }
    }
}
