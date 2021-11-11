using Microsoft.EntityFrameworkCore.Migrations;

namespace Start_Up_Group.Migrations
{
    public partial class fixtablesnotexist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Manager_ManagerId",
                table: "Branches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manager",
                table: "Manager");

            migrationBuilder.RenameTable(
                name: "Manager",
                newName: "Managers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Managers",
                table: "Managers",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Managers_ManagerId",
                table: "Branches",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Managers_ManagerId",
                table: "Branches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Managers",
                table: "Managers");

            migrationBuilder.RenameTable(
                name: "Managers",
                newName: "Manager");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manager",
                table: "Manager",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Manager_ManagerId",
                table: "Branches",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
