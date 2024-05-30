using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.NombreProyecto = "La vasitlla de Nehuen";
        //ViewBag.DiccionaryPaquetes = new Dictionary<>
        return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion){
        ORTworld values = new ORTworld();
        
        Paquete tempPaquete = new Paquete(values.ListaDestinos[Destino], values.ListaHoteles[Hotel], values.ListaAereos[Aereo], values.ListaExcursiones[Excursion]);
        ViewBag.ListaDestinos = values.ListaDestinos;
        ViewBag.ListaHoteles = values.ListaHoteles;
        ViewBag.ListaAereos = values.ListaAereos;
        ViewBag.ListaExcursiones = values.ListaExcursiones;
        return View();
    }
}
