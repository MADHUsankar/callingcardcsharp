using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace asp.Controllers
{
    public class HelloController : Controller
    {
        // A GET method
[HttpGet]
[Route("displayval")]
public JsonResult displayval()
{
    // var AnonObject = new {
    //                      FirstName = "Madhu",
    //                      LastName = "Sankar",
    //                      Age = 10,
    //                      favcolor="red"
    //                  };
    return Json(new Details("madhu","sankar",11,"red"));
}
 
// // A POST method
// [HttpPost]
// [Route("")]
// public IActionResult Other()
// {
//     // Return a view (We'll learn how soon!)
// }
    }
}