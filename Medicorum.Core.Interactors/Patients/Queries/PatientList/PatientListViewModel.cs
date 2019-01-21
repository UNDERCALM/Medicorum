using System.Collections.Generic;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientList
{
    public class PatientListViewModel
    {
        public IEnumerable<PatientDto> Patients { get; set; }
        public bool CreateEnabled { get; set; }
    }
}