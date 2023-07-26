﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieMania.Data;

#nullable disable

namespace MovieMania.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230726100635_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MovieMania.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<double>("Ticket")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MovieName")
                        .IsUnique();

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}