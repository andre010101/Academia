using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace modeView.Controllers
{
    public class HelloWorldController : Controller
    {
      
        public IActionResult welcome( string name, int numTimes = 1)
        {
            ViewData["message"] = "hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
