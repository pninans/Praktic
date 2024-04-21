using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktic.Data.Migrations
{
    public partial class deleteroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roles_employees_EmployeeId",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_roles_EmployeeId",
                table: "Role",
                newName: "IX_Role_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_employees_EmployeeId",
                table: "Role",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_employees_EmployeeId",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "roles");

            migrationBuilder.RenameIndex(
                name: "IX_Role_EmployeeId",
                table: "roles",
                newName: "IX_roles_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_roles_employees_EmployeeId",
                table: "roles",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }
    }
}
