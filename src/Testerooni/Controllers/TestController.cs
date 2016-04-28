using Microsoft.AspNet.Mvc;

namespace Testerooni.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        [HttpGet]
        [Route("")]
        public void TestGet()
        {
            var request = Request;
        }

        [HttpPost]
        [Route("")]
        public void TestPost()
        {
            var request = Request;
        }
    }
}
