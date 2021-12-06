using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagement.Migrations
{
    public partial class MLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    LeagueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.LeagueId);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    MilitaryTime = table.Column<string>(maxLength: 4, nullable: false),
                    TeamId1 = table.Column<int>(nullable: false),
                    HomeTeamTeamId = table.Column<int>(nullable: true),
                    PlayerId1 = table.Column<int>(nullable: false),
                    Player1PlayerId = table.Column<int>(nullable: true),
                    PlayerId2 = table.Column<int>(nullable: false),
                    Player2PlayerId = table.Column<int>(nullable: true),
                    TeamId2 = table.Column<int>(nullable: false),
                    AwayTeamTeamId = table.Column<int>(nullable: true),
                    PlayerId3 = table.Column<int>(nullable: false),
                    Player3PlayerId = table.Column<int>(nullable: true),
                    PlayerId4 = table.Column<int>(nullable: false),
                    Player4PlayerId = table.Column<int>(nullable: true),
                    LeagueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                    table.ForeignKey(
                        name: "FK_Matches_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "LeagueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(maxLength: 100, nullable: false),
                    LeagueId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Salary = table.Column<double>(nullable: false),
                    PlatformId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "LeagueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(maxLength: 100, nullable: false),
                    Division = table.Column<string>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "LeagueId", "Name" },
                values: new object[,]
                {
                    { 1, "Foundation" },
                    { 2, "Academy" },
                    { 3, "Champion" },
                    { 4, "Master" },
                    { 5, "Premier" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "PlatformId", "Name" },
                values: new object[,]
                {
                    { 5, "SWITCH" },
                    { 3, "PC" },
                    { 4, "EPIC" },
                    { 1, "PSN" },
                    { 2, "XBOX" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Division", "PlayerId", "TeamName" },
                values: new object[,]
                {
                    { 6, "Meta", null, "FreeAgent" },
                    { 1, "Forge", null, "Spartans" },
                    { 2, "Forge", null, "Jets" },
                    { 3, "Forge", null, "Express" },
                    { 4, "Forge", null, "Knights" },
                    { 5, "Sky", null, "Hawks" },
                    { 7, "Meta", null, "FormerPlayer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamTeamId",
                table: "Matches",
                column: "AwayTeamTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamTeamId",
                table: "Matches",
                column: "HomeTeamTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player1PlayerId",
                table: "Matches",
                column: "Player1PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player2PlayerId",
                table: "Matches",
                column: "Player2PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player3PlayerId",
                table: "Matches",
                column: "Player3PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Player4PlayerId",
                table: "Matches",
                column: "Player4PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_LeagueId",
                table: "Players",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlatformId",
                table: "Players",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_PlayerId",
                table: "Team",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_AwayTeamTeamId",
                table: "Matches",
                column: "AwayTeamTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_HomeTeamTeamId",
                table: "Matches",
                column: "HomeTeamTeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_Player1PlayerId",
                table: "Matches",
                column: "Player1PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_Player2PlayerId",
                table: "Matches",
                column: "Player2PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_Player3PlayerId",
                table: "Matches",
                column: "Player3PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_Player4PlayerId",
                table: "Matches",
                column: "Player4PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Team_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Team_TeamId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Platform");
        }
    }
}
