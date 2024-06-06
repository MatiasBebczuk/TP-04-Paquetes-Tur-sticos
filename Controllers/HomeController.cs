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
        ViewBag.ListaPaquetes = ORTworld.Paquetes;
        return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion){
        ViewBag.NombreProyecto = "La vasitlla de Nehuen";
        if(!(Destino > 10 || Destino < 1 || Hotel > 10 || Hotel < 1 || Aereo > 10 || Aereo < 1 || Excursion > 10 || Excursion < 1)){
            Paquete tempPaquete = new Paquete(ORTworld.ListaHoteles[Hotel - 1], ORTworld.ListaAereos[Aereo - 1], ORTworld.ListaExcursiones[Excursion - 1]);
            ORTworld.IngresarPaquete(ORTworld.ListaDestinos[Destino - 1], tempPaquete);
            return View();
        }
        else{
            ViewBag.erroMsg = "Error, los datos ingresados no son correctos";
            return View(SelectPaquete());
        }
    }
    public IActionResult SelectPaquete(){
        ViewBag.NombreProyecto = "La vasitlla de Nehuen";
        ViewBag.erroMsg = "Rellene el siguiente formulario";
        ViewBag.ListaPaquetes = ORTworld.Paquetes;
        ViewBag.ListaDestinos = ORTworld.ListaDestinos;
        ViewBag.ListaHoteles = ORTworld.ListaHoteles;
        ViewBag.ListaAereos = ORTworld.ListaAereos;
        ViewBag.ListaExcursiones = ORTworld.ListaExcursiones;
        return View();
    }
}