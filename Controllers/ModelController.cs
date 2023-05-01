using demo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly ModelContext _dbcontext;

        public ModelController(ModelContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
