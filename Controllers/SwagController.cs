using Microsoft.AspNetCore.Mvc;
using swagtest.Models;

namespace swagtest.Controllers
{
  [Route("api/[controller]")]
  public class SwagController : Controller
  {

    public SwagController()
    {
          
    }

    [HttpGet("{firstName}/{lastName}")]
    public Person Get(string firstName, string lastName)
    {
        var p = new Person(){FirstName=firstName, LastName=lastName};
        p.SetFullName();
        return p;
    }

  }
}