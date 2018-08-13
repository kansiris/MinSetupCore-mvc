using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MinSetupCore.Models;

using Omu.AwesomeMvc;

namespace MinSetupCore.Controllers.Awesome
{
    public class DataController : Controller
    {
        public ActionResult GetAllMeals()
        {
            var items = Db.Meals.Select(o => new KeyContent(o.Id, o.Name));
            return Json(items);
        }
    }
}