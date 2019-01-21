using System.Collections.Generic;
using System.Threading.Tasks;
using Medicorum.Core.Interactors.MedicalHistory.Models;

namespace Medicorum.Core.Interactors.Interfaces
{
    public interface IPatientHistory
    {
        Task<List<T>> GetPatientHistory<T>(int id) where T : IMedicalHistoryItem, new();
        Task<List<T>> GetPatientHistoryByType<T>(int id, int historyType) where T : IMedicalHistoryItem, new();
        Task<List<HistoryItemType>> GetPatientHistoryItemsTypes(int id);
    }
}