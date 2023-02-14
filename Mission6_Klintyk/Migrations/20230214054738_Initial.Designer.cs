﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_Klintyk.Models;

namespace Mission6_Klintyk.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230214054738_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6_Klintyk.Models.Movie", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_to")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            Category = "Action/Adventure",
                            Director = "Ryan Coogler",
                            Edited = false,
                            Lent_to = "Oliva Olred",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Black Panther",
                            Year = 2018
                        },
                        new
                        {
                            FilmID = 2,
                            Category = "Comedy",
                            Director = "Frank Coraci",
                            Edited = true,
                            Lent_to = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Blended",
                            Year = 2014
                        },
                        new
                        {
                            FilmID = 3,
                            Category = "Action/Adventure",
                            Director = "David Dobkin",
                            Edited = false,
                            Lent_to = "Carter Jenses",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Shanghai Knights",
                            Year = 2003
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
