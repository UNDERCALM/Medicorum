using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientDetails
{
    public class GetPatientQuery : IRequest<PatientViewModel>
    {
        public int Id { get; set; }
    }
}
