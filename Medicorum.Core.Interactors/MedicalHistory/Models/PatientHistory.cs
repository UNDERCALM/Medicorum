using System.Collections.Generic;
using Medicorum.Core.Interactors.Interfaces;
using Medicorum.Persistence;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public class PatientHistory : IPatientHistory
    {
        private readonly PatientDbContext _context;
        public PatientHistory(PatientDbContext context)
        {
            _context = context;
        }


        public async Task<List<T>> GetPatientHistory<T>(int id) where T: IMedicalHistoryItem, new()
        {
            return await _context.PersonMedicalObservations.Where(o => o.PersonMedicalEvent.PersonId == id)
                .Select(o =>
                new T
                {
                    PatientId = o.Id,
                    TypeId = o.PersonMedicalObservationTypeId,
                    Type = o.PersonMedicalObservationType.Description,
                    Label = o.Label,
                    Description = o.Description
                } ).ToListAsync();
        }

        public async Task<List<T>> GetPatientHistoryByType<T>(int id,int historyType) where T: IMedicalHistoryItem, new()
        {
            return await _context.PersonMedicalObservations.Where(o => o.PersonMedicalEvent.PersonId == id && o.Id == historyType)
                .Select(o => 
                new T
                {
                    PatientId = o.Id,
                    TypeId  = o.PersonMedicalObservationTypeId,
                    Type  = o.PersonMedicalObservationType.Description,
                    Label = o.Label,
                    Description = o.Description
                }).ToListAsync();
        }

        public async Task<List<HistoryItemType>> GetPatientHistoryItemsTypes(int id)
        {
           
                return await _context.PersonMedicalObservations.Where(p => p.PersonMedicalEvent.PersonId == id)
                .Select(s => new HistoryItemType
                {
                    TypeId = s.Id,
                    TypeDescription = s.Description
                }).ToListAsync();



        }

     
    }
}
