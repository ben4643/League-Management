using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassSchedule.Models
{
    internal class MatchConfig : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> entity)
        {
            
            entity.HasData(
               new Match { MatchId = 1, Number = 1, TeamId1 = 1, PlayerId1 = 1 , PlayerId2 = 2, TeamId2 = 2, PlayerId3 = 5, PlayerId4 = 6, LeagueId = 1, MilitaryTime = "1500" }
            );
            
        }
    }

}
