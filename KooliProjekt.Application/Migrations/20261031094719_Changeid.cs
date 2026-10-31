using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KooliProjekt.Application.Migrations
{
    /// <inheritdoc />
    public partial class Changeid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reservations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Invoices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "InvoiceLines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cars",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CarModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CarManufacturers",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reservations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Invoices",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InvoiceLines",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CarModels",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CarManufacturers",
                newName: "id");
        }
    }
}
