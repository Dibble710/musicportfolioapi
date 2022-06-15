using System;
using Microsoft.EntityFrameworkCore;

namespace aspnetserver.Data
{
    internal static class SongsRepository
    {
        internal async static Task<List<Song>> GetSongsAsync()
        {
            using var db = new MusicAppDBContext();
            {
                return await db.Songs.ToListAsync();
            }
        }
        // =============== (C)RUD =========== //
        internal async static Task<bool> CreateSongAsync(Song songToCreate)
        {
            using var db = new MusicAppDBContext();
            try
            {
                await db.Songs.AddAsync(songToCreate);

                return await db.SaveChangesAsync() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // =============== C(R)UD =========== //
        internal async static Task<Song> GetSongsByIdAsync(int songId)
        {
            using var db = new MusicAppDBContext();
            {
                return await db.Songs.FirstOrDefaultAsync(song => song.SongId == songId);
            }
        }
        // =============== CR(U)D =========== //
        internal async static Task<bool> UpdateSongAsync(Song songToUpdate)
        {
            using var db = new MusicAppDBContext();
            try
            {
                db.Songs.Update(songToUpdate);

                return await db.SaveChangesAsync() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // =============== CRU(D) =========== //
        internal async static Task<bool> DeleteSongAsync(int songId)
        {
            using var db = new MusicAppDBContext();
            try
            {
                Song songToDelete = await GetSongsByIdAsync(songId);
                db.Remove(songToDelete);

                return await db.SaveChangesAsync() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

