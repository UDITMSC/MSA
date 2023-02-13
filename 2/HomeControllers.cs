using System; using
System.Collections.Generic; using
System.Diagnostics; using
System.Linq; using
System.Threading.Tasks; using
Microsoft.AspNetCore.Mvc; using
Microsoft.Extensions.Logging; using
pracs2.Models;
 namespace
pracs2.Controllers;
 public class HomeController :
Controller
{
 public async Task <IActionResult> Index()
 {
 var model= new StockQuote{ Symbol="Nike", Price=3200};
 return View(model);
 }
} 
