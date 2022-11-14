﻿// <auto-generated />
using FootballAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootballAPI.Migrations
{
    [DbContext(typeof(FootballContext))]
    partial class FootballContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FootballAPI.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalTouchdowns")
                        .HasColumnType("int");

                    b.Property<int>("TotalYards")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jacoby Brisset",
                            Position = "QB",
                            Team = "Browns",
                            TotalTouchdowns = 20,
                            TotalYards = 200
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nick Chubb",
                            Position = "RB",
                            Team = "Browns",
                            TotalTouchdowns = 25,
                            TotalYards = 1000
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lamar Jackson",
                            Position = "QB",
                            Team = "Ravens",
                            TotalTouchdowns = 32,
                            TotalYards = 1738
                        },
                        new
                        {
                            Id = 4,
                            Name = "Justin Jefferson",
                            Position = "WR",
                            Team = "Vikings",
                            TotalTouchdowns = 10,
                            TotalYards = 756
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mark Andrews",
                            Position = "TE",
                            Team = "Ravens",
                            TotalTouchdowns = 15,
                            TotalYards = 450
                        },
                        new
                        {
                            Id = 6,
                            Name = "Randy Moss",
                            Position = "WR",
                            Team = "Vikings",
                            TotalTouchdowns = 33,
                            TotalYards = 2219
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
