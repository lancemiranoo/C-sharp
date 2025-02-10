using System.Diagnostics;
using Contacts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.FName).ToList();
            return View(contacts);
        }
    }
}
