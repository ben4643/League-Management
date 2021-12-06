using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueManagement.Migrations
{
    public partial class MLE2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "AwayTeamTeamId", "HomeTeamTeamId", "LeagueId", "MilitaryTime", "Number", "Player1PlayerId", "Player2PlayerId", "Player3PlayerId", "Player4PlayerId", "PlayerId1", "PlayerId2", "PlayerId3", "PlayerId4", "TeamId1", "TeamId2" },
                values: new object[] { 1, null, null, 1, "1500", 1, null, null, null, null, 1, 2, 5, 6, 1, 2 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "LeagueId", "PlatformId", "PlayerName", "Salary", "TeamId" },
                values: new object[,]
                {
                    { 1, 3, 3, "B++", 13.5, 1 },
                    { 2, 3, 3, "Quhp", 14.0, 1 },
                    { 3, 3, 3, "Zime", 14.5, 1 },
                    { 4, 3, 3, "Xeia", 13.0, 1 },
                    { 5, 3, 2, "Jaime", 13.5, 2 },
                    { 6, 3, 4, "TheEvilIsBack", 13.5, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6);
        }
    }
}
