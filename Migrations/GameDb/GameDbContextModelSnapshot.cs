using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFantasySports.Data;

namespace EFantasySports.Migrations.GameDb
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("EFantasySports.Models.Game.League", b =>
                {
                    b.Property<int>("LeagueID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CommissionerID");

                    b.Property<string>("LeagueName");

                    b.HasKey("LeagueID");

                    b.HasIndex("CommissionerID");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.LeaguePlayer", b =>
                {
                    b.Property<int>("LeaguePlayerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LeagueID");

                    b.Property<int>("TeamID");

                    b.HasKey("LeaguePlayerID");

                    b.HasIndex("LeagueID");

                    b.HasIndex("TeamID");

                    b.ToTable("LeaguePlayers");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Manager", b =>
                {
                    b.Property<int>("ManagerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ManagerName");

                    b.Property<int?>("TeamID");

                    b.HasKey("ManagerID");

                    b.HasIndex("TeamID")
                        .IsUnique();

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

            modelBuilder.Entity("EFantasySports.Models.Game.Roster", b =>
                {
                    b.Property<int>("RosterID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LeagueID");

                    b.HasKey("RosterID");

                    b.HasIndex("LeagueID");

                    b.ToTable("Rosters");
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

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.League", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.Manager", "Commisoner")
                        .WithMany()
                        .HasForeignKey("CommissionerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFantasySports.Models.Game.LeaguePlayer", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFantasySports.Models.Game.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Manager", b =>
                {
                    b.HasOne("EFantasySports.Models.Game.Team", "Team")
                        .WithOne("Manager")
                        .HasForeignKey("EFantasySports.Models.Game.Manager", "TeamID");
                });

            modelBuilder.Entity("EFantasySports.Models.Game.Roster", b =>
                {
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
                });
        }
    }
}
