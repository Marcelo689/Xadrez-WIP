using Microsoft.AspNetCore.Mvc;
using Xadrez.Models;

namespace Xadrez.Controllers
{
    public class XadrezController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ViewModelXadrez();
            return View(viewModel);
        }
    }
}
