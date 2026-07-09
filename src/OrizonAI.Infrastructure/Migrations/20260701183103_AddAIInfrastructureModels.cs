using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrizonAI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAIInfrastructureModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AIProviders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    DisplayName = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    BaseUrl = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    ApiKey = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OrganizationId = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true),
                    ApiVersion = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    TimeoutSeconds = table.Column<int>(type: "integer", nullable: false),
                    RetryCount = table.Column<int>(type: "integer", nullable: false),
                    SupportsStreaming = table.Column<bool>(type: "boolean", nullable: false),
                    SupportsVision = table.Column<bool>(type: "boolean", nullable: false),
                    SupportsAudio = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIProviders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AIModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AIProviderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Identifier = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Modalities = table.Column<int>(type: "integer", nullable: false),
                    ContextWindow = table.Column<int>(type: "integer", nullable: false),
                    MaxOutputTokens = table.Column<int>(type: "integer", nullable: false),
                    InputTokenPricePerMillion = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    OutputTokenPricePerMillion = table.Column<decimal>(type: "numeric(18,6)", precision: 18, scale: 6, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AIModels_AIProviders_AIProviderId",
                        column: x => x.AIProviderId,
                        principalTable: "AIProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_Active",
                table: "AIModels",
                column: "Active");

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_AIProviderId",
                table: "AIModels",
                column: "AIProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_AIModels_Identifier",
                table: "AIModels",
                column: "Identifier");

            migrationBuilder.CreateIndex(
                name: "IX_AIProviders_Active",
                table: "AIProviders",
                column: "Active");

            migrationBuilder.CreateIndex(
                name: "IX_AIProviders_Type",
                table: "AIProviders",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AIModels");

            migrationBuilder.DropTable(
                name: "AIProviders");
        }
    }
}
