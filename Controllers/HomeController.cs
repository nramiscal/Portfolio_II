using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }

        // [HttpGet]
        // [Route("{name}")]
        // public string Index(string name)
        // {
        //     return $"Hello {name}!";
        // }

        // [HttpGet]
        // [Route("user/{name}/{location}/{age}")]
        // public string UserInfo(string name, string location, int age)
        // {
        //     return $"{name}, aged {age}, is from {location}";
        // }

    }
}