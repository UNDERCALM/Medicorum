using System.Collections.Generic;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientHistory
{
    public class PatientHistoryViewModel
    {
        public int PatientId { get; set; }

        public IEnumerable<HistoryItemDto> PatientHistoryItems { get; set; }
        
    }
}
