namespace FinalProject.controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JobController : ControllerBase
    {
        private readonly ILogger<Food> _logger;

        public  JobController(ILogger<JobController> logger, JobContext context){
            _context = context;
            _logger = logger;
        }

        [HTTPSet]

        public IActionResult Get()
        {
            return Ok(_context.Job.toList());
        }

    }
}