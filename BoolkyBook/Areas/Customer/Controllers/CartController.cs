using Microsoft.AspNetCore.Mvc;

namespace BoolkyBook.Controllers;

[Area("Customer")]
public class CartController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}