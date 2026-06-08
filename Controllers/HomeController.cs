using Microsoft.AspNetCore.Mvc;
using Busca_Endere_os.Models;

namespace Busca_Endere_os.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Buscar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Buscar(EnderecoViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        return RedirectToAction("Resultado", model);
    }

    [HttpGet]
    public IActionResult Resultado(EnderecoViewModel model)
    {
        return View(model);
    }
} 