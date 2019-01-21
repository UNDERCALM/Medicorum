using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Exceptions;
using Medicorum.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientHistory
{
    public class GetPatientHistoryQueryHandler : IRequestHandler<GetPatientHistoryQuery, PatientHistoryViewModel>
    {
        private readonly PatientDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientHistoryQueryHandler(PatientDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PatientHistoryViewModel> Handle(GetPatientHistoryQuery request, CancellationToken cancellationToken)
        {
            var patient = await _context.People.Where(p => p.Id == request.Id).SingleOrDefaultAsync(cancellationToken);
            if (patient == null)
            {
                throw new NotFoundException(nameof(Person), request.Id);
            }

            var histories = await _context.PersonMedicalObservations.Where(o => o.PersonMedicalEvent.PersonId == patient.Id).ToListAsync(cancellationToken);
            if (histories == null)
            {
                throw new NotFoundException(nameof(PersonMedicalObservation), request.Id);
            }
            return new PatientHistoryViewModel
            {
                PatientId = patient.Id,
                PatientHistoryItems = _mapper.Map<IEnumerable<HistoryItemDto>>(histories)

            };
        }
    }
}
