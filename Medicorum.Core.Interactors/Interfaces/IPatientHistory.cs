using System.Linq;
using Medicorum.Core.Interactors.Interfaces;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public interface IPatientHistory
    {
        IQueryable<T> GetPatientHistory<T>(int id) where T : IMedicalHistoryItem, new();
        IQueryable<T> GetPatientHistoryByType<T>(int id, int historyType) where T : IMedicalHistoryItem, new();
        IQueryable<HistoryItemType> GetPatientHistoryItemsTypes(int id);
    }
}