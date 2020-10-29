using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace API.Controllers
{
  public class BuggyController : BaseApiController
  {
    private readonly StoreContext _context;

    public BuggyController(StoreContext context)
    {
      _context = context;
    }

    [HttpGet("testauth")]
    [Authorize]
    public ActionResult<string> GetSecretText()
    {
      return "secret stuff";
    }

    [HttpGet("notfound")]
    public ActionResult GetNotFoundRequest()
    {
      return NotFound(new APIResponse(404));
    }

    [HttpGet("servererror")]
    public ActionResult GetServerError()
    {
      var thing = _context.Products.Find(42);
      var thingToReturn = thing.ToString();
      return Ok();
    }

    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
      return BadRequest(new APIResponse(400));
    }

    [HttpGet("badrequest/{id}")]
    public ActionResult GetBadRequestWithId(int id)
    {
      return Ok();
    }
  }
}