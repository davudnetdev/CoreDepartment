using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "depId",
                table: "Personals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personals_depId",
                table: "Personals",
                column: "depId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_depId",
                table: "Personals",
                column: "depId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_depId",
                table: "Personals");

            migrationBuilder.DropIndex(
                name: "IX_Personals_depId",
                table: "Personals");

            migrationBuilder.DropColumn(
                name: "depId",
                table: "Personals");
        }
    }
}
