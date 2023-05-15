using calculator_2_nub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calculator_2_nub.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Index(int num1, int num2, string op,string op1)
        {
            int result = 0;
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            op1 = op;
            ViewBag.n1 = num1;
            ViewBag.n2 = num2;

            ViewBag.op = op1;
            ViewBag.Result = result;
            return View();
        }

    }
}