using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Exceptions;
using Medicorum.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Core.Interactors.Patients.Queries.PatientDetails
{
    public class GetPatientQueryHandler : IRequestHandler<GetPatientQuery, PatientViewModel>
    {
        private readonly PatientDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientQueryHandler(PatientDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PatientViewModel> Handle(GetPatientQuery request, CancellationToken cancellationToken)
        {
            var patient = await _context.People.Where(p => p.Id == request.Id).SingleOrDefaultAsync(cancellationToken);
            if (patient == null)
            {
                throw new NotFoundException(nameof(Person), request.Id);
            }
            return new PatientViewModel
            {
                PatientId = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                BithDate = patient.BirthDate,
                Gender = patient.BiologicGender,
                SSID = patient.SocialSecurityNumber,
                DriverLicenseNumber = patient.DriverLicenseNumber,
                EditEnabled = true,
                DeleteEnabled = false

            };


        }
    }
}
