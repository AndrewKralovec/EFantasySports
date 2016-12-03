using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFantasySports.Migrations.GameDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Postion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "LeaguePlayers",
                columns: table => new
                {
                    LeaguePlayerID = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    LeagueID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaguePlayers", x => x.LeaguePlayerID);
                    table.ForeignKey(
                        name: "FK_LeaguePlayers_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    LeagueID = table.Column<int>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerID = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
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

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    LeagueID = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    CommisonerManagerID = table.Column<int>(nullable: true),
                    CommissionerID = table.Column<int>(nullable: false),
                    LeagueName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.LeagueID);
                    table.ForeignKey(
                        name: "FK_Leagues_Managers_CommisonerManagerID",
                        column: x => x.CommisonerManagerID,
                        principalTable: "Managers",
                        principalColumn: "ManagerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_CommisonerManagerID",
                table: "Leagues",
                column: "CommisonerManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaguePlayers_LeagueID",
                table: "LeaguePlayers",
                column: "LeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaguePlayers_PlayerID",
                table: "LeaguePlayers",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaguePlayers_TeamID",
                table: "LeaguePlayers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_TeamID",
                table: "Managers",
                column: "TeamID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueID",
                table: "Teams",
                column: "LeagueID");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaguePlayers_Leagues_LeagueID",
                table: "LeaguePlayers",
                column: "LeagueID",
                principalTable: "Leagues",
                principalColumn: "LeagueID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaguePlayers_Teams_TeamID",
                table: "LeaguePlayers",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueID",
                table: "Teams",
                column: "LeagueID",
                principalTable: "Leagues",
                principalColumn: "LeagueID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Managers_CommisonerManagerID",
                table: "Leagues");

            migrationBuilder.DropTable(
                name: "LeaguePlayers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
