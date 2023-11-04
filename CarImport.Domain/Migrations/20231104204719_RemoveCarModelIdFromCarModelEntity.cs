using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarImport.Domain.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCarModelIdFromCarModelEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "CarModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
