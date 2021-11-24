using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMusicA.Domain;
using MyMusicA.Models;

namespace MyMusicA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly DemoService _demoService;
        public DemoController(DemoService demoService)
        {
            _demoService = demoService;
        }
        [HttpGet]
        public async Task<List<Song>> GetAllSongsAsync()
        {
            return await _demoService.GetAllSongsAsync();
        }

        [HttpPost]
        public async Task SaveSongAsync(Song song)
        {
          await _demoService.SaveSongAsync(song);
        }

        [HttpDelete("{SongID}")]
        public async Task<List<Song>> DeleteSongAsync(int SongID)
        {
            return await _demoService.DeleteSongAsync(SongID);
        }
        [HttpPut]
        public async Task UpdateSongAsync(Song song)
        {
           await _demoService.UpdateSongAsync(song);
        }

        [HttpGet]
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _demoService.GetAllCategoriesAsync();
        }

        [HttpPost]
        public async Task SaveCategory(Category category)
        {
            await _demoService.SaveCategory(category);
        }
    }
}