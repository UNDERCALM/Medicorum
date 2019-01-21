using Medicorum.Core.Interactors.Interfaces;

namespace Medicorum.Core.Interactors.MedicalHistory.Models
{
    public class PatientHistoryItem : IMedicalHistoryItem
    {
        public int PatientId { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
