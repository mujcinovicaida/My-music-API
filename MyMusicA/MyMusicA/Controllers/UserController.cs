using Microsoft.AspNetCore.Mvc;
using MyMusicA.Domain;
using MyMusicA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicA.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task SaveUserAsync(User user)
        {
            await _userService.SaveUserAsync(user);
        }

      
    }
}
