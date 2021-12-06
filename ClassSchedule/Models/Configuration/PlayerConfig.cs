using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassSchedule.Models
{
    internal class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> entity)
        {
            
            entity.HasData(
               new Player { PlayerId = 1, PlayerName = "B++", LeagueId = 3, TeamId = 1, Salary = 13.5, PlatformId = 3 },
               new Player { PlayerId = 2, PlayerName = "Quhp", LeagueId = 3, TeamId = 1, Salary = 14.0, PlatformId = 3 },
               new Player { PlayerId = 3, PlayerName = "Zime", LeagueId = 3, TeamId = 1, Salary = 14.5, PlatformId = 3 },
               new Player { PlayerId = 4, PlayerName = "Xeia", LeagueId = 3, TeamId = 1, Salary = 13.0, PlatformId = 3 },
               new Player { PlayerId = 5, PlayerName = "Jaime", LeagueId = 3, TeamId = 2, Salary = 13.5, PlatformId = 2 },
               new Player { PlayerId = 6, PlayerName = "TheEvilIsBack", LeagueId = 3, TeamId = 2, Salary = 13.5, PlatformId = 4 }
            );
            
        }
    }

}
