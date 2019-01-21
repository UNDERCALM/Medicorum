using System.Linq;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Interfaces;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public interface IPatient
    {
 

        IQueryable<T> GetPatientHistory<T>() where T : IMedicalHistoryItem, new();
        IQueryable<T> GetPatientHistoryByType<T>(int historyType) where T : IMedicalHistoryItem, new();
        IQueryable<HistoryItemType> GetPatientHistoryItemsTypes();
        void SetPatient(int patientId);
    }
}