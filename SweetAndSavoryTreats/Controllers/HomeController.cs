// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using SweetAndSavoryTreats.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace SweetAndSavoryTreats.Controllers
// {
//     public class HomeController : Controller
//     {
//       private readonly SweetAndSavoryTreatsContext _db;

//       public HomeController(SweetAndSavoryTreatsContext db)
//       {
//         _db = db;
//       }

//       public ActionResult Index()
//       {
//         ViewBag.Treat = new List<Treat>( _db.Treats);
//         return View( _db.Flavors.ToList());
//       }
//     }
// }