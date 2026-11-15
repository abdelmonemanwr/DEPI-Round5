using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class StateController : Controller
    {
        //int count = 0;
        // loc..../state/increament  => 1
        // loc..../state/increament  => 1
        public IActionResult Increament()
        {
            int count = 0;
            count++;
            return Content(count.ToString());
        }

        public IActionResult SetCookie()
        {
            HttpContext.Response.Cookies.Append("color", "white", new CookieOptions()
            {
                Expires = DateTimeOffset.UtcNow.AddHours(1),
                IsEssential = true,
                HttpOnly = true
            });
            return Content("Cookie Saved");
        }

        public IActionResult GetCookie(string key)
        {
            var result = HttpContext.Request.Cookies[key] ?? "Not found";
            return Content(result);
        }


        public IActionResult SetSession()
        {
            // Redis
            //HttpContext.Session.Set();
            //HttpContext.Session.SetString("")

            int count = FetchSession("count") ?? 0;
            count++;
            HttpContext.Session.SetInt32("count", count);
            return Content("data saved");
        }

        public IActionResult GetSession(string key)
        {
            int? count = FetchSession(key);
            if (count is null)
            {
                return Content($"{key} not found");
            }

            return Content($"{key} = {count}");
        }

        private int? FetchSession(string key)
        {
            return HttpContext.Session.GetInt32(key);
        }
    }
}
