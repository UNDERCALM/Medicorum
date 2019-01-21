using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Medicorum.Core.Entities.Entities;
using Medicorum.Core.Interactors.Patients.Queries;
using Medicorum.Core.Interactors.Patients.Queries.PatientList;

namespace Medicorum.Core.Interactors.Patients
{
    public class PatientHistoryDto
    {
        public PatientHistoryDto()
        {
            HistoryItemDtos = new List<HistoryItemDto>();
        }

        public int PatientId { get; set; }

        public PatientDto PatientDto { get; set; }

        public ICollection<HistoryItemDto> HistoryItemDtos { get; set; }

        public static Expression<Func<Person, PatientHistoryDto>> Projection
        {
            get
            {
                return c => new PatientHistoryDto()
                {
                    PatientId = c.Id
                };
            }
        }
    }
}
