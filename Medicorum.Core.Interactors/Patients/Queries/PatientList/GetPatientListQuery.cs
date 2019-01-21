using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientList
{
    public class GetPatientListQuery : IRequest<PatientListViewModel>
    {
    }
}
