using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCom.DataAccessLayer.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditNo = table.Column<int>(type: "int", nullable: false),
                    CreditUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditUserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cvv = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credits");
        }
    }
}
