using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.Web.Models;

namespace Blog.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var random = new Random();
        var blogs = Enumerable.Range(1, 20).Select(x => new Models.Blog
        {
            Name = $"Blog {x}",
            DateCreated = DateTimeOffset.Now.AddDays(random.Next(-10, 10)).AddMinutes(random.Next(-59, 59)),
            ImageSrc = "https://via.placeholder.com/468x240"
        }).ToList();
        
        return View(blogs);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}