using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCAlptekin1.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index1()
        {
            HttpContext.Session.SetString("name","Alptekin");
            return "Session has been set";
        }
        public string Index2()
        {
            return HttpContext.Session.GetString("name");
        }
    }
}
