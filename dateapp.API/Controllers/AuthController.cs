using System.Threading.Tasks;
using dateapp.API.Data;
using dateapp.API.Models;
using dateapp.API.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace dateapp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //inject auth repository
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo) => _repo = repo;



        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDtos userForRegisterDto)
        {
            //validate the request
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username))
            {
                return BadRequest("Username already exists");
            }

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            //Uncomment when we have the avaliability to return a specific user
            //return CreatedAtRoute()
            return StatusCode(201);
        }
    }
}