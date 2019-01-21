﻿// <auto-generated />
using System;
using Medicorum.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medicorum.Persistence.Migrations
{
    [DbContext(typeof(PatientDbContext))]
    partial class PatientDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BiologicGender");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("DriverLicenseNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("NationalIdentificationDocumentNumber");

                    b.Property<string>("SocialSecurityNumber");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMeasurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<double>("Measure");

                    b.Property<string>("Notes");

                    b.Property<int>("PersonMeasurementTypeId");

                    b.Property<int>("PersonMedicalObservationId");

                    b.Property<DateTime?>("ThruDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonMeasurementTypeId");

                    b.HasIndex("PersonMedicalObservationId");

                    b.ToTable("PersonMeasurements");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMeasurementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("UnitOfMeasure");

                    b.HasKey("Id");

                    b.ToTable("PersonMeasurementTypes");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("PersonId");

                    b.Property<int>("PersonMedicalEventTypeId");

                    b.Property<DateTime?>("ThruDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonMedicalEventTypeId");

                    b.ToTable("PersonMedicalEvents");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalEventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("PersonMedicalEventTypes");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalObservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Label");

                    b.Property<int>("PersonMedicalEventId");

                    b.Property<int>("PersonMedicalObservationTypeId");

                    b.Property<string>("Text");

                    b.Property<DateTime?>("ThruDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonMedicalEventId");

                    b.HasIndex("PersonMedicalObservationTypeId");

                    b.ToTable("PersonMedicalObservations");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalObservationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("PersonMedicalObservationTypes");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Note");

                    b.Property<int>("PersonId");

                    b.Property<int>("RoleId");

                    b.Property<DateTime?>("ThruDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.ToTable("PersonRoles");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.RoleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("RoleTypes");
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMeasurement", b =>
                {
                    b.HasOne("Medicorum.Core.Entities.Entities.PersonMeasurementType", "PersonMeasurementType")
                        .WithMany("PersonMeasurements")
                        .HasForeignKey("PersonMeasurementTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Medicorum.Core.Entities.Entities.PersonMedicalObservation", "PersonMeasurementEvent")
                        .WithMany()
                        .HasForeignKey("PersonMedicalObservationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalEvent", b =>
                {
                    b.HasOne("Medicorum.Core.Entities.Entities.Person", "Person")
                        .WithMany("PersonMedicalEvents")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Medicorum.Core.Entities.Entities.PersonMedicalEventType")
                        .WithMany("PersonMedicalEvents")
                        .HasForeignKey("PersonMedicalEventTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonMedicalObservation", b =>
                {
                    b.HasOne("Medicorum.Core.Entities.Entities.PersonMedicalEvent", "PersonMedicalEvent")
                        .WithMany("PersonMedicalObservations")
                        .HasForeignKey("PersonMedicalEventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Medicorum.Core.Entities.Entities.PersonMedicalObservationType", "PersonMedicalObservationType")
                        .WithMany("PersonMedicalObservations")
                        .HasForeignKey("PersonMedicalObservationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Medicorum.Core.Entities.Entities.PersonRole", b =>
                {
                    b.HasOne("Medicorum.Core.Entities.Entities.Person", "Person")
                        .WithMany("PersonRoles")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Medicorum.Core.Entities.Entities.RoleType", "Role")
                        .WithMany("PersonRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
