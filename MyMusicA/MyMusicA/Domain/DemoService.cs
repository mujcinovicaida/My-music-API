using Microsoft.AspNetCore.Mvc;
using MyMusicA.Data;
using MyMusicA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicA.Domain
{
    public class DemoService
    {
        private readonly DemoRepository _demoRepository;
        public DemoService(DemoRepository demoRepository)
        {
            _demoRepository = demoRepository;
        }
        public async Task<List<Song>> GetAllSongsAsync()
        {
            return await _demoRepository.GetAllSongsAsync();
        }

        public async Task SaveSongAsync(Song song)
        {
            await _demoRepository.SaveSongAsync(song);
        }

        public async Task<List<Song>> DeleteSongAsync(int SongID)
        {
            return await _demoRepository.DeleteSongAsync(SongID);
        }

        public async Task UpdateSongAsync(Song song)
        {
            await _demoRepository.UpdateSongAsync(song);
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _demoRepository.GetAllCategoriesAsync();
        }

        public async Task SaveCategory(Category category)
        {
            await _demoRepository.SaveCategory(category);
        }
    }
}
