namespace FinalProject.controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly ILogger<Food> _logger;
        private readonly HobbyContext _context;

        public  HobbyController(ILogger<HobbyController> logger, HobbyContext context){
            _logger = logger;
            _context = context;
        }

        [HTTPSet]

        public IActionResult Get()
        {
            return Ok(_context.Hobby.toList());
        }

    }
}