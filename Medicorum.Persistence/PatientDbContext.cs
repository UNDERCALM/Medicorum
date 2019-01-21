using System;
using System.Collections.Generic;
using System.Text;
using Medicorum.Core;
using Medicorum.Core.Entities;
using Medicorum.Core.Entities.Entities;
using Medicorum.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Medicorum.Persistence
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<PersonMedicalEventType> PersonMedicalEventTypes { get; set; }
        public DbSet<PersonMedicalEvent> PersonMedicalEvents { get; set; }
        public DbSet<PersonMedicalObservationType> PersonMedicalObservationTypes { get; set; }
        public DbSet<PersonMedicalObservation> PersonMedicalObservations { get; set; }
        public DbSet<PersonMeasurementType> PersonMeasurementTypes { get; set; }
        public DbSet<PersonMeasurement> PersonMeasurements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
