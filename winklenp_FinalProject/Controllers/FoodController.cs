namespace FinalProject.controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FoodController : ControllerBase
    {
        private readonly ILogger<Food> _logger;
        private readonly FoodContext _context;

        public  TeamMemberController(ILogger<FoodController> logger, FoodContext context){
            _logger = logger;
            _context = context;
        }

        [HTTPSet]

        public IActionResult Get()
        {
            return Ok(_context.Food.toList());
        }

    }
}