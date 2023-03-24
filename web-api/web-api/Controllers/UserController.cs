using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api.EFs;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_dataContext.Users);
        }
    }
}
