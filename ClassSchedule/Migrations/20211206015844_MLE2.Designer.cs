﻿// <auto-generated />
using System;
using ClassSchedule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueManagement.Migrations
{
    [DbContext(typeof(MatchScheduleContext))]
    [Migration("20211206015844_MLE2")]
    partial class MLE2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassSchedule.Models.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("LeagueId");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            LeagueId = 1,
                            Name = "Foundation"
                        },
                        new
                        {
                            LeagueId = 2,
                            Name = "Academy"
                        },
                        new
                        {
                            LeagueId = 3,
                            Name = "Champion"
                        },
                        new
                        {
                            LeagueId = 4,
                            Name = "Master"
                        },
                        new
                        {
                            LeagueId = 5,
                            Name = "Premier"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AwayTeamTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamTeamId")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("MilitaryTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<int?>("Number")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Player1PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("Player2PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("Player3PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("Player4PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId1")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId2")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId3")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId4")
                        .HasColumnType("int");

                    b.Property<int>("TeamId1")
                        .HasColumnType("int");

                    b.Property<int>("TeamId2")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.HasIndex("AwayTeamTeamId");

                    b.HasIndex("HomeTeamTeamId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("Player1PlayerId");

                    b.HasIndex("Player2PlayerId");

                    b.HasIndex("Player3PlayerId");

                    b.HasIndex("Player4PlayerId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            MatchId = 1,
                            LeagueId = 1,
                            MilitaryTime = "1500",
                            Number = 1,
                            PlayerId1 = 1,
                            PlayerId2 = 2,
                            PlayerId3 = 5,
                            PlayerId4 = 6,
                            TeamId1 = 1,
                            TeamId2 = 2
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("PlatformId");

                    b.ToTable("Platform");

                    b.HasData(
                        new
                        {
                            PlatformId = 1,
                            Name = "PSN"
                        },
                        new
                        {
                            PlatformId = 2,
                            Name = "XBOX"
                        },
                        new
                        {
                            PlatformId = 3,
                            Name = "PC"
                        },
                        new
                        {
                            PlatformId = 4,
                            Name = "EPIC"
                        },
                        new
                        {
                            PlatformId = 5,
                            Name = "SWITCH"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            LeagueId = 3,
                            PlatformId = 3,
                            PlayerName = "B++",
                            Salary = 13.5,
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 2,
                            LeagueId = 3,
                            PlatformId = 3,
                            PlayerName = "Quhp",
                            Salary = 14.0,
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 3,
                            LeagueId = 3,
                            PlatformId = 3,
                            PlayerName = "Zime",
                            Salary = 14.5,
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 4,
                            LeagueId = 3,
                            PlatformId = 3,
                            PlayerName = "Xeia",
                            Salary = 13.0,
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 5,
                            LeagueId = 3,
                            PlatformId = 2,
                            PlayerName = "Jaime",
                            Salary = 13.5,
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 6,
                            LeagueId = 3,
                            PlatformId = 4,
                            PlayerName = "TheEvilIsBack",
                            Salary = 13.5,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("TeamId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Division = "Forge",
                            TeamName = "Spartans"
                        },
                        new
                        {
                            TeamId = 2,
                            Division = "Forge",
                            TeamName = "Jets"
                        },
                        new
                        {
                            TeamId = 3,
                            Division = "Forge",
                            TeamName = "Express"
                        },
                        new
                        {
                            TeamId = 4,
                            Division = "Forge",
                            TeamName = "Knights"
                        },
                        new
                        {
                            TeamId = 5,
                            Division = "Sky",
                            TeamName = "Hawks"
                        },
                        new
                        {
                            TeamId = 6,
                            Division = "Meta",
                            TeamName = "FreeAgent"
                        },
                        new
                        {
                            TeamId = 7,
                            Division = "Meta",
                            TeamName = "FormerPlayer"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Match", b =>
                {
                    b.HasOne("ClassSchedule.Models.Team", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamTeamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassSchedule.Models.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamTeamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassSchedule.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassSchedule.Models.Player", "Player1")
                        .WithMany("Matches1")
                        .HasForeignKey("Player1PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassSchedule.Models.Player", "Player2")
                        .WithMany("Matches2")
                        .HasForeignKey("Player2PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassSchedule.Models.Player", "Player3")
                        .WithMany("Matches3")
                        .HasForeignKey("Player3PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ClassSchedule.Models.Player", "Player4")
                        .WithMany("Matches4")
                        .HasForeignKey("Player4PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ClassSchedule.Models.Player", b =>
                {
                    b.HasOne("ClassSchedule.Models.League", "League")
                        .WithMany("Players")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClassSchedule.Models.Platform", "Platform")
                        .WithMany("Players")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClassSchedule.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassSchedule.Models.Team", b =>
                {
                    b.HasOne("ClassSchedule.Models.Player", null)
                        .WithMany("Teams")
                        .HasForeignKey("PlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}
