using System.Linq;
namespace Medicorum.Core.Interactors.Interfaces
{
    
    public interface IMedicalHistoryItem
    {
        int PatientId { get; set; }
        int TypeId { get; set; }
        string Type { get; set; }
        string Label { get; set; }
        string Description { get; set; }
    }
}
