using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarImport.Domain.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOrderAndCarFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarCost",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Currecy",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Cars",
                newName: "Currecy");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Cars",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<decimal>(
                name: "CarCost",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarCost",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Cars",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Currecy",
                table: "Cars",
                newName: "TypeId");

            migrationBuilder.AddColumn<decimal>(
                name: "CarCost",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Currecy",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
