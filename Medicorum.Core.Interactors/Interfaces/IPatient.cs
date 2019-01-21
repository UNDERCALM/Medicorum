using System.Linq;
using Medicorum.Core.Interactors.MedicalHistory.Models;

namespace Medicorum.Core.Interactors.Interfaces
{
    public interface IPatient
    {
 

        IQueryable<T> GetPatientHistory<T>() where T : IMedicalHistoryItem, new();
        IQueryable<T> GetPatientHistoryByType<T>(int historyType) where T : IMedicalHistoryItem, new();
        IQueryable<HistoryItemType> GetPatientHistoryItemsTypes();
        void SetPatient(int patientId);
    }
}