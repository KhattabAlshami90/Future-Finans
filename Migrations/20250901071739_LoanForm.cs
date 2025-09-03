using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureFinans.Migrations
{
    /// <inheritdoc />
    public partial class LoanForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Years",
                table: "LoanApplications",
                newName: "LoanYears");

            migrationBuilder.AddColumn<int>(
                name: "ChildrenUnder21",
                table: "LoanApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HousingType",
                table: "LoanApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoanPurpose",
                table: "LoanApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "LoanApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildrenUnder21",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "HousingType",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "LoanPurpose",
                table: "LoanApplications");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "LoanApplications");

            migrationBuilder.RenameColumn(
                name: "LoanYears",
                table: "LoanApplications",
                newName: "Years");
        }
    }
}
