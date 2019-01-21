using AutoMapper;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Interfaces;
using Medicorum.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public abstract class PatientHistory : IPatientHistory
    {
        private readonly PatientDbContext _context;
        public PatientHistory(PatientDbContext context, IMapper mapper)
        {
            _context = context;
           
        }


        public IQueryable<T> GetPatientHistory<T>(int id) where T: IMedicalHistoryItem, new()
        {
            return _context.PersonMedicalObservations.Where(o => o.PersonMedicalEvent.PersonId == id)
                .Select(o =>
                new T
                {
                    PatientId = o.Id,
                    TypeId = o.PersonMedicalObservationTypeId,
                    Type = o.PersonMedicalObservationType.Description,
                    Label = o.Label,
                    Description = o.Description
                } );
        }

        public IQueryable<T> GetPatientHistoryByType<T>(int id,int historyType) where T: IMedicalHistoryItem, new()
        {
            return _context.PersonMedicalObservations.Where(o => o.PersonMedicalEvent.PersonId == id && o.Id == historyType)
                .Select(o => 
                new T
                {
                    PatientId = o.Id,
                    TypeId  = o.PersonMedicalObservationTypeId,
                    Type  = o.PersonMedicalObservationType.Description,
                    Label = o.Label,
                    Description = o.Description
                });
        }

        public IQueryable<HistoryItemType> GetPatientHistoryItemsTypes(int id)
        {
           
                return _context.PersonMedicalObservations.Where(p => p.PersonMedicalEvent.PersonId == id)
                .Select(s => new HistoryItemType
                {
                    TypeId = s.Id,
                    TypeDescription = s.Description
                });

          

        }

     
    }
}
