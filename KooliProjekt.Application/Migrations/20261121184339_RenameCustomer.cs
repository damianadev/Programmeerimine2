
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Application.Migrations
{
    /// <inheritdoc />
    public partial class RenameCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "LoggedIn",
                table: "Users",
                newName: "IsAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_CustomerName",
                table: "Users",
                newName: "IX_Users_UserName");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reservations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Invoices",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservations",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Invoices",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserName",
                table: "Users",
                newName: "IX_Customers_CustomerName");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "LoggedIn");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Customers");
        }
    }
}
