using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Medicorum.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientList
{
    class GetPatientListQueryHandler : IRequestHandler<GetPatientListQuery, PatientListViewModel>
    {
        private readonly PatientDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientListQueryHandler(PatientDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PatientListViewModel> Handle(GetPatientListQuery request, CancellationToken cancellationToken)
        {
  
            var patients = await _context.People.OrderBy(p => p.LastName).Include(p => p.PersonRoles).ToListAsync(cancellationToken);

            var model = new PatientListViewModel
            {
                Patients = _mapper.Map<IEnumerable<PatientDto>>(patients),
                CreateEnabled = true
            };

            return model;
        }
    }
}
