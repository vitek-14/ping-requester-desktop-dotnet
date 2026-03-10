using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PingRequester.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PingTarget = table.Column<string>(type: "TEXT", nullable: false),
                    Mode = table.Column<string>(type: "TEXT", nullable: false),
                    RefreshRate = table.Column<int>(type: "INTEGER", nullable: false),
                    InfiniteLoop = table.Column<bool>(type: "INTEGER", nullable: false),
                    StopWhenSuccess = table.Column<bool>(type: "INTEGER", nullable: false),
                    PingRequestCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Attempts = table.Column<int>(type: "INTEGER", nullable: false),
                    PacketSize = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PingTarget = table.Column<string>(type: "TEXT", nullable: false),
                    Ipv4 = table.Column<string>(type: "TEXT", nullable: false),
                    PacketSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Sent = table.Column<int>(type: "INTEGER", nullable: false),
                    Received = table.Column<int>(type: "INTEGER", nullable: false),
                    Lost = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxResponseTimeMs = table.Column<int>(type: "INTEGER", nullable: false),
                    MinResponseTimeMs = table.Column<int>(type: "INTEGER", nullable: false),
                    AverageResponseTimeMs = table.Column<float>(type: "REAL", nullable: false),
                    UserPreferencesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Preferences_UserPreferencesId",
                        column: x => x.UserPreferencesId,
                        principalTable: "Preferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserPreferencesId",
                table: "Sessions",
                column: "UserPreferencesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Preferences");
        }
    }
}
