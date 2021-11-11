using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Start_Up_Group.Migrations
{
    public partial class addfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_at",
                table: "Manager",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Deleted_by",
                table: "Manager",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_at",
                table: "Branches",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Deleted_by",
                table: "Branches",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted_at",
                table: "Manager");

            migrationBuilder.DropColumn(
                name: "Deleted_by",
                table: "Manager");

            migrationBuilder.DropColumn(
                name: "Deleted_at",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "Deleted_by",
                table: "Branches");
        }
    }
}
