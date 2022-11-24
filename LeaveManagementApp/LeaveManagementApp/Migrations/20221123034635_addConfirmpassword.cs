using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagementApp.Migrations
{
    public partial class addConfirmpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Users",
                nullable: true);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Users");*/
        }
    }
}
