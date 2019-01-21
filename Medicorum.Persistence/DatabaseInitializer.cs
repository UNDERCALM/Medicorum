using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Medicorum.Core.Entities.Entities;

namespace Medicorum.Persistence
{
    public class DatabaseInitializer
    {
        public static void Initialize(PatientDbContext context)
        {
            var initializer = new DatabaseInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(PatientDbContext context)
        {
            context.Database.EnsureCreated();
            

            if (context.People.Any() == false)
                SeedPeople(context);

            if (context.RoleTypes.Any() == false)
                SeedRoleTypes(context);
            if (context.PersonRoles.Any() == false)
                SeedPersonRoles(context);

            if (context.PersonMedicalEventTypes.Any() == false)
                SeedPersonMedicalEventTypes(context);
            if (context.PersonMedicalEvents.Any() == false)
                SeedPersonMedicalEvents(context);

            if (context.PersonMedicalObservationTypes.Any() == false)
                SeedPersonMedicalObservationTypes(context);
            if (context.PersonMedicalObservations.Any() == false)
                SeedPersonMedicalObservations(context);

            if (context.PersonMeasurementTypes.Any() == false)
                SeedPersonMeasurementTypes(context);
            if (context.PersonMeasurements.Any() == false)
                SeedPersonMeasurements(context);

        }
        private void SeedRoleTypes(PatientDbContext context)
        {

            var roleTypes = new[]
            {
                new RoleType {Description = "Doctor"},
                new RoleType {Description = "Patient"},
                new RoleType {Description = "Assistant"}
            };
            context.RoleTypes.AddRange(roleTypes);
            context.SaveChanges();
        }
        private void SeedPeople(PatientDbContext context)
        {
            var people = new[]
            {
                new Person {FirstName = "Bruce", LastName = "Banner", MiddleName = "Green", BiologicGender = "Male", BirthDate = DateTime.Parse("1-1-1990"), DriverLicenseNumber = "D90897867", NationalIdentificationDocumentNumber = "N/A", SocialSecurityNumber = "123-12-12234"},
                new Person {FirstName = "Clint", LastName = "Barton", MiddleName = "Arrow", BiologicGender = "Female", BirthDate = DateTime.Parse("1-1-1978"), DriverLicenseNumber = "D90897868", NationalIdentificationDocumentNumber = "N/A", SocialSecurityNumber = "321-12-12234"},
                new Person {FirstName = "Peter", LastName = "Parker", MiddleName = "Spider", BiologicGender = "Male", BirthDate = DateTime.Parse("1-1-1995"), DriverLicenseNumber = "D90897869", NationalIdentificationDocumentNumber = "N/A", SocialSecurityNumber = "123-21-12234"},
                new Person {FirstName = "Tony", LastName = "Stark", MiddleName = "Iron", BiologicGender = "Male", BirthDate = DateTime.Parse("1-1-1991"), DriverLicenseNumber = "D90897877", NationalIdentificationDocumentNumber = "N/A", SocialSecurityNumber = "123-12-21234"},
                new Person {FirstName = "Groot", LastName = "Tree", MiddleName = "Small", BiologicGender = "Male", BirthDate = DateTime.Parse("1-1-1967"), DriverLicenseNumber = "D90897868", NationalIdentificationDocumentNumber = "N/A", SocialSecurityNumber = "123-12-12324"},
            };
            context.People.AddRange(people);
            context.SaveChanges();
        }
        private void SeedPersonRoles(PatientDbContext context)
        {
            try
            {
                var personRoles = new[]
                {

                    new PersonRole
                    {
                        FromDate = DateTime.Now,
                        PersonId = context.People.FirstOrDefault(p => p.FirstName.Contains("Bruce")).Id,
                        RoleId = context.RoleTypes.FirstOrDefault(r => r.Description.Contains("Doctor")).Id
                    },
                    new PersonRole
                    {
                        FromDate = DateTime.Now,
                        PersonId = context.People.FirstOrDefault(p => p.FirstName.Contains("Clint")).Id,
                        RoleId = context.RoleTypes.FirstOrDefault(r => r.Description.Contains("Patient")).Id
                    },
                    new PersonRole
                    {
                        FromDate = DateTime.Now,
                        PersonId = context.People.FirstOrDefault(p => p.FirstName.Contains("Clint")).Id,
                        RoleId = context.RoleTypes.FirstOrDefault(r => r.Description.Contains("Patient")).Id
                    }

                };
                context.PersonRoles.AddRange(personRoles);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        private void SeedPersonMedicalEventTypes(PatientDbContext context)
        {

            var personMedicalEventTypes = new[]
            {
                new PersonMedicalEventType {Description = "Medical Consultation"},
                new PersonMedicalEventType {Description = "Emergency Consultation"},
                new PersonMedicalEventType {Description = "Illness"},
                new PersonMedicalEventType {Description = "Surgery"},
                new PersonMedicalEventType {Description = "Emergency"},
                new PersonMedicalEventType {Description = "Allergy"},
                new PersonMedicalEventType {Description = "Medication"},
                new PersonMedicalEventType {Description = "Diagnose"},
                new PersonMedicalEventType {Description = "Physical Examination"},
                new PersonMedicalEventType {Description = "Diagnose Test Results"},
                new PersonMedicalEventType {Description = "Review of System"}
            };
            context.PersonMedicalEventTypes.AddRange(personMedicalEventTypes);
            context.SaveChanges();
        }
        private void SeedPersonMedicalEvents(PatientDbContext context)
        {
            try
            {

                var PersonMedicalEvents = new[]
                {

                    new PersonMedicalEvent
                    {
                        FromDate = DateTime.Now,
                        PersonId = context.People.FirstOrDefault(p => p.FirstName.Contains("Clint")).Id,
                        PersonMedicalEventTypeId = context.PersonMedicalEventTypes.FirstOrDefault(e=>e.Description.Contains("Diagnose Test Result")).Id

                    },


                };
                context.PersonMedicalEvents.AddRange(PersonMedicalEvents);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private void SeedPersonMedicalObservationTypes(PatientDbContext context)
        {
            var personMedicalObservationTypes = new[]
            {
                new PersonMedicalObservationType {Description = "Diagnose"},
                new PersonMedicalObservationType {Description = "Measurement"},
                new PersonMedicalObservationType {Description = "Allergy"},
                new PersonMedicalObservationType {Description = "Medication"},
                new PersonMedicalObservationType {Description = "Physical Examination Result"},
                new PersonMedicalObservationType {Description = "Diagnose Test Result"},
                new PersonMedicalObservationType {Description = "Review of System Result"},
                new PersonMedicalObservationType {Description = "Illness"},
                new PersonMedicalObservationType {Description = "Surgery"},
                new PersonMedicalObservationType {Description = "Social History"},
                new PersonMedicalObservationType {Description = "Family History"},
                new PersonMedicalObservationType {Description = "Assessment Plan"}

            };
            context.PersonMedicalObservationTypes.AddRange(personMedicalObservationTypes);
            context.SaveChanges();
        }
        private void SeedPersonMedicalObservations(PatientDbContext context)
        {
            try
            {

                var PersonMedicalObservations = new[]
                {

                    new PersonMedicalObservation
                    {
                        FromDate = DateTime.Now,
                        Label = "Pertinent Diagnostic Tests",
                        Description = "Test results from a laboratory",
                        IsActive = true, Text = "To design an assessment plan",
                        PersonMedicalEventId = context.PersonMedicalEvents.FirstOrDefault(p => p.Person.FirstName.Contains("Clint")).Id,
                        PersonMedicalObservationTypeId =  context.PersonMedicalObservationTypes.FirstOrDefault(e=>e.Description.Contains("Diagnose Test Result")).Id
                    },


                };
                context.PersonMedicalObservations.AddRange(PersonMedicalObservations);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private void SeedPersonMeasurementTypes(PatientDbContext context)
        {
            var personMeasurementTypes = new[]
            {
                new PersonMeasurementType {Description = "Height", UnitOfMeasure = "Mts."},
                new PersonMeasurementType {Description = "Weight", UnitOfMeasure = "Kgs."},
                new PersonMeasurementType {Description = "Blood Pressure", UnitOfMeasure = "mmHg"},
                new PersonMeasurementType {Description = "Na", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "K", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Cl", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Co2", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "BUN", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Cr", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Ca", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Mg", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "P", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "PTT", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "WBC", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Hgb", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Hct", UnitOfMeasure = "ppm"},
                new PersonMeasurementType {Description = "Plt", UnitOfMeasure = "ppm"}
            };
            context.PersonMeasurementTypes.AddRange(personMeasurementTypes);
            context.SaveChanges();
        }
        private void SeedPersonMeasurements(PatientDbContext context)
        {
            try
            {
                var personMeasuremets = new[]
                {

                    new PersonMeasurement
                    {
                        FromDate = DateTime.Now,
                        Description = "Patient Height in Meters",
                        Measure = 1.8,
                        Notes = "",
                        PersonMeasurementTypeId = 1,
                        PersonMedicalObservationId = 1
                    },
                    new PersonMeasurement
                    {
                        FromDate = DateTime.Now,
                        Description = "Patient Weight in Kilograms",
                        Measure = 82.4,
                        Notes = "",
                        PersonMeasurementTypeId = 2,
                        PersonMedicalObservationId = 1
                    }
                    

                };
                context.PersonMeasurements.AddRange(personMeasuremets);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        

        

        

        

        

        
    }
}