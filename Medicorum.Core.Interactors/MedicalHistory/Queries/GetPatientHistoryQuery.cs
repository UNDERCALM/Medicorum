using MediatR;
using Medicorum.Core.Interactors.Patients.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medicorum.Core.Interactors.MedicalHistory.Queries
{
    class GetPatientHistoryQuery : IRequest<MedicalHistoryModel>
    {
    }
}
