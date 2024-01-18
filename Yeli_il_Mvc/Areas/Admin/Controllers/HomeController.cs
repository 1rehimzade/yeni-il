using Microsoft.AspNetCore.Mvc;

namespace Yeli_il_Mvc.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
