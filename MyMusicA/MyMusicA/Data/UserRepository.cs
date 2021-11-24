using MyMusicA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicA.Data
{

    public class UserRepository
    {
        private readonly SongDbContext _songDbContext;

        public UserRepository(SongDbContext songDbContext)
        {
            _songDbContext = songDbContext;
        }

        public async Task SaveUserAsync (User user)
        {
            _songDbContext.Users.Add(user);
            await _songDbContext.SaveChangesAsync();
        }
    }
}
