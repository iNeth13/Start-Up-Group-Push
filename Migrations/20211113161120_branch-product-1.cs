using Microsoft.EntityFrameworkCore.Migrations;

namespace Start_Up_Group.Migrations
{
    public partial class branchproduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchProduct_Branches_BranchId",
                table: "BranchProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BranchProduct_BranchProductId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BranchProduct",
                table: "BranchProduct");

            migrationBuilder.RenameTable(
                name: "BranchProduct",
                newName: "BranchProducts");

            migrationBuilder.RenameIndex(
                name: "IX_BranchProduct_BranchId",
                table: "BranchProducts",
                newName: "IX_BranchProducts_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BranchProducts",
                table: "BranchProducts",
                column: "BranchProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchProducts_Branches_BranchId",
                table: "BranchProducts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchProducts_Branches_BranchId",
                table: "BranchProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BranchProducts_BranchProductId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BranchProducts",
                table: "BranchProducts");

            migrationBuilder.RenameTable(
                name: "BranchProducts",
                newName: "BranchProduct");

            migrationBuilder.RenameIndex(
                name: "IX_BranchProducts_BranchId",
                table: "BranchProduct",
                newName: "IX_BranchProduct_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BranchProduct",
                table: "BranchProduct",
                column: "BranchProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchProduct_Branches_BranchId",
                table: "BranchProduct",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BranchProduct_BranchProductId",
                table: "Products",
                column: "BranchProductId",
                principalTable: "BranchProduct",
                principalColumn: "BranchProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
