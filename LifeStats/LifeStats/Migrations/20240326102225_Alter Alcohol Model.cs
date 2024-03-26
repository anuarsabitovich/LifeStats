using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeStats.Migrations
{
    /// <inheritdoc />
    public partial class AlterAlcoholModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AmountMl",
                table: "Alcohol",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountMl",
                table: "Alcohol");
        }
    }
}
