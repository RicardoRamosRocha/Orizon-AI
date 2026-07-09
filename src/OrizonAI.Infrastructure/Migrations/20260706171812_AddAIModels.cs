using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrizonAI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAIModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AIModels_AIProviderId",
                table: "AIModels");

            migrationBuilder.DropIndex(
                name: "IX_AIModels_Identifier",
                table: "AIModels");

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_AIProviderId_Identifier",
                table: "AIModels",
                columns: new[] { "AIProviderId", "Identifier" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AIModels_AIProviderId_Identifier",
                table: "AIModels");

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_AIProviderId",
                table: "AIModels",
                column: "AIProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_Identifier",
                table: "AIModels",
                column: "Identifier");
        }
    }
}
