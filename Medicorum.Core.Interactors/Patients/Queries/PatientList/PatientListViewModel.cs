using System.Collections.Generic;
using Medicorum.Core.Interactors.Patients.Queries.Model;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientList
{
    public class PatientListViewModel
    {
        public IEnumerable<PatientDto> Patients { get; set; }
        public bool CreateEnabled { get; set; }
    }
}