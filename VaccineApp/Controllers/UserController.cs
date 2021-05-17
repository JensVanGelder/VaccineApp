﻿#region

using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

#endregion

namespace VaccineApp
{
    using VaccineApp.DTO;
    using VaccineApp.Entities;
    using VaccineApp.Repositories;
    using VaccineApp.Services;

    [ApiController, Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service) => _service = service;

        [HttpPost]
        public async Task AddUserAsync(User user)
        {
            await _service.AddUserAsync(user);
        }

        [HttpDelete("{id})")]
        public async Task<ActionResult> DeleteUserAsync(int id)
        {
            await _service.DeleteUserAsync(id);
            return Ok("Delete OK");
        }

        [HttpGet("{id}")]
        public async Task<UserDto> GetUserAsync(int id) => await _service.GetUserAsync(id);

        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetUsersAsync() => await _service.GetUsersAsync();

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(User user)
        {
            await _service.UpdateUserAsync(user);
            return Ok("Update OK");
        }
    }
}