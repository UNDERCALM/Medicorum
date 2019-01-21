using MediatR;
using Medicorum.Core.Interactors.MedicalHistory.Models;

namespace Medicorum.Core.Interactors.MedicalHistory.Queries
{
    public class GetPatientHistoryQuery : IRequest<MedicalHistoryModel>
    {
        public int Id { get; set; }
    }
}
