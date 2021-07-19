﻿// <auto-generated />
using System;
using DVDMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DVDMovie.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DVDMovie.Models.Movie", b =>
                {
                    b.Property<long>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("StudioId")
                        .HasColumnType("bigint");

                    b.HasKey("MovieId");

                    b.HasIndex("StudioId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DVDMovie.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MovieId")
                        .HasColumnType("bigint");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("DVDMovie.Models.Studio", b =>
                {
                    b.Property<long>("StudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioId");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("DVDMovie.Models.Movie", b =>
                {
                    b.HasOne("DVDMovie.Models.Studio", "Studio")
                        .WithMany("Movies")
                        .HasForeignKey("StudioId");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("DVDMovie.Models.Rating", b =>
                {
                    b.HasOne("DVDMovie.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("DVDMovie.Models.Movie", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("DVDMovie.Models.Studio", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
