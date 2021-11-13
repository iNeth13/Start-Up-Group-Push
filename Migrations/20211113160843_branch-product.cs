using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Start_Up_Group.Migrations
{
    public partial class branchproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchProductId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchProductId",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BranchProduct",
                columns: table => new
                {
                    BranchProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchProduct", x => x.BranchProductId);
                    table.ForeignKey(
                        name: "FK_BranchProduct_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BranchProductId",
                table: "Products",
                column: "BranchProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchProduct_BranchId",
                table: "BranchProduct",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BranchProduct_BranchProductId",
                table: "Products",
                column: "BranchProductId",
                principalTable: "BranchProduct",
                principalColumn: "BranchProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BranchProduct_BranchProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "BranchProduct");

            migrationBuilder.DropIndex(
                name: "IX_Products_BranchProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BranchProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BranchProductId",
                table: "Branches");
        }
    }
}
