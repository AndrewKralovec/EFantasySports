using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFantasySports.Data;

namespace EFantasySports.Migrations.GameDb
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20161227005218_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFantasySports.Models.Game.DraftedPlayer", b =>
                {
                    b.Property<int>("DraftedPlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LeagueID");

                    b.Property<int>("PlayerID");

                    b.Property<int?>("TeamID");

                    b.HasKey("DraftedPlayerID");

                    b.HasIndex("LeagueID");

                    b.HasIndex("PlayerID");

                    b.HasIndex("TeamID");

                    b.ToTable("DraftedPlayers");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.League", b =>
                {
                    b.Property<int>("LeagueID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LeagueName");

                    b.HasKey("LeagueID");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ManagerName");

                    b.Property<int?>("TeamID");

                    b.HasKey("ManagerID");

                    b.HasIndex("TeamID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Postion");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AwayID");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("HomeID");

                    b.Property<int>("LeagueID");

                    b.HasKey("ScheduleID");

                    b.HasIndex("AwayID");

                    b.HasIndex("HomeID");

                    b.HasIndex("LeagueID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LeagueID");

                    b.Property<int>("ManagerID");

                    b.Property<string>("TeamName");

                    b.HasKey("TeamID");

                    b.HasIndex("LeagueID");

                    b.HasIndex("ManagerID")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.DraftedPlayer", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFantasySports.Models.Game.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFantasySports.Models.Game.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Manager", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Schedule", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.Team", "Away")
                        .WithMany()
                        .HasForeignKey("AwayID");

                    b.HasOne("EFantasySports.Models.Game.Team", "Home")
                        .WithMany()
                        .HasForeignKey("HomeID");

                    b.HasOne("EFantasySports.Models.Game.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Team", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFantasySports.Models.Game.Manager", "Manager")
                        .WithOne()
                        .HasForeignKey("EFantasySports.Models.Game.Team", "ManagerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
