using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsForms_Agenda_de_Activitati.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivitatiFamilie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    tip = table.Column<int>(nullable: false),
                    Detalii = table.Column<string>(nullable: true),
                    Prioritate = table.Column<string>(nullable: true),
                    Denumire = table.Column<string>(nullable: true),
                    dataActivitate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitatiFamilie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "evenimente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    tip = table.Column<int>(nullable: false),
                    Detalii = table.Column<string>(nullable: true),
                    Prioritate = table.Column<string>(nullable: true),
                    Denumire = table.Column<string>(nullable: true),
                    dataEveniment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evenimente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persoane",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nume = table.Column<string>(nullable: true),
                    grad_rudenie = table.Column<string>(nullable: true),
                    ActivitatiFamilieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoane", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persoane_ActivitatiFamilie_ActivitatiFamilieId",
                        column: x => x.ActivitatiFamilieId,
                        principalTable: "ActivitatiFamilie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persoane_ActivitatiFamilieId",
                table: "Persoane",
                column: "ActivitatiFamilieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evenimente");

            migrationBuilder.DropTable(
                name: "Persoane");

            migrationBuilder.DropTable(
                name: "ActivitatiFamilie");
        }
    }
}
