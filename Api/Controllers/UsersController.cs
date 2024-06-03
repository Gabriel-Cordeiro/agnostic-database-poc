using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Context;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public UsersController(ApiDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var a = _context.Users.ToList();
            return a;
        }
    }
}
