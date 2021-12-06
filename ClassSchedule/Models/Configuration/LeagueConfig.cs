using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassSchedule.Models
{
    internal class LeagueConfig : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> entity)
        {
            entity.HasData(
               new League { LeagueId = 1, Name = "Foundation" },
               new League { LeagueId = 2, Name = "Academy" }, 
               new League { LeagueId = 3, Name = "Champion" },
               new League { LeagueId = 4, Name = "Master" },
               new League { LeagueId = 5, Name = "Premier" }
            );
        }
    }

}
