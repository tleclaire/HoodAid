using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoodAid.Migrations
{
    public partial class hoodaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaryEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<DateTime>(nullable: false),
                    Activity = table.Column<string>(nullable: true),
                    Temperature = table.Column<decimal>(nullable: false),
                    Husten = table.Column<int>(nullable: false),
                    Kurzatmigkeit = table.Column<bool>(nullable: false),
                    Atemnot = table.Column<bool>(nullable: false),
                    Gliederschmerzen = table.Column<bool>(nullable: false),
                    Durchfall = table.Column<bool>(nullable: false),
                    GeruchssinnVerlust = table.Column<bool>(nullable: false),
                    Muedigkeit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthAuthorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAuthorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vorname = table.Column<string>(nullable: true),
                    Nachname = table.Column<string>(nullable: true),
                    Plz = table.Column<string>(nullable: true),
                    Ort = table.Column<string>(nullable: true),
                    Strasse = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Duration = table.Column<int>(nullable: true),
                    DiaryEntryId = table.Column<int>(nullable: true),
                    HealthAuthorityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_DiaryEntries_DiaryEntryId",
                        column: x => x.DiaryEntryId,
                        principalTable: "DiaryEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_HealthAuthorities_HealthAuthorityId",
                        column: x => x.HealthAuthorityId,
                        principalTable: "HealthAuthorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Image", "Nachname", "Ort", "Plz", "Strasse", "Vorname" },
                values: new object[] { 1L, null, null, "Lelaire", "Kaltenkirchen", "24568", "Rosmarinweg 5", "Thomas" });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DiaryEntryId",
                table: "Persons",
                column: "DiaryEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_HealthAuthorityId",
                table: "Persons",
                column: "HealthAuthorityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Symptoms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DiaryEntries");

            migrationBuilder.DropTable(
                name: "HealthAuthorities");
        }
    }
}
