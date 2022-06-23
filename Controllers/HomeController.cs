using H.W_9.Member;
using H.W_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace H.W_9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public object IuserREpository { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save()
        {
            var Users = userRepository.Regester();
            List<SelectListItem> USList = new();
            foreach (var user in Users)
            {
                USList.Add(new SelectListItem());
            }
            return View();
        }

        public IActionResult Edit(userRepository Users)
        {
            List<SelectListItem> USList = new();
            foreach (var item in userRepository.Regester())
            {
                USList.Find(item);
                foreach (var item2 in USList)
                {
                    USList.RemoveAt(USList.IndexOf(item));
                    for (int i = USList.Count - 1; i >= 0; i++)
                    {
                        USList[i].Selected = true;
                        USList.Add(new SelectListItem { Text = item2.Text });
                    }
                }
            }
            return View();
        }

        public IActionResult Delete()
        {

            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult View()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}