using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMusicA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicA.Data
{
    
    public class DemoRepository
    {
        private readonly SongDbContext _songDbContext;
        public DemoRepository(SongDbContext songDbContext)
        {
            _songDbContext = songDbContext;
        }
        public async Task<List<Song>> GetAllSongsAsync()
        {
            return await _songDbContext.Songs.ToListAsync();
        }

        public async Task<List<Song>> DeleteSongAsync(int SongID)
        {
            var temp = await _songDbContext.Songs.FindAsync(SongID);
            _songDbContext.Songs.Remove(temp);
            await _songDbContext.SaveChangesAsync();
            return await _songDbContext.Songs.ToListAsync();
        }

        public async Task UpdateSongAsync(Song song)
        {
            _songDbContext.Entry(song).State = EntityState.Modified;
            await _songDbContext.SaveChangesAsync();
        }
        public async Task SaveSongAsync(Song song)
        {
            _songDbContext.Songs.Add(song);
            await _songDbContext.SaveChangesAsync();
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _songDbContext.Categories.ToListAsync();
        }
        public async Task SaveCategory(Category category)
        {
            _songDbContext.Categories.Add(category);
            await _songDbContext.SaveChangesAsync();
        }
    }
}
