using Microsoft.AspNetCore.Mvc;
using MyPartyInvites.Models;

namespace MyPartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        Repository.AddResponse(guestResponse);
        return View("Thank", guestResponse);
    }
}
