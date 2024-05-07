using Microsoft.AspNetCore.Mvc;

namespace myWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Salam(string name, string surname, int? id)
        {
            //return new JsonResult(new
            //{
            //    Name = "Nazrin",
            //    Surname = "Aliyeva",
            //    Age = 20
            //}) ;

            //ContentResult content = new ContentResult();
            //content.Content = "<p>Salam,...</p>";
            //content.ContentType = "text/html";
            //return content;


            //ViewResult result = new ViewResult();
            //result.ViewName = "Index";
            //return result;

            if (id == 0)
            {
                return Content(name + " " + surname + " " + id);

            }
            else
            {
                return Json(new
                {

                });
            }

        }
    }
}
