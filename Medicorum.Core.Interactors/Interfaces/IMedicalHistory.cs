using System.Linq;
using Medicorum.Core.Interactors.MedicalHistory.Models;

namespace Medicorum.Core.Interactors.Interfaces
{
    public interface IMedicalHistory
    {
        void SetPatient(int patientId);
        void GenerateAll();
        int GetPatientId();
        IPatient GetPatient();
        IMedicalHistoryDto GetMedicalHistoryDto();
    }
}
