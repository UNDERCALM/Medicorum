using System.Linq;
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
