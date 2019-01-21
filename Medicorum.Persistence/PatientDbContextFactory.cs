using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Persistence
{
    class PatientDbContextFactory : DesignTimeDbContextFactoryBase<PatientDbContext>
    {
        protected override PatientDbContext CreateNewInstance(DbContextOptions<PatientDbContext> options)
        {
            return new PatientDbContext(options);
        }
    }
}
