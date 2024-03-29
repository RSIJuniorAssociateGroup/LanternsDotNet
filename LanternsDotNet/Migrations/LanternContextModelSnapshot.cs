﻿// <auto-generated />
using System;
using LanternsDotNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LanternsDotNet.Migrations
{
    [DbContext(typeof(LanternContext))]
    partial class LanternContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LanternsDotNet.Models.LakeTile", b =>
                {
                    b.Property<Guid>("LakeTileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LakeTileLakeTileColor");

                    b.HasKey("LakeTileId");

                    b.ToTable("LakeTiles");
                });

            modelBuilder.Entity("LanternsDotNet.Models.LakeTileColor", b =>
                {
                    b.Property<Guid>("LakeTileColorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("URl");

                    b.HasKey("LakeTileColorId");

                    b.ToTable("LakeTileColor");
                });

            modelBuilder.Entity("LanternsDotNet.Models.LakeTileLakeTileColor", b =>
                {
                    b.Property<Guid>("LakeTileColorId");

                    b.Property<Guid>("LakeTileId");

                    b.Property<int>("LakeTileLakeTileColorId");

                    b.HasKey("LakeTileColorId", "LakeTileId");

                    b.HasIndex("LakeTileId");

                    b.ToTable("LakeTileLakeTileColors");
                });

            modelBuilder.Entity("LanternsDotNet.Models.LakeTileLakeTileColor", b =>
                {
                    b.HasOne("LanternsDotNet.Models.LakeTileColor", "LakeTileColor")
                        .WithMany("LakeTileLakeTileColors")
                        .HasForeignKey("LakeTileColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LanternsDotNet.Models.LakeTile", "LakeTile")
                        .WithMany("LakeTileLakeTileColors")
                        .HasForeignKey("LakeTileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
