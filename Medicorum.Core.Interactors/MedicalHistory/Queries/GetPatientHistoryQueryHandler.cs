using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Exceptions;
using Medicorum.Core.Interactors.Interfaces;
using Medicorum.Core.Interactors.MedicalHistory.Models;
using Medicorum.Core.Interactors.Patients;
using Medicorum.Core.Interactors.Patients.Queries.PatientDetails;
using Medicorum.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Core.Interactors.MedicalHistory.Queries
{
    public class GetPatientHistoryQueryHandler : IRequestHandler<GetPatientHistoryQuery, MedicalHistoryModel>
    {
        private readonly PatientDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientHistoryQueryHandler(PatientDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<MedicalHistoryModel> Handle(GetPatientHistoryQuery request, CancellationToken cancellationToken)
        {
            var history = new PatientHistory(_context);
            var data = await history.GetPatientHistory<PatientHistoryItem>(request.Id);
            var patient = _context.People.SingleOrDefault(p => p.Id == request.Id);
            return new MedicalHistoryModel
            {
                PatientId = patient.Id,
                FirstName = patient.FirstName,
                BirthDate = patient.BirthDate,
                Gender = patient.BiologicGender,
                DriverLicenseNumber = patient.DriverLicenseNumber,
                LastName = patient.LastName,
                SSID = patient.SocialSecurityNumber,
                MedicalHistoryItems = new List<IMedicalHistoryItem>(data) 

            };
        }
    }
}
    