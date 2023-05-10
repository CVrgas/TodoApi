using Microsoft.AspNetCore.Mvc;

namespace ASECOND.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;

        static readonly Models.IUserRepository repository = new Models.UserRepository();

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/users")]
        public IEnumerable<Models.User> GetAllUsers()
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public Models.User getThis([FromRoute]string id)
        {           
            return repository.getThis(id);
        }
        
        [HttpPost]
        [Route("api/user")]
        [Consumes("application/json")]
        public Models.User PostUser(Models.User item)
        {
            return repository.Add(item);
        }

        [HttpPut]
        [Route("api/user/{id}")]
        public Models.User updatetUser([FromRoute] string id, Models.User updatedUser)
        {
            return repository.updateUser(id, updatedUser);
        }

        [HttpDelete]
        [Route("api/user/{id}")]
        public Models.User deleteUser([FromRoute] string id)
        {
            return repository.deleteUser(id);
        }
    }
}