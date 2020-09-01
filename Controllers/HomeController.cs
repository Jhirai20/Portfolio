using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class IndexController : Controller
    {
        //Base route
        [HttpGet("")]
        public string Index()
        {
            return "Test Test";
        }

        //projects route
        [HttpGet("projects")]
        public string projects()
        {
            return "Here are my projects!";
        }
        //contact route
        [HttpGet("contacts")]
        public string contacts()
        {
            return "Here is my contact!";
        }

    }
}