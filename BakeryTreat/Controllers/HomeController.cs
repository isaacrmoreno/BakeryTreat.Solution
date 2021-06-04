using Microsoft.AspNetCore.Mvc;

namespace BakeryTreat.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}