


[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{

    private readonly ChoresService _choresService;

    public ChoresController(ChoresService cs)
    {
        _choresService = cs;
    }

    [HttpGet("test")]
    public string GetTest()
    {
        return "TEST GET";
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}