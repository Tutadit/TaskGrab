﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskGrab.Data;

namespace TaskGrab.Migrations
{
    [DbContext(typeof(CommunityLocationContext))]
    [Migration("20210317045806_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("TaskGrab.Data.CommunityLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Community")
                        .HasColumnType("TEXT");

                    b.Property<double>("latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("longitude")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("CommunityLocations");
                });
#pragma warning restore 612, 618
        }
    }
}