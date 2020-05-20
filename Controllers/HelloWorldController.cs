using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Text.Encodings.Web;

namespace LexDo.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        { 
            ViewData["Message"] = "Hello" + name;
            ViewData["Numtimes"] = numTimes;
            return View();
        }
    }
}