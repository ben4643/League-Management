using Microsoft.EntityFrameworkCore;

namespace ClassSchedule.Models
{
    public class MatchScheduleContext : DbContext
    {
        public MatchScheduleContext(DbContextOptions<MatchScheduleContext> options)
            : base(options)
        { }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Match Keys
            modelBuilder.Entity<Match>().HasOne(m => m.Player1)
                .WithMany(p => p.Matches1)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(m => m.Player2)
                .WithMany(p => p.Matches2)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(m => m.Player3)
                .WithMany(p => p.Matches3)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(m => m.Player4)
                .WithMany(p => p.Matches4)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(m => m.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>().HasOne(m => m.AwayTeam)
                .WithMany(t => t.AwayMatches)
                .OnDelete(DeleteBehavior.Restrict);

            //Player Keys
            modelBuilder.Entity<Player>().HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Player>().HasOne(p => p.League)
                .WithMany(l => l.Players)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Player>().HasOne(p => p.Platform)
                .WithMany(l => l.Players)
                .OnDelete(DeleteBehavior.Restrict);






            modelBuilder.ApplyConfiguration(new LeagueConfig());
            modelBuilder.ApplyConfiguration(new PlatformConfig());
            modelBuilder.ApplyConfiguration(new TeamConfig());
            modelBuilder.ApplyConfiguration(new PlayerConfig());
            modelBuilder.ApplyConfiguration(new MatchConfig());
        }

    }
}
