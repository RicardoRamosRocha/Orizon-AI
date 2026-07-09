using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrizonAI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlanLimits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxTokensPerMonth",
                table: "Plans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxUsers",
                table: "Plans",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxTokensPerMonth",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "MaxUsers",
                table: "Plans");
        }
    }
}
