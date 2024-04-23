﻿// <auto-generated />
using DataAccess.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MusicLibraryContext))]
    [Migration("20240423214914_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Entities.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArtistName = "Artist1"
                        },
                        new
                        {
                            ID = 2,
                            ArtistName = "Artist2"
                        },
                        new
                        {
                            ID = 3,
                            ArtistName = "Artist3"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.Song", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ArtistID = 1,
                            SongName = "ASong"
                        },
                        new
                        {
                            ID = 2,
                            ArtistID = 2,
                            SongName = "BSong"
                        },
                        new
                        {
                            ID = 3,
                            ArtistID = 3,
                            SongName = "CSong"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Entities.Song", b =>
                {
                    b.HasOne("DataAccess.Models.Entities.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("DataAccess.Models.Entities.Artist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}