using System;
using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
	internal sealed class MusicAppDBContext : DbContext
	{
        public DbSet<Song> Songs  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Song[] songs = new Song[6];

            for (int i = 1; i <= 6; i++)
            {
                songs[i - 1] = new Song
                {
                    SongId = i,
                    Title = $"Song {i}",
                    Description = $"This is Song {i}",
                    VideoUrl = "https://youtu.be/KNMbDIKJ6T0",
                };
            }
            modelBuilder.Entity<Song>().HasData(songs);
        }
    }
}

