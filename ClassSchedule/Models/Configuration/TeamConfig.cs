using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassSchedule.Models
{
    internal class TeamConfig : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> entity)
        {
            entity.HasData(
               new Team { TeamId = 1, TeamName = "Spartans", Division = "Forge" },
               new Team { TeamId = 2, TeamName = "Jets", Division = "Forge" }, 
               new Team { TeamId = 3, TeamName = "Express", Division = "Forge" },
               new Team { TeamId = 4, TeamName = "Knights", Division = "Forge" },
               new Team { TeamId = 5, TeamName = "Hawks", Division = "Sky" },
               new Team { TeamId = 6, TeamName = "FreeAgent", Division = "Meta" },
               new Team { TeamId = 7, TeamName = "FormerPlayer", Division = "Meta" }
            );
        }
    }

}
