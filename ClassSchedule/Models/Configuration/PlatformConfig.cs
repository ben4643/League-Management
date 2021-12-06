using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassSchedule.Models
{
    internal class PlatformConfig : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> entity)
        {
            entity.HasData(
               new Platform { PlatformId = 1, Name = "PSN"},
               new Platform { PlatformId = 2, Name = "XBOX" },
               new Platform { PlatformId = 3, Name = "PC" },
               new Platform { PlatformId = 4, Name = "EPIC" },
               new Platform { PlatformId = 5, Name = "SWITCH" }
            );
        }
    }

}
