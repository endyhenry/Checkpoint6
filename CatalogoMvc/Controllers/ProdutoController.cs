using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoMvc.Models;

//namespace CatalogoMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.produto = new List<string> 
        {
            "Notebook", "Mouse", "Teclado", "Monitor", "Headset "
        };
        
        ViewBag.preco= new List<double>
        {
             1500.00, 150.00, 280.00, 2780.00, 540.00
        };


        return View();
    }

}
