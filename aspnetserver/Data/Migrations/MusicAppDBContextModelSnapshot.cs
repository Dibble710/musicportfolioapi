﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    [DbContext(typeof(MusicAppDBContext))]
    partial class MusicAppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("aspnetserver.Data.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("SongId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Description = "This is Song 1",
                            Title = "Song 1",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        },
                        new
                        {
                            SongId = 2,
                            Description = "This is Song 2",
                            Title = "Song 2",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        },
                        new
                        {
                            SongId = 3,
                            Description = "This is Song 3",
                            Title = "Song 3",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        },
                        new
                        {
                            SongId = 4,
                            Description = "This is Song 4",
                            Title = "Song 4",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        },
                        new
                        {
                            SongId = 5,
                            Description = "This is Song 5",
                            Title = "Song 5",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        },
                        new
                        {
                            SongId = 6,
                            Description = "This is Song 6",
                            Title = "Song 6",
                            VideoUrl = "https://youtu.be/KNMbDIKJ6T0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
