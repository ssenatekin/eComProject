using Microsoft.EntityFrameworkCore.Migrations;

namespace eCom.DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BItemPrice = table.Column<int>(type: "int", nullable: false),
                    BItemImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BItemQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BItems");
        }
    }
}
