using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medicorum.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    BiologicGender = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    NationalIdentificationDocumentNumber = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<string>(nullable: true),
                    DriverLicenseNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonMeasurementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    UnitOfMeasure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMeasurementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonMedicalEventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMedicalEventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonMedicalObservationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMedicalObservationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonMedicalEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ThruDate = table.Column<DateTime>(nullable: true),
                    PersonMedicalEventTypeId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMedicalEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonMedicalEvents_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonMedicalEvents_PersonMedicalEventTypes_PersonMedicalEventTypeId",
                        column: x => x.PersonMedicalEventTypeId,
                        principalTable: "PersonMedicalEventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ThruDate = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonRoles_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonRoles_RoleTypes_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonMedicalObservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ThruDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PersonMedicalObservationTypeId = table.Column<int>(nullable: false),
                    PersonMedicalEventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMedicalObservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonMedicalObservations_PersonMedicalEvents_PersonMedicalEventId",
                        column: x => x.PersonMedicalEventId,
                        principalTable: "PersonMedicalEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonMedicalObservations_PersonMedicalObservationTypes_PersonMedicalObservationTypeId",
                        column: x => x.PersonMedicalObservationTypeId,
                        principalTable: "PersonMedicalObservationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ThruDate = table.Column<DateTime>(nullable: true),
                    Measure = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PersonMeasurementTypeId = table.Column<int>(nullable: false),
                    PersonMedicalObservationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonMeasurements_PersonMeasurementTypes_PersonMeasurementTypeId",
                        column: x => x.PersonMeasurementTypeId,
                        principalTable: "PersonMeasurementTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonMeasurements_PersonMedicalObservations_PersonMedicalObservationId",
                        column: x => x.PersonMedicalObservationId,
                        principalTable: "PersonMedicalObservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonMeasurements_PersonMeasurementTypeId",
                table: "PersonMeasurements",
                column: "PersonMeasurementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMeasurements_PersonMedicalObservationId",
                table: "PersonMeasurements",
                column: "PersonMedicalObservationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMedicalEvents_PersonId",
                table: "PersonMedicalEvents",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMedicalEvents_PersonMedicalEventTypeId",
                table: "PersonMedicalEvents",
                column: "PersonMedicalEventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMedicalObservations_PersonMedicalEventId",
                table: "PersonMedicalObservations",
                column: "PersonMedicalEventId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonMedicalObservations_PersonMedicalObservationTypeId",
                table: "PersonMedicalObservations",
                column: "PersonMedicalObservationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRoles_PersonId",
                table: "PersonRoles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonRoles_RoleId",
                table: "PersonRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonMeasurements");

            migrationBuilder.DropTable(
                name: "PersonRoles");

            migrationBuilder.DropTable(
                name: "PersonMeasurementTypes");

            migrationBuilder.DropTable(
                name: "PersonMedicalObservations");

            migrationBuilder.DropTable(
                name: "RoleTypes");

            migrationBuilder.DropTable(
                name: "PersonMedicalEvents");

            migrationBuilder.DropTable(
                name: "PersonMedicalObservationTypes");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "PersonMedicalEventTypes");
        }
    }
}
