namespace FinalProject.controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMember> _logger;
        private readonly TeamMemberContext _context;

        public  TeamMemberController(ILogger<TeamMemberController> logger, TeamMemberContext context){
            _logger = logger;
            _context = context;
        }

        [HTTPSet]

        public IActionResult Get()
        {
            return Ok(_context.TeamMember.toList());
        }

    }
}