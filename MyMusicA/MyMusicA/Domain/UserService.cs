using MyMusicA.Data;
using MyMusicA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicA.Domain
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task SaveUserAsync (User user)
        {
            await _userRepository.SaveUserAsync(user);
        }
    }
}
