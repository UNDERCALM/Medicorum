using System.Collections.Generic;
using MediatR;
using Medicorum.Core.Interactors.Patients.Queries.PatientList;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientHistory
{
    public class GetPatientHistoryQuery : IRequest<PatientHistoryViewModel>
    {
        public int Id { get; set; }
    }
}
