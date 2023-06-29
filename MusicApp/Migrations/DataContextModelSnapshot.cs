﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp.Data;

#nullable disable

namespace MusicApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MusicApp.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            AlbumName = "A Dramatic Turn of Events",
                            ArtistId = 1,
                            DateReleased = new DateTime(2011, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1
                        },
                        new
                        {
                            AlbumId = 2,
                            AlbumName = "Black Clouds and Silver Linings",
                            ArtistId = 1,
                            DateReleased = new DateTime(2009, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1
                        },
                        new
                        {
                            AlbumId = 3,
                            AlbumName = "É o Tcham no Havai",
                            ArtistId = 2,
                            DateReleased = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            ArtistName = "Dream Theater",
                            GenreId = 1
                        },
                        new
                        {
                            ArtistId = 2,
                            ArtistName = "É o Tcham",
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Progressive Metal"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Axé Music"
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            AlbumId = 1,
                            ArtistId = 1,
                            Duration = 18,
                            GenreId = 1,
                            SongName = "On The Backs of Angels"
                        },
                        new
                        {
                            SongId = 2,
                            AlbumId = 1,
                            ArtistId = 1,
                            Duration = 9,
                            GenreId = 1,
                            SongName = "Breaking All Illusions"
                        },
                        new
                        {
                            SongId = 3,
                            AlbumId = 1,
                            ArtistId = 1,
                            Duration = 18,
                            GenreId = 1,
                            SongName = "Lost Not Forgotten"
                        },
                        new
                        {
                            SongId = 4,
                            AlbumId = 1,
                            ArtistId = 1,
                            Duration = 11,
                            GenreId = 1,
                            SongName = "This is The Life"
                        },
                        new
                        {
                            SongId = 5,
                            AlbumId = 2,
                            ArtistId = 1,
                            Duration = 14,
                            GenreId = 1,
                            SongName = "The Count of Tuscany"
                        },
                        new
                        {
                            SongId = 6,
                            AlbumId = 3,
                            ArtistId = 2,
                            Duration = 4,
                            GenreId = 2,
                            SongName = "A Loira do Tcham"
                        });
                });

            modelBuilder.Entity("MusicApp.Models.Album", b =>
                {
                    b.HasOne("MusicApp.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApp.Models.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicApp.Models.Artist", b =>
                {
                    b.HasOne("MusicApp.Models.Genre", "Genre")
                        .WithMany("Artists")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicApp.Models.Song", b =>
                {
                    b.HasOne("MusicApp.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApp.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApp.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicApp.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicApp.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicApp.Models.Genre", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Artists");

                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
