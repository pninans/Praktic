using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Praktic.Data.Migrations
{
    public partial class ef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roles_employees_EmployeeId",
                table: "roles");

            migrationBuilder.DropIndex(
                name: "IX_roles_EmployeeId",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "roles");

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => new { x.EmployeesId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_EmployeeRole_employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_RolesId",
                table: "EmployeeRole",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_roles_EmployeeId",
                table: "roles",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_roles_employees_EmployeeId",
                table: "roles",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }
    }
}
