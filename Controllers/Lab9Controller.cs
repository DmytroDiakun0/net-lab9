using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Lab9Controller : Controller
    {
        public IActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetablesList();
            return View(vegetables);
        }

        public ActionResult SecondViewMethod()
        {
            return View(GetVegetablesList().OrderBy(x => x).ToList());
        }

        public ActionResult ThirdViewMethod()
        {
            return View(GetVegetablesList().OrderBy(x => x).ToList());
        }

        public List<string> GetVegetablesList()
        {
            List<string> vegetables = new List<string>();
            vegetables.Add("Томат");
            vegetables.Add("Огірок");
            vegetables.Add("Картопля");
            vegetables.Add("Кабачок");
            vegetables.Add("Баклажан");
            vegetables.Add("Капуста");
            vegetables.Add("Броколі");

            return vegetables;
        }
    }
}
