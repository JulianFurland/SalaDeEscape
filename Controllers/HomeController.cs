using Microsoft.AspNetCore.Mvc;

namespace TPSalaDeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
     public IActionResult Tutorial()
    {
        return View();
    }
       public IActionResult Creditos()
    {
        return View();
    }
     public IActionResult Comenzar()
    {
        ViewBag.Error = false;
        return View("Habitacion"+Escape.GetEstadoJuego());
    }
     public IActionResult Habitacion(int sala, string clave)
    {
        if(!Escape.ResolverSala(sala, clave)){
            ViewBag.Error = true;
        } else{
            ViewBag.Error = false;
        }
        
        return View("Habitacion"+Escape.GetEstadoJuego());
    }

}
