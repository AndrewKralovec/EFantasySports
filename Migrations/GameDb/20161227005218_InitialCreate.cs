using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFantasySports.Migrations.GameDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    LeagueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LeagueName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.LeagueID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Postion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "DraftedPlayers",
                columns: table => new
                {
                    DraftedPlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LeagueID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftedPlayers", x => x.DraftedPlayerID);
                    table.ForeignKey(
                        name: "FK_DraftedPlayers_Leagues_LeagueID",
                        column: x => x.LeagueID,
                        principalTable: "Leagues",
                        principalColumn: "LeagueID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraftedPlayers_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayID = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    HomeID = table.Column<int>(nullable: true),
                    LeagueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Leagues_LeagueID",
                        column: x => x.LeagueID,
                        principalTable: "Leagues",
                        principalColumn: "LeagueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LeagueID = table.Column<int>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Leagues_LeagueID",
                        column: x => x.LeagueID,
                        principalTable: "Leagues",
                        principalColumn: "LeagueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManagerName = table.Column<string>(nullable: true),
                    TeamID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerID);
                    table.ForeignKey(
                        name: "FK_Managers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DraftedPlayers_LeagueID",
                table: "DraftedPlayers",
                column: "LeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_DraftedPlayers_PlayerID",
                table: "DraftedPlayers",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_DraftedPlayers_TeamID",
                table: "DraftedPlayers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_TeamID",
                table: "Managers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AwayID",
                table: "Schedules",
                column: "AwayID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_HomeID",
                table: "Schedules",
                column: "HomeID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_LeagueID",
                table: "Schedules",
                column: "LeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueID",
                table: "Teams",
                column: "LeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ManagerID",
                table: "Teams",
                column: "ManagerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftedPlayers_Teams_TeamID",
                table: "DraftedPlayers",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Teams_AwayID",
                table: "Schedules",
                column: "AwayID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Teams_HomeID",
                table: "Schedules",
                column: "HomeID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Managers_ManagerID",
                table: "Teams",
                column: "ManagerID",
                principalTable: "Managers",
                principalColumn: "ManagerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueID",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Teams_TeamID",
                table: "Managers");

            migrationBuilder.DropTable(
                name: "DraftedPlayers");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
