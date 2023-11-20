using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarImport.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateControllerNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Currecy",
                table: "Cars",
                newName: "Currenecies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Currenecies",
                table: "Cars",
                newName: "Currecy");
        }
    }
}
