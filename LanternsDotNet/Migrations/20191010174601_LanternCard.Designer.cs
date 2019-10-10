﻿// <auto-generated />
using System;
using LanternsDotNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LanternsDotNet.Migrations
{
    [DbContext(typeof(LanternContext))]
    [Migration("20191010174601_LanternCard")]
    partial class LanternCard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("LakeTileId");

                    b.ToTable("LakeTiles");
                });

            modelBuilder.Entity("LanternsDotNet.Models.LanternCard", b =>
                {
                    b.Property<Guid>("LanternCardId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("LanternCardId");

                    b.ToTable("LanternCards");
                });
#pragma warning restore 612, 618
        }
    }
}