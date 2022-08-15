using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smartwallet1.web.Migrations
{
    public partial class newwest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_Email",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "Middlename");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maritalstatus",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Maritalstatus",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Customers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Middlename",
                table: "Customers",
                newName: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                table: "Customers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers",
                column: "PhoneNumber",
                unique: true);
        }
    }
}
