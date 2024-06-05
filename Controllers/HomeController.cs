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
        ViewBag.ListaDestinos = ORTworld.ListaDestinos;
        ViewBag.ListaHoteles = ORTworld.ListaHoteles;
        ViewBag.ListaAereos = ORTworld.ListaAereos;
        ViewBag.ListaExcursiones = ORTworld.ListaExcursiones;
        ViewBag.erroMsg = "Rellene el siguiente formulario";
        if(!(Destino > 9 || Destino < 0 || Hotel > 9 || Hotel < 0 || Aereo > 9 || Aereo < 0 || Excursion > 9 || Excursion < 0)){
            Paquete tempPaquete = new Paquete(ORTworld.ListaHoteles[Hotel], ORTworld.ListaAereos[Aereo], ORTworld.ListaExcursiones[Excursion]);
            ORTworld.IngresarPaquete(ORTworld.ListaDestinos[Destino], tempPaquete);
            Index();
        }
        else{
            ViewBag.erroMsg = "Error, los datos ingresados no son correctos";
        }
        return View();
    }
    public IActionResult SelectPaquete(){
        ViewBag.ListaPaquetes = ORTworld.Paquetes;
        return View();
    }
}